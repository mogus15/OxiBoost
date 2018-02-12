namespace OxiBoost
{
    partial class Video
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.videoRich = new System.Windows.Forms.RichTextBox();
            this.labPathFile = new System.Windows.Forms.Label();
            this.pathVideo = new System.Windows.Forms.Label();
            this.BoostFile = new System.Windows.Forms.Button();
            this.FileVideo = new System.Windows.Forms.Button();
            this.FileNames = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // videoRich
            // 
            this.videoRich.BackColor = System.Drawing.Color.Black;
            this.videoRich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoRich.ForeColor = System.Drawing.Color.White;
            this.videoRich.Location = new System.Drawing.Point(7, 4);
            this.videoRich.Name = "videoRich";
            this.videoRich.Size = new System.Drawing.Size(234, 494);
            this.videoRich.TabIndex = 36;
            this.videoRich.Text = resources.GetString("videoRich.Text");
            // 
            // labPathFile
            // 
            this.labPathFile.AutoSize = true;
            this.labPathFile.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPathFile.Location = new System.Drawing.Point(40, 543);
            this.labPathFile.Name = "labPathFile";
            this.labPathFile.Size = new System.Drawing.Size(17, 13);
            this.labPathFile.TabIndex = 35;
            this.labPathFile.Text = "~~";
            this.labPathFile.Visible = false;
            // 
            // pathVideo
            // 
            this.pathVideo.AutoSize = true;
            this.pathVideo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathVideo.Location = new System.Drawing.Point(8, 541);
            this.pathVideo.Name = "pathVideo";
            this.pathVideo.Size = new System.Drawing.Size(35, 15);
            this.pathVideo.TabIndex = 34;
            this.pathVideo.Text = "Path:";
            // 
            // BoostFile
            // 
            this.BoostFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(92)))), ((int)(((byte)(176)))));
            this.BoostFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoostFile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoostFile.ForeColor = System.Drawing.Color.White;
            this.BoostFile.Location = new System.Drawing.Point(247, 504);
            this.BoostFile.Name = "BoostFile";
            this.BoostFile.Size = new System.Drawing.Size(226, 36);
            this.BoostFile.TabIndex = 33;
            this.BoostFile.Text = "Boost";
            this.BoostFile.UseVisualStyleBackColor = false;
            this.BoostFile.Click += new System.EventHandler(this.BoostFile_Click);
            // 
            // FileVideo
            // 
            this.FileVideo.BackColor = System.Drawing.Color.Transparent;
            this.FileVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileVideo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileVideo.ForeColor = System.Drawing.Color.Black;
            this.FileVideo.Location = new System.Drawing.Point(7, 504);
            this.FileVideo.Name = "FileVideo";
            this.FileVideo.Size = new System.Drawing.Size(234, 36);
            this.FileVideo.TabIndex = 32;
            this.FileVideo.Text = "Choose File";
            this.FileVideo.UseVisualStyleBackColor = false;
            this.FileVideo.Click += new System.EventHandler(this.FileVideo_Click);
            // 
            // FileNames
            // 
            this.FileNames.BackColor = System.Drawing.Color.Black;
            this.FileNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNames.ForeColor = System.Drawing.Color.White;
            this.FileNames.Location = new System.Drawing.Point(247, 4);
            this.FileNames.Name = "FileNames";
            this.FileNames.Size = new System.Drawing.Size(226, 494);
            this.FileNames.TabIndex = 37;
            this.FileNames.Text = "";
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileNames);
            this.Controls.Add(this.videoRich);
            this.Controls.Add(this.labPathFile);
            this.Controls.Add(this.pathVideo);
            this.Controls.Add(this.BoostFile);
            this.Controls.Add(this.FileVideo);
            this.Name = "Video";
            this.Size = new System.Drawing.Size(480, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox videoRich;
        private System.Windows.Forms.Label labPathFile;
        private System.Windows.Forms.Label pathVideo;
        private System.Windows.Forms.Button BoostFile;
        private System.Windows.Forms.Button FileVideo;
        private System.Windows.Forms.RichTextBox FileNames;
    }
}
