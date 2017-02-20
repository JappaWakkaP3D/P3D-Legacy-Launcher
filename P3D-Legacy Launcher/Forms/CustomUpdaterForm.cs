﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

using DamienG.Security.Cryptography;

using Octokit;

using P3D.Legacy.Launcher.Data;
using P3D.Legacy.Launcher.Extensions;
using P3D.Legacy.Launcher.Services;

namespace P3D.Legacy.Launcher.Forms
{
    internal partial class CustomUpdaterForm : Form
    {
        private WebClient Downloader { get; set; }
        private bool Cancelled { get; set; }

        private ReleaseAsset UpdateInfoAsset { get; }
        private string ReleaseInfoFilePath => FileSystem.TempFilePath(UpdateInfoAsset.Name);
        private string UpdatedFolderPath { get; }
        private Uri DLUri { get; }

        public CustomUpdaterForm(ReleaseAsset updateInfoAsset, string updatedFolderPath, Uri dlUri)
        {
            UpdateInfoAsset = updateInfoAsset;
            UpdatedFolderPath = updatedFolderPath;
            DLUri = dlUri;

            InitializeComponent();
        }

        private async void CustomUpdaterForm_Shown(object sender, EventArgs e)
        {
            if (!Directory.Exists(FileSystem.TempFolderPath))
                Directory.CreateDirectory(FileSystem.TempFolderPath);

            await Task.Run(DownloadFile);
            Close();
        }

        private async Task DownloadFile()
        {
            if (File.Exists(ReleaseInfoFilePath))
                File.Delete(ReleaseInfoFilePath);

            try
            {
                PercentageProgressBar.SafeInvoke(() => PercentageProgressBar.Maximum = UpdateInfoAsset.Size);
                using (Downloader = new WebClient())
                {
                    Downloader.DownloadProgressChanged += client_DownloadProgressChanged;
                    await Downloader.DownloadFileTaskAsync(UpdateInfoAsset.BrowserDownloadUrl, ReleaseInfoFilePath);
                }
            }
            catch (WebException) { DownloadErrorMessage(); return; }
            if (Cancelled) return;


            if (File.Exists(ReleaseInfoFilePath))
            {
                var list = StartUpdate();
                if (Cancelled) return;

                if (list.Any())
                {
                    UpdateFiles(list);
                    if (Cancelled) return;
                    UpdatedMessage();
                }
                else
                    NoUpdateNeededMessage();
            }
            else
                DownloadErrorMessage();
        }
        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PercentageProgressBar.SafeInvoke(() => PercentageProgressBar.Value = (int) e.BytesReceived);
        }

