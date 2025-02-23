namespace win_audio_analyzer
{
    partial class GUI
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
            this.sourcesCbx = new System.Windows.Forms.ComboBox();
            this.recordBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.audioRbt = new System.Windows.Forms.RadioButton();
            this.procRbt = new System.Windows.Forms.RadioButton();
            this.guiMenuStrip = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBtn = new System.Windows.Forms.Button();
            this.playbackCbx = new System.Windows.Forms.CheckBox();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.guiMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourcesCbx
            // 
            this.sourcesCbx.FormattingEnabled = true;
            this.sourcesCbx.Location = new System.Drawing.Point(12, 52);
            this.sourcesCbx.Name = "sourcesCbx";
            this.sourcesCbx.Size = new System.Drawing.Size(332, 21);
            this.sourcesCbx.TabIndex = 0;
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(12, 79);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(166, 23);
            this.recordBtn.TabIndex = 1;
            this.recordBtn.Text = "Start Capture";
            this.recordBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select output source";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // audioRbt
            // 
            this.audioRbt.AutoSize = true;
            this.audioRbt.Checked = true;
            this.audioRbt.Location = new System.Drawing.Point(134, 32);
            this.audioRbt.Name = "audioRbt";
            this.audioRbt.Size = new System.Drawing.Size(87, 17);
            this.audioRbt.TabIndex = 3;
            this.audioRbt.TabStop = true;
            this.audioRbt.Text = "Audio Output";
            this.audioRbt.UseVisualStyleBackColor = true;
            // 
            // procRbt
            // 
            this.procRbt.AutoSize = true;
            this.procRbt.Enabled = false;
            this.procRbt.Location = new System.Drawing.Point(249, 32);
            this.procRbt.Name = "procRbt";
            this.procRbt.Size = new System.Drawing.Size(95, 17);
            this.procRbt.TabIndex = 4;
            this.procRbt.Text = "Single Process";
            this.procRbt.UseVisualStyleBackColor = true;
            // 
            // guiMenuStrip
            // 
            this.guiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.guiMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.guiMenuStrip.Name = "guiMenuStrip";
            this.guiMenuStrip.Size = new System.Drawing.Size(359, 24);
            this.guiMenuStrip.TabIndex = 5;
            this.guiMenuStrip.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.appToolStripMenuItem.Text = "&App";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.refreshToolStripMenuItem.Text = "Refresh Devices/Processes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repoToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // repoToolStripMenuItem
            // 
            this.repoToolStripMenuItem.Name = "repoToolStripMenuItem";
            this.repoToolStripMenuItem.ShowShortcutKeys = false;
            this.repoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.repoToolStripMenuItem.Text = "Repository";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(120, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(178, 79);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(166, 23);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop Capture";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // playbackCbx
            // 
            this.playbackCbx.AutoSize = true;
            this.playbackCbx.Location = new System.Drawing.Point(244, 112);
            this.playbackCbx.Name = "playbackCbx";
            this.playbackCbx.Size = new System.Drawing.Size(100, 17);
            this.playbackCbx.TabIndex = 7;
            this.playbackCbx.Text = "Listen playback";
            this.playbackCbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playbackCbx.UseVisualStyleBackColor = true;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(12, 108);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(226, 23);
            this.pauseBtn.TabIndex = 8;
            this.pauseBtn.Text = "TOGGLE_PAUSE_TEXT";
            this.pauseBtn.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 375);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.playbackCbx);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.procRbt);
            this.Controls.Add(this.audioRbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.sourcesCbx);
            this.Controls.Add(this.guiMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.guiMenuStrip;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "win-audio-analyzer";
            this.guiMenuStrip.ResumeLayout(false);
            this.guiMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sourcesCbx;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton audioRbt;
        private System.Windows.Forms.RadioButton procRbt;
        private System.Windows.Forms.MenuStrip guiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.CheckBox playbackCbx;
        private System.Windows.Forms.Button pauseBtn;
    }
}

