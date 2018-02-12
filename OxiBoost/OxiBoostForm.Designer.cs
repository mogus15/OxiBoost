namespace OxiBoost
{
    partial class OxiBoostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OxiBoostForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.minimizeB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLogo = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.animatePanel = new System.Windows.Forms.Panel();
            this.engineB = new System.Windows.Forms.Button();
            this.HomeB = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.engineControl1 = new OxiBoost.EngineControl();
            this.homeControl1 = new OxiBoost.HomeControl();
            this.TopPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(92)))), ((int)(((byte)(176)))));
            this.TopPanel.Controls.Add(this.minimizeB);
            this.TopPanel.Controls.Add(this.exitB);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(255, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(645, 52);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // minimizeB
            // 
            this.minimizeB.BackColor = System.Drawing.Color.Transparent;
            this.minimizeB.FlatAppearance.BorderSize = 0;
            this.minimizeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeB.ForeColor = System.Drawing.Color.White;
            this.minimizeB.Location = new System.Drawing.Point(550, -15);
            this.minimizeB.Name = "minimizeB";
            this.minimizeB.Size = new System.Drawing.Size(49, 45);
            this.minimizeB.TabIndex = 11;
            this.minimizeB.Text = "_";
            this.minimizeB.UseVisualStyleBackColor = false;
            this.minimizeB.Click += new System.EventHandler(this.minimizeB_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Transparent;
            this.exitB.FlatAppearance.BorderSize = 0;
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitB.ForeColor = System.Drawing.Color.White;
            this.exitB.Location = new System.Drawing.Point(596, 0);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(49, 28);
            this.exitB.TabIndex = 10;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Boost";
            // 
            // NameLogo
            // 
            this.NameLogo.AutoSize = true;
            this.NameLogo.BackColor = System.Drawing.Color.Transparent;
            this.NameLogo.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLogo.ForeColor = System.Drawing.Color.White;
            this.NameLogo.Location = new System.Drawing.Point(58, 0);
            this.NameLogo.Name = "NameLogo";
            this.NameLogo.Size = new System.Drawing.Size(64, 42);
            this.NameLogo.TabIndex = 8;
            this.NameLogo.Text = "Oxi";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SidePanel.Controls.Add(this.label2);
            this.SidePanel.Controls.Add(this.animatePanel);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Controls.Add(this.NameLogo);
            this.SidePanel.Controls.Add(this.engineB);
            this.SidePanel.Controls.Add(this.HomeB);
            this.SidePanel.Controls.Add(this.Logo);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(255, 700);
            this.SidePanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "by Billyy.Mays";
            // 
            // animatePanel
            // 
            this.animatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(92)))), ((int)(((byte)(176)))));
            this.animatePanel.Location = new System.Drawing.Point(0, 82);
            this.animatePanel.Name = "animatePanel";
            this.animatePanel.Size = new System.Drawing.Size(13, 61);
            this.animatePanel.TabIndex = 2;
            // 
            // engineB
            // 
            this.engineB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.engineB.FlatAppearance.BorderSize = 0;
            this.engineB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engineB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineB.ForeColor = System.Drawing.Color.White;
            this.engineB.Location = new System.Drawing.Point(12, 149);
            this.engineB.Name = "engineB";
            this.engineB.Size = new System.Drawing.Size(243, 61);
            this.engineB.TabIndex = 11;
            this.engineB.Text = "Boost";
            this.engineB.UseVisualStyleBackColor = false;
            this.engineB.Click += new System.EventHandler(this.engineB_Click);
            // 
            // HomeB
            // 
            this.HomeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeB.FlatAppearance.BorderSize = 0;
            this.HomeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeB.ForeColor = System.Drawing.Color.White;
            this.HomeB.Location = new System.Drawing.Point(12, 82);
            this.HomeB.Name = "HomeB";
            this.HomeB.Size = new System.Drawing.Size(244, 61);
            this.HomeB.TabIndex = 9;
            this.HomeB.Text = "Home";
            this.HomeB.UseVisualStyleBackColor = false;
            this.HomeB.Click += new System.EventHandler(this.HomeB_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::OxiBoost.Properties.Resources.iconpng;
            this.Logo.Location = new System.Drawing.Point(0, 441);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(256, 256);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // engineControl1
            // 
            this.engineControl1.BackColor = System.Drawing.Color.White;
            this.engineControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.engineControl1.Location = new System.Drawing.Point(278, 73);
            this.engineControl1.Name = "engineControl1";
            this.engineControl1.Size = new System.Drawing.Size(600, 600);
            this.engineControl1.TabIndex = 3;
            // 
            // homeControl1
            // 
            this.homeControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homeControl1.Location = new System.Drawing.Point(278, 73);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(600, 600);
            this.homeControl1.TabIndex = 2;
            // 
            // OxiBoostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.engineControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OxiBoostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OxiBoost";
            this.Load += new System.EventHandler(this.OxiBoostForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label NameLogo;
        private System.Windows.Forms.Button engineB;
        private System.Windows.Forms.Button HomeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizeB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Panel animatePanel;
        private HomeControl homeControl1;
        private System.Windows.Forms.Label label2;
        private EngineControl engineControl1;
    }
}

