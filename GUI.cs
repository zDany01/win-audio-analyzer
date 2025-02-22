using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_audio_analyzer
{
    public partial class GUI: Form
    {
        private const string REPO_URL = "https://github.com/zDany01/win-audio-analyzer";
        public GUI()
        {
            InitializeComponent();
            this.exitToolStripMenuItem.Click += (_, __) => Application.Exit();
            this.optionsToolStripMenuItem.Click += (_, __) => new SettingsForm().ShowDialog();
            this.repoToolStripMenuItem.Click += (_, __) => Process.Start(REPO_URL);
            this.aboutToolStripMenuItem.Click += (_, __) => new AboutForm().Show();
        }
    }
}