        private List<UpdateFileEntryYaml> StartUpdate()
        {
            if (Cancelled) return new List<UpdateFileEntryYaml>();

            Label_ProgressBar1.SafeInvoke(() => Label_ProgressBar1.Text = Label_ProgressBar2.Text);

            var releaseInfoContent = File.ReadAllText(ReleaseInfoFilePath);
            var updateInfo = UpdateInfoYaml.Deserialize(releaseInfoContent);

            var crc32 = new Crc32();
            var sha1 = new SHA1Managed();
            var notValidFileEntries = new List<UpdateFileEntryYaml>();
            PercentageProgressBar.SafeInvoke(delegate { PercentageProgressBar.Maximum = updateInfo.Files.Count; PercentageProgressBar.Step = 1; PercentageProgressBar.Value = 0; });
            Parallel.ForEach(updateInfo.Files, (updateFileEntry, state) =>
            {
                if(Cancelled) state.Stop();

                PercentageProgressBar.SafeInvoke(() => PercentageProgressBar.PerformStep());

                var filePath = Path.Combine(UpdatedFolderPath, updateFileEntry.AbsoluteFilePath);
                if (!File.Exists(filePath))
                {
                    notValidFileEntries.Add(updateFileEntry);
                    return;
                }
                using (var fs = File.Open(filePath, System.IO.FileMode.Open, FileAccess.Read))
                {
                    var crc32Hash = string.Empty;
                    var sha1Hash = string.Empty;
                    crc32Hash = crc32.ComputeHash(fs).Aggregate(crc32Hash, (current, b) => current + b.ToString("x2").ToLower());
                    if (crc32Hash == updateFileEntry.CRC32)
                    {
                        sha1Hash = sha1.ComputeHash(fs).Aggregate(sha1Hash, (current, b) => current + b.ToString("x2").ToLower());
                        if (sha1Hash == updateFileEntry.SHA1)
                            return;
                        else
                        {
                            notValidFileEntries.Add(updateFileEntry);
                            return;
                        }
                    }
                    else
                    {
                        notValidFileEntries.Add(updateFileEntry);
                        return;
                    }
                }
            });

            return notValidFileEntries;
        }
        private void UpdateFiles(List<UpdateFileEntryYaml> updateFileEntries)
        {
            if (Cancelled) return;

            Label_ProgressBar1.SafeInvoke(() => Label_ProgressBar1.Text = Label_ProgressBar3.Text);

            try
            {
                PercentageProgressBar.SafeInvoke(delegate { PercentageProgressBar.Maximum = updateFileEntries.Count; PercentageProgressBar.Step = 1; PercentageProgressBar.Value = 0; });
                Parallel.ForEach(updateFileEntries, (updateFileEntry, state) =>
                {
                    if (Cancelled) state.Stop();

                    var dlUri = new Uri(DLUri, updateFileEntry.AbsoluteFilePath);
                    var tempFilePath = FileSystem.TempFilePath(updateFileEntry.AbsoluteFilePath);
                    var tempFolderpath = Path.GetDirectoryName(tempFilePath);
                    if (!string.IsNullOrEmpty(tempFolderpath) && !Directory.Exists(tempFolderpath))
                        Directory.CreateDirectory(tempFolderpath);

                    using (var downloader = new WebClient())
                    {
                        downloader.DownloadFile(dlUri, tempFilePath);
                        PercentageProgressBar.SafeInvoke(() => PercentageProgressBar.PerformStep());
                    }
                });
            }
            catch (UriFormatException)          { DownloadErrorMessage(); return; }
            catch (UnauthorizedAccessException) { DownloadErrorMessage(); return; }
            catch (IOException)                 { DownloadErrorMessage(); return; }
            catch (WebException)                { DownloadErrorMessage(); return; }
            
            ReplaceFiles(updateFileEntries);
        }
        private void ReplaceFiles(List<UpdateFileEntryYaml> updateFileEntries)
        {
            if (Cancelled) return;

            try
            {
                Parallel.ForEach(updateFileEntries, (updateFileEntry, state) =>
                {
                    if (Cancelled) state.Break();

                    var tempFilePath = FileSystem.TempFilePath(updateFileEntry.AbsoluteFilePath);
                    var filePath = Path.Combine(UpdatedFolderPath, updateFileEntry.AbsoluteFilePath);

                    if (File.Exists(filePath))
                        File.Delete(filePath);
                    File.Move(tempFilePath, filePath);
                    File.Delete(tempFilePath);
                });
            }
            catch (UnauthorizedAccessException) { FileReplacementErrorMessage(); return; }
            catch (IOException) { FileReplacementErrorMessage(); return; }
        }
        private void CustomUpdaterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cancelled = true;
            Downloader?.CancelAsync();

            Directory.Delete(FileSystem.TempFolderPath, true);
        }


        private void DownloadErrorMessage()
        {
            MessageBox.Show(MBLang.DownloadError, MBLang.DownloadErrorTitle, MessageBoxButtons.OK);
            if (Cancelled) return;
            this.SafeInvoke(Close);
        }
        private void FileReplacementErrorMessage()
        {
            MessageBox.Show(MBLang.FileReplacementError, MBLang.FileReplacementErrorTitle, MessageBoxButtons.OK);
            if (Cancelled) return;
            this.SafeInvoke(Close);
        }
        private void NoUpdateNeededMessage()
        {
            MessageBox.Show(MBLang.NoUpdateNeeded, MBLang.NoUpdateNeededTitle, MessageBoxButtons.OK);
            if (Cancelled) return;
            this.SafeInvoke(Close);
        }
        private void UpdatedMessage()
        {
            MessageBox.Show(MBLang.Updated, MBLang.UpdatedTitle, MessageBoxButtons.OK);
            if (Cancelled) return;
            this.SafeInvoke(Close);
        }
    }
}
