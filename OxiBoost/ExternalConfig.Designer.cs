namespace OxiBoost
{
    partial class ExternalConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalConfig));
            this.tabExConfig = new System.Windows.Forms.TabControl();
            this.graphicsConfig = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ncSetLink = new System.Windows.Forms.LinkLabel();
            this.gpk = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.prioDL_link = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabExConfig.SuspendLayout();
            this.graphicsConfig.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabExConfig
            // 
            this.tabExConfig.Controls.Add(this.graphicsConfig);
            this.tabExConfig.Controls.Add(this.tabPage2);
            this.tabExConfig.Location = new System.Drawing.Point(3, 3);
            this.tabExConfig.Name = "tabExConfig";
            this.tabExConfig.SelectedIndex = 0;
            this.tabExConfig.Size = new System.Drawing.Size(474, 554);
            this.tabExConfig.TabIndex = 0;
            // 
            // graphicsConfig
            // 
            this.graphicsConfig.Controls.Add(this.tabControl1);
            this.graphicsConfig.Location = new System.Drawing.Point(4, 22);
            this.graphicsConfig.Name = "graphicsConfig";
            this.graphicsConfig.Padding = new System.Windows.Forms.Padding(3);
            this.graphicsConfig.Size = new System.Drawing.Size(466, 528);
            this.graphicsConfig.TabIndex = 0;
            this.graphicsConfig.Text = "GPU Settings";
            this.graphicsConfig.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ncSetLink);
            this.tabPage1.Controls.Add(this.gpk);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nvidia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ncSetLink
            // 
            this.ncSetLink.AutoSize = true;
            this.ncSetLink.BackColor = System.Drawing.Color.Black;
            this.ncSetLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncSetLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ncSetLink.Location = new System.Drawing.Point(201, 275);
            this.ncSetLink.Name = "ncSetLink";
            this.ncSetLink.Size = new System.Drawing.Size(64, 15);
            this.ncSetLink.TabIndex = 34;
            this.ncSetLink.TabStop = true;
            this.ncSetLink.Text = "ncSettings";
            this.ncSetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ncSetLink_LinkClicked);
            // 
            // gpk
            // 
            this.gpk.BackColor = System.Drawing.Color.Black;
            this.gpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpk.ForeColor = System.Drawing.Color.White;
            this.gpk.Location = new System.Drawing.Point(6, 3);
            this.gpk.Name = "gpk";
            this.gpk.Size = new System.Drawing.Size(440, 487);
            this.gpk.TabIndex = 32;
            this.gpk.Text = resources.GetString("gpk.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.prioDL_link);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // prioDL_link
            // 
            this.prioDL_link.AutoSize = true;
            this.prioDL_link.BackColor = System.Drawing.Color.Black;
            this.prioDL_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioDL_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.prioDL_link.Location = new System.Drawing.Point(161, 227);
            this.prioDL_link.Name = "prioDL_link";
            this.prioDL_link.Size = new System.Drawing.Size(63, 15);
            this.prioDL_link.TabIndex = 35;
            this.prioDL_link.TabStop = true;
            this.prioDL_link.Text = "Click Here";
            this.prioDL_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.prioDL_link_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(460, 519);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(446, 493);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Radeon";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coming Soon!";
            // 
            // ExternalConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabExConfig);
            this.Name = "ExternalConfig";
            this.Size = new System.Drawing.Size(480, 560);
            this.tabExConfig.ResumeLayout(false);
            this.graphicsConfig.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabExConfig;
        private System.Windows.Forms.TabPage graphicsConfig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox gpk;
        private System.Windows.Forms.LinkLabel ncSetLink;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel prioDL_link;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
    }
}
