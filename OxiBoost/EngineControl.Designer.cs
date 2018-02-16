namespace OxiBoost
{
    partial class EngineControl
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
            this.tabEngine = new System.Windows.Forms.TabControl();
            this.tabEB = new System.Windows.Forms.TabPage();
            this.engineBPanel = new System.Windows.Forms.Panel();
            this.Spec = new System.Windows.Forms.Label();
            this.labPathEngine = new System.Windows.Forms.Label();
            this.pathEngine = new System.Windows.Forms.Label();
            this.labBoost = new System.Windows.Forms.Label();
            this.labCurrent = new System.Windows.Forms.Label();
            this.FoostEngine = new System.Windows.Forms.Button();
            this.FileEngine = new System.Windows.Forms.Button();
            this.optiRich = new System.Windows.Forms.RichTextBox();
            this.currentRich = new System.Windows.Forms.RichTextBox();
            this.itemSelect = new System.Windows.Forms.ComboBox();
            this.tabHB = new System.Windows.Forms.TabPage();
            this.HelpComboBox = new System.Windows.Forms.ComboBox();
            this.tutPicBox = new System.Windows.Forms.PictureBox();
            this.externalConfig1 = new OxiBoost.ExternalConfig();
            this.partyUI1 = new OxiBoost.PartyUI();
            this.video1 = new OxiBoost.Video();
            this.s1UIControl1 = new OxiBoost.S1UIControl();
            this.tabEngine.SuspendLayout();
            this.tabEB.SuspendLayout();
            this.engineBPanel.SuspendLayout();
            this.tabHB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEngine
            // 
            this.tabEngine.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabEngine.Controls.Add(this.tabEB);
            this.tabEngine.Controls.Add(this.tabHB);
            this.tabEngine.Location = new System.Drawing.Point(0, 0);
            this.tabEngine.Name = "tabEngine";
            this.tabEngine.SelectedIndex = 0;
            this.tabEngine.Size = new System.Drawing.Size(600, 597);
            this.tabEngine.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabEngine.TabIndex = 12;
            // 
            // tabEB
            // 
            this.tabEB.Controls.Add(this.engineBPanel);
            this.tabEB.Controls.Add(this.itemSelect);
            this.tabEB.Location = new System.Drawing.Point(4, 25);
            this.tabEB.Name = "tabEB";
            this.tabEB.Padding = new System.Windows.Forms.Padding(3);
            this.tabEB.Size = new System.Drawing.Size(592, 568);
            this.tabEB.TabIndex = 0;
            this.tabEB.Text = "Boost";
            this.tabEB.UseVisualStyleBackColor = true;
            // 
            // engineBPanel
            // 
            this.engineBPanel.BackColor = System.Drawing.SystemColors.Control;
            this.engineBPanel.Controls.Add(this.externalConfig1);
            this.engineBPanel.Controls.Add(this.Spec);
            this.engineBPanel.Controls.Add(this.labPathEngine);
            this.engineBPanel.Controls.Add(this.pathEngine);
            this.engineBPanel.Controls.Add(this.labBoost);
            this.engineBPanel.Controls.Add(this.labCurrent);
            this.engineBPanel.Controls.Add(this.FoostEngine);
            this.engineBPanel.Controls.Add(this.FileEngine);
            this.engineBPanel.Controls.Add(this.optiRich);
            this.engineBPanel.Controls.Add(this.currentRich);
            this.engineBPanel.Controls.Add(this.partyUI1);
            this.engineBPanel.Controls.Add(this.video1);
            this.engineBPanel.Controls.Add(this.s1UIControl1);
            this.engineBPanel.Location = new System.Drawing.Point(6, 6);
            this.engineBPanel.Name = "engineBPanel";
            this.engineBPanel.Size = new System.Drawing.Size(482, 556);
            this.engineBPanel.TabIndex = 22;
            // 
            // Spec
            // 
            this.Spec.AutoSize = true;
            this.Spec.Location = new System.Drawing.Point(232, 2);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(14, 13);
            this.Spec.TabIndex = 29;
            this.Spec.Text = "~";
            this.Spec.Visible = false;
            // 
            // labPathEngine
            // 
            this.labPathEngine.AutoSize = true;
            this.labPathEngine.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPathEngine.Location = new System.Drawing.Point(35, 543);
            this.labPathEngine.Name = "labPathEngine";
            this.labPathEngine.Size = new System.Drawing.Size(17, 13);
            this.labPathEngine.TabIndex = 28;
            this.labPathEngine.Text = "~~";
            this.labPathEngine.Visible = false;
            // 
            // pathEngine
            // 
            this.pathEngine.AutoSize = true;
            this.pathEngine.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathEngine.Location = new System.Drawing.Point(3, 541);
            this.pathEngine.Name = "pathEngine";
            this.pathEngine.Size = new System.Drawing.Size(35, 15);
            this.pathEngine.TabIndex = 27;
            this.pathEngine.Text = "Path:";
            // 
            // labBoost
            // 
            this.labBoost.AutoSize = true;
            this.labBoost.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBoost.Location = new System.Drawing.Point(336, 0);
            this.labBoost.Name = "labBoost";
            this.labBoost.Size = new System.Drawing.Size(62, 15);
            this.labBoost.TabIndex = 26;
            this.labBoost.Text = "Optimized";
            // 
            // labCurrent
            // 
            this.labCurrent.AutoSize = true;
            this.labCurrent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrent.Location = new System.Drawing.Point(84, 0);
            this.labCurrent.Name = "labCurrent";
            this.labCurrent.Size = new System.Drawing.Size(48, 15);
            this.labCurrent.TabIndex = 25;
            this.labCurrent.Text = "Current";
            // 
            // FoostEngine
            // 
            this.FoostEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(92)))), ((int)(((byte)(176)))));
            this.FoostEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoostEngine.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoostEngine.ForeColor = System.Drawing.Color.White;
            this.FoostEngine.Location = new System.Drawing.Point(244, 502);
            this.FoostEngine.Name = "FoostEngine";
            this.FoostEngine.Size = new System.Drawing.Size(226, 36);
            this.FoostEngine.TabIndex = 24;
            this.FoostEngine.Text = "Boost";
            this.FoostEngine.UseVisualStyleBackColor = false;
            this.FoostEngine.Click += new System.EventHandler(this.BoostEngine_Click_1);
            // 
            // FileEngine
            // 
            this.FileEngine.BackColor = System.Drawing.Color.Transparent;
            this.FileEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileEngine.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileEngine.ForeColor = System.Drawing.Color.Black;
            this.FileEngine.Location = new System.Drawing.Point(3, 502);
            this.FileEngine.Name = "FileEngine";
            this.FileEngine.Size = new System.Drawing.Size(234, 36);
            this.FileEngine.TabIndex = 23;
            this.FileEngine.Text = "Choose File";
            this.FileEngine.UseVisualStyleBackColor = false;
            this.FileEngine.Click += new System.EventHandler(this.FileEngine_Click);
            // 
            // optiRich
            // 
            this.optiRich.Location = new System.Drawing.Point(244, 18);
            this.optiRich.Name = "optiRich";
            this.optiRich.Size = new System.Drawing.Size(226, 478);
            this.optiRich.TabIndex = 22;
            this.optiRich.Text = "";
            // 
            // currentRich
            // 
            this.currentRich.Location = new System.Drawing.Point(6, 18);
            this.currentRich.Name = "currentRich";
            this.currentRich.Size = new System.Drawing.Size(231, 478);
            this.currentRich.TabIndex = 21;
            this.currentRich.Text = "";
            // 
            // itemSelect
            // 
            this.itemSelect.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSelect.FormattingEnabled = true;
            this.itemSelect.Items.AddRange(new object[] {
            "Engine",
            "S1UI",
            "Videos ",
            "Custom UI",
            "External"});
            this.itemSelect.Location = new System.Drawing.Point(494, 6);
            this.itemSelect.Name = "itemSelect";
            this.itemSelect.Size = new System.Drawing.Size(92, 31);
            this.itemSelect.TabIndex = 21;
            this.itemSelect.SelectedIndexChanged += new System.EventHandler(this.itemSelect_SelectedIndexChanged);
            // 
            // tabHB
            // 
            this.tabHB.Controls.Add(this.HelpComboBox);
            this.tabHB.Controls.Add(this.tutPicBox);
            this.tabHB.Location = new System.Drawing.Point(4, 25);
            this.tabHB.Name = "tabHB";
            this.tabHB.Padding = new System.Windows.Forms.Padding(3);
            this.tabHB.Size = new System.Drawing.Size(592, 568);
            this.tabHB.TabIndex = 1;
            this.tabHB.Text = "Help";
            this.tabHB.UseVisualStyleBackColor = true;
            // 
            // HelpComboBox
            // 
            this.HelpComboBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpComboBox.FormattingEnabled = true;
            this.HelpComboBox.Items.AddRange(new object[] {
            "Engine Help",
            "S1UI Help",
            "Videos Help",
            "Custom UI Help",
            "[Nvidia] GPU Settings Help",
            "Prio Settings Help",
            ""});
            this.HelpComboBox.Location = new System.Drawing.Point(339, 6);
            this.HelpComboBox.Name = "HelpComboBox";
            this.HelpComboBox.Size = new System.Drawing.Size(247, 31);
            this.HelpComboBox.TabIndex = 22;
            this.HelpComboBox.SelectedIndexChanged += new System.EventHandler(this.HelpComboBox_SelectedIndexChanged_1);
            // 
            // tutPicBox
            // 
            this.tutPicBox.Location = new System.Drawing.Point(7, 43);
            this.tutPicBox.Name = "tutPicBox";
            this.tutPicBox.Size = new System.Drawing.Size(579, 519);
            this.tutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tutPicBox.TabIndex = 0;
            this.tutPicBox.TabStop = false;
            // 
            // externalConfig1
            // 
            this.externalConfig1.Location = new System.Drawing.Point(1, -2);
            this.externalConfig1.Name = "externalConfig1";
            this.externalConfig1.Size = new System.Drawing.Size(480, 560);
            this.externalConfig1.TabIndex = 33;
            // 
            // partyUI1
            // 
            this.partyUI1.Location = new System.Drawing.Point(2, 2);
            this.partyUI1.Name = "partyUI1";
            this.partyUI1.Size = new System.Drawing.Size(480, 560);
            this.partyUI1.TabIndex = 32;
            // 
            // video1
            // 
            this.video1.Location = new System.Drawing.Point(2, 2);
            this.video1.Name = "video1";
            this.video1.Size = new System.Drawing.Size(480, 560);
            this.video1.TabIndex = 31;
            // 
            // s1UIControl1
            // 
            this.s1UIControl1.Location = new System.Drawing.Point(-1, 0);
            this.s1UIControl1.Name = "s1UIControl1";
            this.s1UIControl1.Size = new System.Drawing.Size(480, 560);
            this.s1UIControl1.TabIndex = 30;
            // 
            // EngineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabEngine);
            this.Name = "EngineControl";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.EngineControl_Load);
            this.tabEngine.ResumeLayout(false);
            this.tabEB.ResumeLayout(false);
            this.engineBPanel.ResumeLayout(false);
            this.engineBPanel.PerformLayout();
            this.tabHB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEngine;
        private System.Windows.Forms.TabPage tabEB;
        private System.Windows.Forms.TabPage tabHB;
        private System.Windows.Forms.PictureBox tutPicBox;
        private System.Windows.Forms.Panel engineBPanel;
        private System.Windows.Forms.Label Spec;
        private System.Windows.Forms.Label labPathEngine;
        private System.Windows.Forms.Label pathEngine;
        private System.Windows.Forms.Label labBoost;
        private System.Windows.Forms.Label labCurrent;
        private System.Windows.Forms.Button FoostEngine;
        private System.Windows.Forms.Button FileEngine;
        private System.Windows.Forms.RichTextBox optiRich;
        private System.Windows.Forms.RichTextBox currentRich;
        private S1UIControl s1UIControl1;
        private System.Windows.Forms.ComboBox itemSelect;
        private Video video1;
        private PartyUI partyUI1;
        private System.Windows.Forms.ComboBox HelpComboBox;
        private ExternalConfig externalConfig1;
    }
}
