namespace VoiceAssistant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxMic1 = new System.Windows.Forms.PictureBox();
            this.pbxMic2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMic2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxMic1
            // 
            this.pbxMic1.Image = ((System.Drawing.Image)(resources.GetObject("pbxMic1.Image")));
            this.pbxMic1.Location = new System.Drawing.Point(6, 80);
            this.pbxMic1.Name = "pbxMic1";
            this.pbxMic1.Size = new System.Drawing.Size(360, 346);
            this.pbxMic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMic1.TabIndex = 0;
            this.pbxMic1.TabStop = false;
            this.pbxMic1.Click += new System.EventHandler(this.PbxMic1_Click);
            // 
            // pbxMic2
            // 
            this.pbxMic2.Image = ((System.Drawing.Image)(resources.GetObject("pbxMic2.Image")));
            this.pbxMic2.Location = new System.Drawing.Point(6, 80);
            this.pbxMic2.Name = "pbxMic2";
            this.pbxMic2.Size = new System.Drawing.Size(360, 346);
            this.pbxMic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMic2.TabIndex = 1;
            this.pbxMic2.TabStop = false;
            this.pbxMic2.Click += new System.EventHandler(this.PbxMic2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speakToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speakToolStripMenuItem
            // 
            this.speakToolStripMenuItem.Name = "speakToolStripMenuItem";
            this.speakToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.speakToolStripMenuItem.Text = "Speak";
            this.speakToolStripMenuItem.Click += new System.EventHandler(this.SpeakMenu_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.pbxMic1);
            this.Controls.Add(this.pbxMic2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Voice Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMic2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMic1;
        private System.Windows.Forms.PictureBox pbxMic2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

