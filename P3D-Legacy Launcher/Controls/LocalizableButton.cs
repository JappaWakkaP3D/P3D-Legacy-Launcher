﻿using System.Windows.Forms;

using P3D.Legacy.Launcher.Services;

namespace P3D.Legacy.Launcher.Controls
{
    internal class LocalizableButton : Button
    {
        private string _stringID;
        public virtual string StringID_Text
        {
            get { return _stringID; }
            set { _stringID = value; Text = LocalizationUI.GetString(_stringID); }
        }
    }
}