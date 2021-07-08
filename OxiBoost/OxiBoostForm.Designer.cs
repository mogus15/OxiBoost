namespace Oxiboost
{
    partial class OxiboostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OxiboostForm));
            this.oxiboost_tabs = new MetroFramework.Controls.MetroTabControl();
            this.engine_tab = new MetroFramework.Controls.MetroTabPage();
            this.compinfo = new System.Windows.Forms.Label();
            this.status_label_text = new System.Windows.Forms.Label();
            this.boost_button = new MetroFramework.Controls.MetroButton();
            this.s1engine_dirs_list = new System.Windows.Forms.CheckedListBox();
            this.status_label = new MetroFramework.Controls.MetroLabel();
            this.s1engine_browse_button = new MetroFramework.Controls.MetroButton();
            this.s1engine_button = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.clean_drive_button = new MetroFramework.Controls.MetroButton();
            this.drive_clean_selectall = new System.Windows.Forms.CheckBox();
            this.drive_cleanup_list = new System.Windows.Forms.CheckedListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.tweak_button = new MetroFramework.Controls.MetroButton();
            this.serviceme_button = new MetroFramework.Controls.MetroButton();
            this.increase_perf_selectall = new System.Windows.Forms.CheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.increase_perf_list = new System.Windows.Forms.CheckedListBox();
            this.disable_services_selectall = new System.Windows.Forms.CheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.disable_services_list = new System.Windows.Forms.CheckedListBox();
            this.info_tab = new MetroFramework.Controls.MetroTabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.razercortex_link = new MetroFramework.Controls.MetroLink();
            this.hwmonitor_link = new MetroFramework.Controls.MetroLink();
            this.cpuz_link = new MetroFramework.Controls.MetroLink();
            this.ccleaner_link = new MetroFramework.Controls.MetroLink();
            this.prio_link = new MetroFramework.Controls.MetroLink();
            this.oxiboost_tabs.SuspendLayout();
            this.engine_tab.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.info_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // oxiboost_tabs
            // 
            this.oxiboost_tabs.Controls.Add(this.engine_tab);
            this.oxiboost_tabs.Controls.Add(this.metroTabPage2);
            this.oxiboost_tabs.Controls.Add(this.metroTabPage3);
            this.oxiboost_tabs.Controls.Add(this.info_tab);
            this.oxiboost_tabs.Location = new System.Drawing.Point(-2, -1);
            this.oxiboost_tabs.Name = "oxiboost_tabs";
            this.oxiboost_tabs.SelectedIndex = 0;
            this.oxiboost_tabs.Size = new System.Drawing.Size(800, 418);
            this.oxiboost_tabs.TabIndex = 23;
            this.oxiboost_tabs.UseSelectable = true;
            // 
            // engine_tab
            // 
            this.engine_tab.Controls.Add(this.compinfo);
            this.engine_tab.Controls.Add(this.status_label_text);
            this.engine_tab.Controls.Add(this.boost_button);
            this.engine_tab.Controls.Add(this.s1engine_dirs_list);
            this.engine_tab.Controls.Add(this.status_label);
            this.engine_tab.Controls.Add(this.s1engine_browse_button);
            this.engine_tab.Controls.Add(this.s1engine_button);
            this.engine_tab.HorizontalScrollbarBarColor = true;
            this.engine_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.engine_tab.HorizontalScrollbarSize = 10;
            this.engine_tab.Location = new System.Drawing.Point(4, 38);
            this.engine_tab.Name = "engine_tab";
            this.engine_tab.Size = new System.Drawing.Size(792, 376);
            this.engine_tab.TabIndex = 0;
            this.engine_tab.Text = "Engine Optimize";
            this.engine_tab.VerticalScrollbarBarColor = true;
            this.engine_tab.VerticalScrollbarHighlightOnWheel = false;
            this.engine_tab.VerticalScrollbarSize = 10;
            // 
            // compinfo
            // 
            this.compinfo.AutoSize = true;
            this.compinfo.BackColor = System.Drawing.Color.White;
            this.compinfo.Location = new System.Drawing.Point(5, 306);
            this.compinfo.Name = "compinfo";
            this.compinfo.Size = new System.Drawing.Size(16, 13);
            this.compinfo.TabIndex = 10;
            this.compinfo.Text = "...";
            // 
            // status_label_text
            // 
            this.status_label_text.AutoSize = true;
            this.status_label_text.BackColor = System.Drawing.Color.White;
            this.status_label_text.Location = new System.Drawing.Point(5, 358);
            this.status_label_text.Name = "status_label_text";
            this.status_label_text.Size = new System.Drawing.Size(16, 13);
            this.status_label_text.TabIndex = 9;
            this.status_label_text.Text = "...";
            // 
            // boost_button
            // 
            this.boost_button.Location = new System.Drawing.Point(599, 306);
            this.boost_button.Name = "boost_button";
            this.boost_button.Size = new System.Drawing.Size(186, 45);
            this.boost_button.TabIndex = 8;
            this.boost_button.Text = "Boost";
            this.boost_button.UseSelectable = true;
            this.boost_button.Click += new System.EventHandler(this.boost_button_Click);
            // 
            // s1engine_dirs_list
            // 
            this.s1engine_dirs_list.FormattingEnabled = true;
            this.s1engine_dirs_list.Location = new System.Drawing.Point(8, 16);
            this.s1engine_dirs_list.Name = "s1engine_dirs_list";
            this.s1engine_dirs_list.Size = new System.Drawing.Size(777, 229);
            this.s1engine_dirs_list.TabIndex = 7;
            this.s1engine_dirs_list.SelectedIndexChanged += new System.EventHandler(this.s1engine_dirs_list_SelectedIndexChanged);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(8, 388);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 0);
            this.status_label.TabIndex = 6;
            // 
            // s1engine_browse_button
            // 
            this.s1engine_browse_button.Location = new System.Drawing.Point(599, 255);
            this.s1engine_browse_button.Name = "s1engine_browse_button";
            this.s1engine_browse_button.Size = new System.Drawing.Size(186, 45);
            this.s1engine_browse_button.TabIndex = 5;
            this.s1engine_browse_button.Text = "Browse";
            this.s1engine_browse_button.UseSelectable = true;
            this.s1engine_browse_button.Click += new System.EventHandler(this.s1engine_browse_button_Click);
            // 
            // s1engine_button
            // 
            this.s1engine_button.Location = new System.Drawing.Point(8, 255);
            this.s1engine_button.Name = "s1engine_button";
            this.s1engine_button.Size = new System.Drawing.Size(168, 45);
            this.s1engine_button.TabIndex = 2;
            this.s1engine_button.Text = "Help me search for game files";
            this.s1engine_button.UseSelectable = true;
            this.s1engine_button.Click += new System.EventHandler(this.s1engine_button_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.clean_drive_button);
            this.metroTabPage2.Controls.Add(this.drive_clean_selectall);
            this.metroTabPage2.Controls.Add(this.drive_cleanup_list);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 376);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Cleaner";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // clean_drive_button
            // 
            this.clean_drive_button.Location = new System.Drawing.Point(9, 303);
            this.clean_drive_button.Name = "clean_drive_button";
            this.clean_drive_button.Size = new System.Drawing.Size(144, 65);
            this.clean_drive_button.TabIndex = 5;
            this.clean_drive_button.Text = "Clean";
            this.clean_drive_button.UseSelectable = true;
            this.clean_drive_button.Click += new System.EventHandler(this.clean_drive_button_Click);
            // 
            // drive_clean_selectall
            // 
            this.drive_clean_selectall.AutoSize = true;
            this.drive_clean_selectall.BackColor = System.Drawing.Color.White;
            this.drive_clean_selectall.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive_clean_selectall.Location = new System.Drawing.Point(9, 250);
            this.drive_clean_selectall.Name = "drive_clean_selectall";
            this.drive_clean_selectall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drive_clean_selectall.Size = new System.Drawing.Size(88, 23);
            this.drive_clean_selectall.TabIndex = 4;
            this.drive_clean_selectall.Text = "Select All";
            this.drive_clean_selectall.UseVisualStyleBackColor = false;
            this.drive_clean_selectall.CheckedChanged += new System.EventHandler(this.drive_clean_selectall_CheckedChanged);
            // 
            // drive_cleanup_list
            // 
            this.drive_cleanup_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drive_cleanup_list.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive_cleanup_list.FormattingEnabled = true;
            this.drive_cleanup_list.Items.AddRange(new object[] {
            "Temp files",
            "Windows + IIS logs",
            "Prefetch cache",
            "BSOD minidumps",
            "Error reports",
            "Empty recycle bin",
            "Media player cache",
            "Utorrent cache"});
            this.drive_cleanup_list.Location = new System.Drawing.Point(9, 46);
            this.drive_cleanup_list.Name = "drive_cleanup_list";
            this.drive_cleanup_list.Size = new System.Drawing.Size(248, 176);
            this.drive_cleanup_list.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Clean Up Drive";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.tweak_button);
            this.metroTabPage3.Controls.Add(this.serviceme_button);
            this.metroTabPage3.Controls.Add(this.increase_perf_selectall);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.increase_perf_list);
            this.metroTabPage3.Controls.Add(this.disable_services_selectall);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.disable_services_list);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(792, 376);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Windows 10";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // tweak_button
            // 
            this.tweak_button.Location = new System.Drawing.Point(489, 339);
            this.tweak_button.Name = "tweak_button";
            this.tweak_button.Size = new System.Drawing.Size(249, 34);
            this.tweak_button.TabIndex = 11;
            this.tweak_button.Text = "Tweak";
            this.tweak_button.UseSelectable = true;
            this.tweak_button.Click += new System.EventHandler(this.tweak_button_Click);
            // 
            // serviceme_button
            // 
            this.serviceme_button.Location = new System.Drawing.Point(9, 339);
            this.serviceme_button.Name = "serviceme_button";
            this.serviceme_button.Size = new System.Drawing.Size(234, 34);
            this.serviceme_button.TabIndex = 10;
            this.serviceme_button.Text = "Service Me";
            this.serviceme_button.UseSelectable = true;
            this.serviceme_button.Click += new System.EventHandler(this.serviceme_button_Click);
            // 
            // increase_perf_selectall
            // 
            this.increase_perf_selectall.AutoSize = true;
            this.increase_perf_selectall.BackColor = System.Drawing.Color.White;
            this.increase_perf_selectall.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase_perf_selectall.Location = new System.Drawing.Point(489, 310);
            this.increase_perf_selectall.Name = "increase_perf_selectall";
            this.increase_perf_selectall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.increase_perf_selectall.Size = new System.Drawing.Size(88, 23);
            this.increase_perf_selectall.TabIndex = 9;
            this.increase_perf_selectall.Text = "Select All";
            this.increase_perf_selectall.UseVisualStyleBackColor = false;
            this.increase_perf_selectall.CheckedChanged += new System.EventHandler(this.increase_perf_selectall_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(486, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(208, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Increase Windows 10 Performance";
            // 
            // increase_perf_list
            // 
            this.increase_perf_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.increase_perf_list.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase_perf_list.FormattingEnabled = true;
            this.increase_perf_list.Items.AddRange(new object[] {
            "Enable Performance Tweaks",
            "Disable Network Throttling",
            "Disable Media Player Sharing",
            "Block Skype Ads",
            "Disable Error Reporting",
            "Disable HomeGroup",
            "Disable Superfetch"});
            this.increase_perf_list.Location = new System.Drawing.Point(489, 31);
            this.increase_perf_list.Name = "increase_perf_list";
            this.increase_perf_list.Size = new System.Drawing.Size(249, 264);
            this.increase_perf_list.TabIndex = 7;
            // 
            // disable_services_selectall
            // 
            this.disable_services_selectall.AutoSize = true;
            this.disable_services_selectall.BackColor = System.Drawing.Color.White;
            this.disable_services_selectall.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disable_services_selectall.Location = new System.Drawing.Point(9, 310);
            this.disable_services_selectall.Name = "disable_services_selectall";
            this.disable_services_selectall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.disable_services_selectall.Size = new System.Drawing.Size(88, 23);
            this.disable_services_selectall.TabIndex = 6;
            this.disable_services_selectall.Text = "Select All";
            this.disable_services_selectall.UseVisualStyleBackColor = false;
            this.disable_services_selectall.CheckedChanged += new System.EventHandler(this.disable_services_selectall_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(240, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Turn on/off useless Windows 10 Services";
            // 
            // disable_services_list
            // 
            this.disable_services_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disable_services_list.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disable_services_list.FormattingEnabled = true;
            this.disable_services_list.Items.AddRange(new object[] {
            "Disable Start Menu Ads",
            "Disable Telemetry Services",
            "Disable Silent App Install",
            "Disable Cortana",
            "Disable Sensor Services",
            "Disable Windows Ink",
            "Disable Gamebar"});
            this.disable_services_list.Location = new System.Drawing.Point(9, 31);
            this.disable_services_list.Name = "disable_services_list";
            this.disable_services_list.Size = new System.Drawing.Size(218, 264);
            this.disable_services_list.TabIndex = 4;
            // 
            // info_tab
            // 
            this.info_tab.Controls.Add(this.richTextBox1);
            this.info_tab.Controls.Add(this.razercortex_link);
            this.info_tab.Controls.Add(this.hwmonitor_link);
            this.info_tab.Controls.Add(this.cpuz_link);
            this.info_tab.Controls.Add(this.ccleaner_link);
            this.info_tab.Controls.Add(this.prio_link);
            this.info_tab.HorizontalScrollbarBarColor = true;
            this.info_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.info_tab.HorizontalScrollbarSize = 10;
            this.info_tab.Location = new System.Drawing.Point(4, 38);
            this.info_tab.Name = "info_tab";
            this.info_tab.Size = new System.Drawing.Size(792, 376);
            this.info_tab.TabIndex = 3;
            this.info_tab.Text = "Info";
            this.info_tab.VerticalScrollbarBarColor = true;
            this.info_tab.VerticalScrollbarHighlightOnWheel = false;
            this.info_tab.VerticalScrollbarSize = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(109, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(675, 355);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // razercortex_link
            // 
            this.razercortex_link.Location = new System.Drawing.Point(3, 129);
            this.razercortex_link.Name = "razercortex_link";
            this.razercortex_link.Size = new System.Drawing.Size(93, 23);
            this.razercortex_link.TabIndex = 6;
            this.razercortex_link.Text = "Razer Cortex";
            this.razercortex_link.UseSelectable = true;
            this.razercortex_link.Click += new System.EventHandler(this.razercortex_link_Click);
            // 
            // hwmonitor_link
            // 
            this.hwmonitor_link.Location = new System.Drawing.Point(10, 71);
            this.hwmonitor_link.Name = "hwmonitor_link";
            this.hwmonitor_link.Size = new System.Drawing.Size(75, 23);
            this.hwmonitor_link.TabIndex = 5;
            this.hwmonitor_link.Text = "HWMonitor";
            this.hwmonitor_link.UseSelectable = true;
            this.hwmonitor_link.Click += new System.EventHandler(this.hwmonitor_link_Click);
            // 
            // cpuz_link
            // 
            this.cpuz_link.Location = new System.Drawing.Point(10, 100);
            this.cpuz_link.Name = "cpuz_link";
            this.cpuz_link.Size = new System.Drawing.Size(75, 23);
            this.cpuz_link.TabIndex = 4;
            this.cpuz_link.Text = "CPU-Z";
            this.cpuz_link.UseSelectable = true;
            this.cpuz_link.Click += new System.EventHandler(this.cpuz_link_Click);
            // 
            // ccleaner_link
            // 
            this.ccleaner_link.Location = new System.Drawing.Point(10, 42);
            this.ccleaner_link.Name = "ccleaner_link";
            this.ccleaner_link.Size = new System.Drawing.Size(75, 23);
            this.ccleaner_link.TabIndex = 3;
            this.ccleaner_link.Text = "CCleaner";
            this.ccleaner_link.UseSelectable = true;
            this.ccleaner_link.Click += new System.EventHandler(this.ccleaner_link_Click);
            // 
            // prio_link
            // 
            this.prio_link.Location = new System.Drawing.Point(10, 13);
            this.prio_link.Name = "prio_link";
            this.prio_link.Size = new System.Drawing.Size(75, 23);
            this.prio_link.TabIndex = 2;
            this.prio_link.Text = "Prio";
            this.prio_link.UseSelectable = true;
            this.prio_link.Click += new System.EventHandler(this.prio_link_Click);
            // 
            // OxiboostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(798, 417);
            this.Controls.Add(this.oxiboost_tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OxiboostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OxiBoost";
            this.Load += new System.EventHandler(this.OxiboostForm_Load);
            this.oxiboost_tabs.ResumeLayout(false);
            this.engine_tab.ResumeLayout(false);
            this.engine_tab.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.info_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl oxiboost_tabs;
        private MetroFramework.Controls.MetroTabPage engine_tab;
        private MetroFramework.Controls.MetroButton boost_button;
        private System.Windows.Forms.CheckedListBox s1engine_dirs_list;
        private MetroFramework.Controls.MetroLabel status_label;
        private MetroFramework.Controls.MetroButton s1engine_browse_button;
        private MetroFramework.Controls.MetroButton s1engine_button;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton clean_drive_button;
        private System.Windows.Forms.CheckBox drive_clean_selectall;
        private System.Windows.Forms.CheckedListBox drive_cleanup_list;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.CheckBox increase_perf_selectall;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.CheckedListBox increase_perf_list;
        private System.Windows.Forms.CheckBox disable_services_selectall;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.CheckedListBox disable_services_list;
        private System.Windows.Forms.Label status_label_text;
        private System.Windows.Forms.Label compinfo;
        private MetroFramework.Controls.MetroButton tweak_button;
        private MetroFramework.Controls.MetroButton serviceme_button;
        private MetroFramework.Controls.MetroTabPage info_tab;
        private MetroFramework.Controls.MetroLink razercortex_link;
        private MetroFramework.Controls.MetroLink hwmonitor_link;
        private MetroFramework.Controls.MetroLink cpuz_link;
        private MetroFramework.Controls.MetroLink ccleaner_link;
        private MetroFramework.Controls.MetroLink prio_link;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

