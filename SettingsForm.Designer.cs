namespace win_audio_analyzer
{
    partial class SettingsForm
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
            this.okBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.apiLbl = new System.Windows.Forms.Label();
            this.apiTbx = new System.Windows.Forms.TextBox();
            this.connBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(260, 55);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(16, 55);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Cancel";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // apiLbl
            // 
            this.apiLbl.AutoSize = true;
            this.apiLbl.Location = new System.Drawing.Point(13, 13);
            this.apiLbl.Name = "apiLbl";
            this.apiLbl.Size = new System.Drawing.Size(69, 13);
            this.apiLbl.TabIndex = 2;
            this.apiLbl.Text = "API Endpoint";
            // 
            // apiTbx
            // 
            this.apiTbx.Location = new System.Drawing.Point(16, 29);
            this.apiTbx.Name = "apiTbx";
            this.apiTbx.Size = new System.Drawing.Size(319, 20);
            this.apiTbx.TabIndex = 3;
            // 
            // connBtn
            // 
            this.connBtn.Location = new System.Drawing.Point(97, 55);
            this.connBtn.Name = "connBtn";
            this.connBtn.Size = new System.Drawing.Size(157, 23);
            this.connBtn.TabIndex = 4;
            this.connBtn.Text = "Test connection";
            this.connBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(347, 86);
            this.Controls.Add(this.connBtn);
            this.Controls.Add(this.apiTbx);
            this.Controls.Add(this.apiLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label apiLbl;
        private System.Windows.Forms.TextBox apiTbx;
        private System.Windows.Forms.Button connBtn;
    }
}