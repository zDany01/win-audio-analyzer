using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_audio_analyzer
{
    public partial class SettingsForm: Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.exitBtn.Click += (_, __) => this.Close();
            this.okBtn.Click += OkBtn_Click;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
