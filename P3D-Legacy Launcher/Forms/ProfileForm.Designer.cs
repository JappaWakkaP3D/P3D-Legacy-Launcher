﻿namespace P3D.Legacy.Launcher.Forms
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.GroupBox_ProfileInfo = new P3D.Legacy.Launcher.Controls.LocalizableGroupBox();
            this.Button_OpenProfileDir = new P3D.Legacy.Launcher.Controls.LocalizableButton();
            this.Label_LaunchArgs = new P3D.Legacy.Launcher.Controls.LocalizableLabel();
            this.TextBox_LaunchArgs = new System.Windows.Forms.TextBox();
            this.Label_NoEdit = new P3D.Legacy.Launcher.Controls.LocalizableLabel();
            this.ComboBox_Type = new System.Windows.Forms.ComboBox();
            this.Label_ProfileType = new P3D.Legacy.Launcher.Controls.LocalizableLabel();
            this.ComboBox_Version = new System.Windows.Forms.ComboBox();
            this.Label_Version = new P3D.Legacy.Launcher.Controls.LocalizableLabel();
            this.TextBox_ProfileName = new System.Windows.Forms.TextBox();
            this.Label_ProfileName = new P3D.Legacy.Launcher.Controls.LocalizableLabel();
            this.Button_SaveProfile = new P3D.Legacy.Launcher.Controls.LocalizableButton();
            this.Button_Cancel = new P3D.Legacy.Launcher.Controls.LocalizableButton();
            this.GroupBox_Modifications = new P3D.Legacy.Launcher.Controls.LocalizableGroupBox();
            this.GroupBox_ProfileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_ProfileInfo
            // 
            this.GroupBox_ProfileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ProfileInfo.Controls.Add(this.Button_OpenProfileDir);
            this.GroupBox_ProfileInfo.Controls.Add(this.Label_LaunchArgs);
            this.GroupBox_ProfileInfo.Controls.Add(this.TextBox_LaunchArgs);
            this.GroupBox_ProfileInfo.Controls.Add(this.Label_NoEdit);
            this.GroupBox_ProfileInfo.Controls.Add(this.ComboBox_Type);
            this.GroupBox_ProfileInfo.Controls.Add(this.Label_ProfileType);
            this.GroupBox_ProfileInfo.Controls.Add(this.ComboBox_Version);
            this.GroupBox_ProfileInfo.Controls.Add(this.Label_Version);
            this.GroupBox_ProfileInfo.Controls.Add(this.TextBox_ProfileName);
            this.GroupBox_ProfileInfo.Controls.Add(this.Label_ProfileName);
            this.GroupBox_ProfileInfo.Location = new System.Drawing.Point(12, 6);
            this.GroupBox_ProfileInfo.Name = "GroupBox_ProfileInfo";
            this.GroupBox_ProfileInfo.Size = new System.Drawing.Size(430, 175);
            this.GroupBox_ProfileInfo.TabIndex = 0;
            this.GroupBox_ProfileInfo.TabStop = false;
            this.GroupBox_ProfileInfo.Text = "pf_groupbox_profileinfo";
            // 
            // Button_OpenProfileDir
            // 
            this.Button_OpenProfileDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OpenProfileDir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button_OpenProfileDir.Location = new System.Drawing.Point(274, 125);
            this.Button_OpenProfileDir.Name = "Button_OpenProfileDir";
            this.Button_OpenProfileDir.Size = new System.Drawing.Size(150, 23);
            this.Button_OpenProfileDir.TabIndex = 3;
            this.Button_OpenProfileDir.Text = "pf_button_openprofiledir";
            this.Button_OpenProfileDir.UseVisualStyleBackColor = true;
            this.Button_OpenProfileDir.Click += new System.EventHandler(this.Button_OpenProfileDir_Click);
            // 
            // Label_LaunchArgs
            // 
            this.Label_LaunchArgs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_LaunchArgs.Location = new System.Drawing.Point(6, 102);
            this.Label_LaunchArgs.Name = "Label_LaunchArgs";
            this.Label_LaunchArgs.Size = new System.Drawing.Size(132, 13);
            this.Label_LaunchArgs.TabIndex = 6;
            this.Label_LaunchArgs.Text = "pf_label_launchargs";
            // 
            // TextBox_LaunchArgs
            // 
            this.TextBox_LaunchArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_LaunchArgs.Location = new System.Drawing.Point(144, 99);
            this.TextBox_LaunchArgs.Name = "TextBox_LaunchArgs";
            this.TextBox_LaunchArgs.Size = new System.Drawing.Size(280, 20);
            this.TextBox_LaunchArgs.TabIndex = 5;
            // 
            // Label_NoEdit
            // 
            this.Label_NoEdit.ForeColor = System.Drawing.Color.Red;
            this.Label_NoEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_NoEdit.Location = new System.Drawing.Point(9, 122);
            this.Label_NoEdit.Name = "Label_NoEdit";
            this.Label_NoEdit.Size = new System.Drawing.Size(259, 40);
            this.Label_NoEdit.TabIndex = 4;
            this.Label_NoEdit.Text = "pf_label_noedit";
            this.Label_NoEdit.Visible = false;
            // 
            // ComboBox_Type
            // 
            this.ComboBox_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Type.FormattingEnabled = true;
            this.ComboBox_Type.Location = new System.Drawing.Point(144, 19);
            this.ComboBox_Type.Name = "ComboBox_Type";
            this.ComboBox_Type.Size = new System.Drawing.Size(280, 21);
            this.ComboBox_Type.TabIndex = 0;
            this.ComboBox_Type.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Type_SelectedIndexChanged);
            // 
            // Label_ProfileType
            // 
            this.Label_ProfileType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_ProfileType.Location = new System.Drawing.Point(6, 22);
            this.Label_ProfileType.Name = "Label_ProfileType";
            this.Label_ProfileType.Size = new System.Drawing.Size(132, 13);
            this.Label_ProfileType.TabIndex = 0;
            this.Label_ProfileType.Text = "pf_label_profiletype";
            // 
            // ComboBox_Version
            // 
            this.ComboBox_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Version.FormattingEnabled = true;
            this.ComboBox_Version.Location = new System.Drawing.Point(144, 72);
            this.ComboBox_Version.Name = "ComboBox_Version";
            this.ComboBox_Version.Size = new System.Drawing.Size(280, 21);
            this.ComboBox_Version.TabIndex = 2;
            // 
            // Label_Version
            // 
            this.Label_Version.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_Version.Location = new System.Drawing.Point(6, 75);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(132, 13);
            this.Label_Version.TabIndex = 0;
            this.Label_Version.Text = "pf_label_version";
            // 
            // TextBox_ProfileName
            // 
            this.TextBox_ProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_ProfileName.Location = new System.Drawing.Point(144, 46);
            this.TextBox_ProfileName.Name = "TextBox_ProfileName";
            this.TextBox_ProfileName.Size = new System.Drawing.Size(280, 20);
            this.TextBox_ProfileName.TabIndex = 1;
            // 
            // Label_ProfileName
            // 
            this.Label_ProfileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_ProfileName.Location = new System.Drawing.Point(6, 49);
            this.Label_ProfileName.Name = "Label_ProfileName";
            this.Label_ProfileName.Size = new System.Drawing.Size(132, 13);
            this.Label_ProfileName.TabIndex = 0;
            this.Label_ProfileName.Text = "pf_label_profilename";
            // 
            // Button_SaveProfile
            // 
            this.Button_SaveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SaveProfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button_SaveProfile.Location = new System.Drawing.Point(322, 335);
            this.Button_SaveProfile.Name = "Button_SaveProfile";
            this.Button_SaveProfile.Size = new System.Drawing.Size(120, 23);
            this.Button_SaveProfile.TabIndex = 5;
            this.Button_SaveProfile.Text = "pf_button_save";
            this.Button_SaveProfile.UseVisualStyleBackColor = true;
            this.Button_SaveProfile.Click += new System.EventHandler(this.Button_SaveProfile_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button_Cancel.Location = new System.Drawing.Point(12, 335);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(120, 23);
            this.Button_Cancel.TabIndex = 6;
            this.Button_Cancel.Text = "pf_button_cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // GroupBox_Modifications
            // 
            this.GroupBox_Modifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Modifications.Enabled = false;
            this.GroupBox_Modifications.Location = new System.Drawing.Point(12, 187);
            this.GroupBox_Modifications.Name = "GroupBox_Modifications";
            this.GroupBox_Modifications.Size = new System.Drawing.Size(430, 142);
            this.GroupBox_Modifications.TabIndex = 14;
            this.GroupBox_Modifications.TabStop = false;
            this.GroupBox_Modifications.Text = "pf_groupbox_modifications";
            this.GroupBox_Modifications.Visible = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 366);
            this.Controls.Add(this.GroupBox_Modifications);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_SaveProfile);
            this.Controls.Add(this.GroupBox_ProfileInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(470, 400);
            this.MinimumSize = new System.Drawing.Size(470, 400);
            this.Name = "ProfileForm";
            this.StringID_Title = "pf_title";
            this.GroupBox_ProfileInfo.ResumeLayout(false);
            this.GroupBox_ProfileInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private P3D.Legacy.Launcher.Controls.LocalizableGroupBox GroupBox_ProfileInfo;
        private P3D.Legacy.Launcher.Controls.LocalizableButton Button_SaveProfile;
        private P3D.Legacy.Launcher.Controls.LocalizableButton Button_Cancel;
        private System.Windows.Forms.ComboBox ComboBox_Version;
        private P3D.Legacy.Launcher.Controls.LocalizableLabel Label_Version;
        private System.Windows.Forms.TextBox TextBox_ProfileName;
        private P3D.Legacy.Launcher.Controls.LocalizableLabel Label_ProfileName;
        private P3D.Legacy.Launcher.Controls.LocalizableGroupBox GroupBox_Modifications;
        private Controls.LocalizableButton Button_OpenProfileDir;
        private System.Windows.Forms.ComboBox ComboBox_Type;
        private Controls.LocalizableLabel Label_ProfileType;
        private Controls.LocalizableLabel Label_NoEdit;
        private Controls.LocalizableLabel Label_LaunchArgs;
        private System.Windows.Forms.TextBox TextBox_LaunchArgs;
    }
}