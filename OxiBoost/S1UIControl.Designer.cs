namespace OxiBoost
{
    partial class S1UIControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S1UIControl));
            this.boostGPK = new System.Windows.Forms.Button();
            this.fileGPK = new System.Windows.Forms.Button();
            this.labPathGPK = new System.Windows.Forms.Label();
            this.pathGPK = new System.Windows.Forms.Label();
            this.gpk = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boostGPK
            // 
            this.boostGPK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(92)))), ((int)(((byte)(176)))));
            this.boostGPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boostGPK.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boostGPK.ForeColor = System.Drawing.Color.White;
            this.boostGPK.Location = new System.Drawing.Point(247, 503);
            this.boostGPK.Name = "boostGPK";
            this.boostGPK.Size = new System.Drawing.Size(226, 36);
            this.boostGPK.TabIndex = 26;
            this.boostGPK.Text = "Boost";
            this.boostGPK.UseVisualStyleBackColor = false;
            this.boostGPK.Click += new System.EventHandler(this.boostGPK_Click);
            // 
            // fileGPK
            // 
            this.fileGPK.BackColor = System.Drawing.Color.Transparent;
            this.fileGPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileGPK.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileGPK.ForeColor = System.Drawing.Color.Black;
            this.fileGPK.Location = new System.Drawing.Point(7, 503);
            this.fileGPK.Name = "fileGPK";
            this.fileGPK.Size = new System.Drawing.Size(234, 36);
            this.fileGPK.TabIndex = 25;
            this.fileGPK.Text = "Choose File";
            this.fileGPK.UseVisualStyleBackColor = false;
            this.fileGPK.Click += new System.EventHandler(this.FileGPK_Click);
            // 
            // labPathGPK
            // 
            this.labPathGPK.AutoSize = true;
            this.labPathGPK.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPathGPK.Location = new System.Drawing.Point(40, 542);
            this.labPathGPK.Name = "labPathGPK";
            this.labPathGPK.Size = new System.Drawing.Size(17, 13);
            this.labPathGPK.TabIndex = 30;
            this.labPathGPK.Text = "~~";
            this.labPathGPK.Visible = false;
            // 
            // pathGPK
            // 
            this.pathGPK.AutoSize = true;
            this.pathGPK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathGPK.Location = new System.Drawing.Point(8, 540);
            this.pathGPK.Name = "pathGPK";
            this.pathGPK.Size = new System.Drawing.Size(35, 15);
            this.pathGPK.TabIndex = 29;
            this.pathGPK.Text = "Path:";
            // 
            // gpk
            // 
            this.gpk.BackColor = System.Drawing.Color.Black;
            this.gpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpk.ForeColor = System.Drawing.Color.White;
            this.gpk.Location = new System.Drawing.Point(7, 3);
            this.gpk.Name = "gpk";
            this.gpk.Size = new System.Drawing.Size(466, 494);
            this.gpk.TabIndex = 31;
            this.gpk.Text = resources.GetString("gpk.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Warning!! Use with caution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "(RIP my boi Royce)";
            // 
            // S1UIControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpk);
            this.Controls.Add(this.labPathGPK);
            this.Controls.Add(this.pathGPK);
            this.Controls.Add(this.boostGPK);
            this.Controls.Add(this.fileGPK);
            this.Name = "S1UIControl";
            this.Size = new System.Drawing.Size(480, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boostGPK;
        private System.Windows.Forms.Button fileGPK;
        private System.Windows.Forms.Label labPathGPK;
        private System.Windows.Forms.Label pathGPK;
        private System.Windows.Forms.RichTextBox gpk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
