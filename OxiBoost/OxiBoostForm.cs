using Oxiboost.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oxiboost
{
    public partial class OxiboostForm : Form
    {

        public string s1engine_config = "";
        public string s1input_config = "";

        public OxiboostForm()
        {
            InitializeComponent();
        }

        private async void start_findme()
        {
            status_label_text.Text = "Searching drives for game files this may take a few minutes...";
            var result = await Task.Run(() => findme());
            status_label_text.Text = "Game files found! Please select correct S1SystemSettings.ini then click on the Boost button.";
            foreach (var d in result)
            {
                s1engine_dirs_list.Items.Add(d);
            }
        }

        private List<string> findme()
        {
            var finder = new Finder();
            var dir_list = new List<string>();

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    var paths = finder.Find(d.Name);
                    foreach (var i in paths)
                    {
                        if (i.Contains("TERA\\Client\\S1Game\\Config\\S1SystemSettings.ini"))
                            dir_list.Add(i);
                    }
                }
            }

            return dir_list;
        }

        private void browseme()
        {
            var s1text = "";
            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                s1text = File.ReadAllText(opentext.FileName);
                status_label_text.Text = opentext.InitialDirectory + opentext.FileName;
            }

            s1engine_config = s1text;
            s1input_config = s1text;
        }

        private void match_replace(string oldTxt, string newTxt)
        {
            if (s1engine_config.Contains(oldTxt))
            {
                s1engine_config = s1engine_config.Replace(oldTxt, newTxt);
            }
        }

        private void oxiboost_s1engine()
        {
            var specs = new Specs();
            var ci = compinfo.Text;
            var path = status_label_text.Text;
            var core_num = specs.coreCount().ToString();
            var gpu_num = specs.gpuMem();
            var gpu_stalecache = (gpu_num / 1024) * 50;
            var gpu_maxcache = (gpu_num / 1024) * 300;
            var gpu_package_calc = (gpu_num / 1024) * 350;
            var gpu_package = gpu_package_calc + 350;
            var gpu_hysteresis = (gpu_num / 1024) * 10;
            var gpu_dropmiplevelslimit = (gpu_num / 1024) * 30;
            var memSize = specs.memCalc().ToString();


            if (ci.Contains("NVIDIA"))
            {
                File.SetAttributes(path, FileAttributes.Normal);

                match_replace("bAllowMatureLanguage=FALSE", "bAllowMatureLanguage=TRUE");
                match_replace("TinyFontName=EngineFonts.TinyFont", "TinyFontName=EngineFonts.MediumFont");
                match_replace("SmallFontName=EngineFonts.SmallFont", "SmallFontName=EngineFonts.MediumFont");
                match_replace("SubtitleFontName=EngineFonts.SmallFont", "SubtitleFontName=EngineFonts.MediumFont");
                match_replace("UseMinimalNVIDIADriverShaderOptimization=True", "UseMinimalNVIDIADriverShaderOptimization=False");
                match_replace("DisableATITextureFilterOptimizationChecks=False", "DisableATITextureFilterOptimizationChecks=True");
                match_replace("bSmoothFrameRate=TRUE", "bSmoothFrameRate=FALSE");
                match_replace("MaxSmoothedFrameRate=80", "MaxSmoothedFrameRate=120");
                match_replace("FLightPrimitiveInteractionInitialBlockSize=512", $"FLightPrimitiveInteractionInitialBlockSize={memSize}");
                match_replace("FModShadowPrimitiveInteractionInitialBlockSize=512", $"FModShadowPrimitiveInteractionInitialBlockSize={memSize}");
                match_replace("DynamicLights=True", "DynamicLights=False");
                match_replace("DynamicShadows=True", "DynamicShadows=False");
                match_replace("MotionBlur=True", "MotionBlur=False");
                match_replace("DepthOfField=True", "DepthOfField=False");
                match_replace("AmbientOcclusion=True", "AmbientOcclusion=False");
                match_replace("Bloom=True", "Bloom=False");
                match_replace("UseHighQualityBloom=True", "UseHighQualityBloom=False");
                match_replace("Distortion=True", "Distortion=False");
                match_replace("LensFlares=True", "LensFlares=False");
                match_replace("FogVolumes=True", "FogVolumes=False");
                match_replace("FogVolumes=True", "FogVolumes=False");
                match_replace("AllowD3D11=False", "AllowD3D11=True");
                match_replace("MaxStaleCacheSize=10", $"MaxStaleCacheSize={gpu_stalecache.ToString()}");
                match_replace("MaxOverallCacheSize=30", $"MaxOverallCacheSize={gpu_maxcache.ToString()}");
                match_replace("PackageSizeSoftLimit=300", $"PackageSizeSoftLimit={gpu_package.ToString()}");
                match_replace("PoolSize=140", $"PoolSize={gpu_package.ToString()}");
                match_replace("HysteresisLimit=30", $"HysteresisLimit={gpu_hysteresis}");
                match_replace("DropMipLevelsLimit=24", $"DropMipLevelsLimit={gpu_dropmiplevelslimit.ToString()}");
                match_replace("StopIncreasingLimit=18", $"StopIncreasingLimit={gpu_dropmiplevelslimit.ToString()}");
                match_replace("StopStreamingLimit=12", $"StopStreamingLimit={gpu_dropmiplevelslimit.ToString()}");

                
                if (!s1engine_config.Contains($"CPUNumLogicalProcessors={core_num}"))
                {
                    s1engine_config = s1engine_config + $"\nCPUNumLogicalProcessors={core_num}";
                }
                

                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.Write(s1engine_config);
                }
                File.SetAttributes(path, FileAttributes.ReadOnly);

                MessageBox.Show("S1SystemSettings.ini Optimization Complete! Restart game to view changes.");

            }


            if (ci.Contains("Radeon"))
            {
                File.SetAttributes(path, FileAttributes.Normal);

                match_replace("bAllowMatureLanguage=FALSE", "bAllowMatureLanguage=TRUE");
                match_replace("TinyFontName=EngineFonts.TinyFont", "TinyFontName=EngineFonts.MediumFont");
                match_replace("SmallFontName=EngineFonts.SmallFont", "SmallFontName=EngineFonts.MediumFont");
                match_replace("SubtitleFontName=EngineFonts.SmallFont", "SubtitleFontName=EngineFonts.MediumFont");
                match_replace("UseMinimalNVIDIADriverShaderOptimization=False", "UseMinimalNVIDIADriverShaderOptimization=True");
                match_replace("DisableATITextureFilterOptimizationChecks=True", "DisableATITextureFilterOptimizationChecks=False");
                match_replace("bSmoothFrameRate=TRUE", "bSmoothFrameRate=FALSE");
                match_replace("MaxSmoothedFrameRate=80", "MaxSmoothedFrameRate=120");
                match_replace("FLightPrimitiveInteractionInitialBlockSize=512", $"FLightPrimitiveInteractionInitialBlockSize={memSize}");
                match_replace("FModShadowPrimitiveInteractionInitialBlockSize=512", $"FModShadowPrimitiveInteractionInitialBlockSize={memSize}");
                match_replace("DynamicLights=True", "DynamicLights=False");
                match_replace("DynamicShadows=True", "DynamicShadows=False");
                match_replace("MotionBlur=True", "MotionBlur=False");
                match_replace("DepthOfField=True", "DepthOfField=False");
                match_replace("AmbientOcclusion=True", "AmbientOcclusion=False");
                match_replace("Bloom=True", "Bloom=False");
                match_replace("UseHighQualityBloom=True", "UseHighQualityBloom=False");
                match_replace("Distortion=True", "Distortion=False");
                match_replace("LensFlares=True", "LensFlares=False");
                match_replace("FogVolumes=True", "FogVolumes=False");
                match_replace("FogVolumes=True", "FogVolumes=False");
                match_replace("AllowD3D11=False", "AllowD3D11=True");
                match_replace("MaxStaleCacheSize=10", $"MaxStaleCacheSize={gpu_stalecache.ToString()}");
                match_replace("MaxOverallCacheSize=30", $"MaxOverallCacheSize={gpu_maxcache.ToString()}");
                match_replace("PackageSizeSoftLimit=300", $"PackageSizeSoftLimit={gpu_package.ToString()}");
                match_replace("PoolSize=140", $"PoolSize={gpu_package.ToString()}");
                match_replace("HysteresisLimit=30", $"HysteresisLimit={gpu_hysteresis.ToString()}");
                match_replace("DropMipLevelsLimit=24", $"DropMipLevelsLimit={gpu_dropmiplevelslimit.ToString()}");
                match_replace("StopIncreasingLimit=18", $"StopIncreasingLimit={gpu_dropmiplevelslimit.ToString()}");
                match_replace("StopStreamingLimit=12", $"StopStreamingLimit={gpu_dropmiplevelslimit.ToString()}");

                
                if (!s1engine_config.Contains($"CPUNumLogicalProcessors={core_num}"))
                {
                    s1engine_config = s1engine_config + $"\nCPUNumLogicalProcessors={core_num}";
                }
                

                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.Write(s1engine_config);
                }
                File.SetAttributes(path, FileAttributes.ReadOnly);
                MessageBox.Show("S1SystemSettings.ini Optimization Complete! Restart game to view changes.");
            }
        }

        private void oxiboost_s1input()
        {
            File.SetAttributes(status_label_text.Text, FileAttributes.Normal);
            match_replace("bEnableMouseSmoothing=true", "bEnableMouseSmoothing=false");
            using (StreamWriter writer = new StreamWriter(status_label_text.Text, false))
            {
                writer.Write(s1input_config);
            }
            File.SetAttributes(status_label_text.Text, FileAttributes.ReadOnly);
            MessageBox.Show("S1Input Optimized! Restart game to view changes.");
        }

        private void s1engine_button_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Searching for game files takes time. If you have more than 6 drives in your system it's advised to browse for the game files instead. Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
                start_findme();
            else
            {
                return;
            }
        }

        private void s1engine_browse_button_Click(object sender, EventArgs e)
        {
            browseme();
        }

        private void s1engine_dirs_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            status_label_text.Text = s1engine_dirs_list.SelectedItem.ToString();
        }

        private void boost_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(status_label_text.Text))
                return;
            if (status_label_text.Text.EndsWith("S1SystemSettings.ini"))
                oxiboost_s1engine();
            if (status_label_text.Text.EndsWith("S1Input.ini"))
                oxiboost_s1input();
        }

        private void OxiboostForm_Load(object sender, EventArgs e)
        {
            var specs = new Specs();
            compinfo.Text = specs.compInfo();
        }

        private void clean_drive_button_Click(object sender, EventArgs e)
        {
            var clnr = new Cleaner();

            if (drive_clean_selectall.Checked == true)
            {
                clnr.CleanTemporaries();
                clnr.CleanLogs();
                clnr.CleanPrefetch();
                clnr.CleanMiniDumps();
                clnr.CleanErrorReports();
                clnr.EmptyRecycleBin();
                clnr.CleanMediaPlayersCache();
                clnr.CleanUTorrent();

                MessageBox.Show("All cleared!");
                for (int i = 0; i < drive_cleanup_list.Items.Count; i++)
                {
                    drive_cleanup_list.SetItemChecked(i, false);
                }
                drive_clean_selectall.Checked = false;
            }
            else
            {
                if (drive_cleanup_list.GetItemCheckState(0) == CheckState.Checked)
                {
                    clnr.CleanTemporaries();
                    drive_cleanup_list.SetItemChecked(0, false);
                    MessageBox.Show("Temp files cleared!");
                }
                else if (drive_cleanup_list.GetItemCheckState(1) == CheckState.Checked)
                {
                    clnr.CleanLogs();
                    drive_cleanup_list.SetItemChecked(1, false);
                    MessageBox.Show("Logs cleared!");
                }
                else if(drive_cleanup_list.GetItemCheckState(2) == CheckState.Checked)
                {
                    clnr.CleanPrefetch();
                    drive_cleanup_list.SetItemChecked(2, false);
                    MessageBox.Show("Prefetch cache cleared!");
                }
                else if(drive_cleanup_list.GetItemCheckState(3) == CheckState.Checked)
                {
                    clnr.CleanMiniDumps();
                    drive_cleanup_list.SetItemChecked(3, false);
                    MessageBox.Show("Minidumps cleared!");
                }
                else if(drive_cleanup_list.GetItemCheckState(4) == CheckState.Checked)
                {
                    clnr.CleanErrorReports();
                    drive_cleanup_list.SetItemChecked(4, false);
                    MessageBox.Show("Error reports cleared!");
                }
                else if(drive_cleanup_list.GetItemCheckState(5) == CheckState.Checked)
                {
                    clnr.EmptyRecycleBin();
                    drive_cleanup_list.SetItemChecked(5, false);
                    MessageBox.Show("Recycle bin cleared!");
                }
                else if(drive_cleanup_list.GetItemCheckState(6) == CheckState.Checked)
                {
                    clnr.CleanMediaPlayersCache();
                    drive_cleanup_list.SetItemChecked(6, false);
                    MessageBox.Show("Media player cache cleared!");
                }
                else if(drive_cleanup_list.GetItemCheckState(7) == CheckState.Checked)
                {
                    clnr.CleanUTorrent();
                    drive_cleanup_list.SetItemChecked(7, false);
                    MessageBox.Show("Utorrent cache cleared!");
                }
                else
                {
                    return;
                }
            }
        }

        private void drive_clean_selectall_CheckedChanged(object sender, EventArgs e)
        {

            if (drive_clean_selectall.Checked)
            {
                for (int i = 0; i < drive_cleanup_list.Items.Count; i++)
                {
                    drive_cleanup_list.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < drive_cleanup_list.Items.Count; i++)
                {
                    drive_cleanup_list.SetItemChecked(i, false);
                }
            }
        }

        private void disable_services_selectall_CheckedChanged(object sender, EventArgs e)
        {
            if (disable_services_selectall.Checked)
            {
                for (int i = 0; i < disable_services_list.Items.Count; i++)
                {
                    disable_services_list.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < disable_services_list.Items.Count; i++)
                {
                    disable_services_list.SetItemChecked(i, false);
                }
            }
        }

        private void serviceme_button_Click(object sender, EventArgs e)
        {
            var svme = new Optimize();

            if (disable_services_selectall.Checked == true)
            {
                svme.DisableStartMenuAds();
                svme.DisableTelemetryServices();
                svme.DisableSilentAppInstall();
                svme.DisableCortana();
                svme.DisableSensorServices();
                svme.DisableWindowsInk();
                svme.DisableGameBar();

                MessageBox.Show("All services disabled");
                for (int i = 0; i < disable_services_list.Items.Count; i++)
                {
                    disable_services_list.SetItemChecked(i, false);
                }
                disable_services_selectall.Checked = false;
            }
            else
            {
                if (disable_services_list.GetItemCheckState(0) == CheckState.Checked)
                {
                    svme.DisableStartMenuAds();
                    disable_services_list.SetItemChecked(0, false);
                    MessageBox.Show("Start menu ads disabled");
                }
                else if (disable_services_list.GetItemCheckState(1) == CheckState.Checked)
                {
                    svme.DisableTelemetryServices();
                    disable_services_list.SetItemChecked(1, false);
                    MessageBox.Show("Disable telemetry services disabled");
                }
                else if (disable_services_list.GetItemCheckState(2) == CheckState.Checked)
                {
                    svme.DisableSilentAppInstall();
                    disable_services_list.SetItemChecked(2, false);
                    MessageBox.Show("Silent app install disabled");
                }
                else if (disable_services_list.GetItemCheckState(3) == CheckState.Checked)
                {
                    svme.DisableCortana();
                    disable_services_list.SetItemChecked(3, false);
                    MessageBox.Show("Cortona disabled");
                }
                else if (disable_services_list.GetItemCheckState(4) == CheckState.Checked)
                {
                    svme.DisableSensorServices();
                    disable_services_list.SetItemChecked(4, false);
                    MessageBox.Show("Sensor services disabled");
                }
                else if (disable_services_list.GetItemCheckState(5) == CheckState.Checked)
                {
                    svme.DisableWindowsInk();
                    disable_services_list.SetItemChecked(5, false);
                    MessageBox.Show("Windows ink disabled");
                }
                else if (disable_services_list.GetItemCheckState(6) == CheckState.Checked)
                {
                    svme.DisableGameBar();
                    disable_services_list.SetItemChecked(6, false);
                    MessageBox.Show("Gamebar disabled");
                }
                else
                {
                    return;
                }
            }
        }

        private void tweak_button_Click(object sender, EventArgs e)
        {
            var svme = new Optimize();

            if (increase_perf_selectall.Checked == true)
            {
                svme.EnablePerformanceTweaks();
                svme.DisableNetworkThrottling();
                svme.DisableMediaPlayerSharing();
                svme.DisableSkypeAds();
                svme.DisableErrorReporting();
                svme.DisableHomeGroup();
                svme.DisableSuperfetch();

                MessageBox.Show("All performance tweaks applied!");
                for (int i = 0; i < increase_perf_list.Items.Count; i++)
                {
                    increase_perf_list.SetItemChecked(i, false);
                }
                increase_perf_selectall.Checked = false;
            }
            else
            {
                if (increase_perf_list.GetItemCheckState(0) == CheckState.Checked)
                {
                    svme.EnablePerformanceTweaks();
                    increase_perf_list.SetItemChecked(0, false);
                    MessageBox.Show("Performance tweaks applied");
                }
                else if (increase_perf_list.GetItemCheckState(1) == CheckState.Checked)
                {
                    svme.DisableNetworkThrottling();
                    increase_perf_list.SetItemChecked(1, false);
                    MessageBox.Show("Network throttling disabled");
                }
                else if (increase_perf_list.GetItemCheckState(2) == CheckState.Checked)
                {
                    svme.DisableMediaPlayerSharing();
                    increase_perf_list.SetItemChecked(2, false);
                    MessageBox.Show("Disable mediaPlayer sharing disabled");
                }
                else if (increase_perf_list.GetItemCheckState(3) == CheckState.Checked)
                {
                    svme.DisableSkypeAds();
                    increase_perf_list.SetItemChecked(3, false);
                    MessageBox.Show("Skye ads blocked");
                }
                else if (increase_perf_list.GetItemCheckState(4) == CheckState.Checked)
                {
                    svme.DisableErrorReporting();
                    increase_perf_list.SetItemChecked(4, false);
                    MessageBox.Show("Error reporting disabled");
                }
                else if (increase_perf_list.GetItemCheckState(5) == CheckState.Checked)
                {
                    svme.DisableHomeGroup();
                    increase_perf_list.SetItemChecked(5, false);
                    MessageBox.Show("Home group disabled");
                }
                else if (increase_perf_list.GetItemCheckState(6) == CheckState.Checked)
                {
                    svme.DisableSuperfetch();
                    increase_perf_list.SetItemChecked(6, false);
                    MessageBox.Show("Superfetch disabled");
                }
                else
                {
                    return;
                }
            }
        }

        private void increase_perf_selectall_CheckedChanged(object sender, EventArgs e)
        {
            if (increase_perf_selectall.Checked)
            {
                for (int i = 0; i < increase_perf_list.Items.Count; i++)
                {
                    increase_perf_list.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < increase_perf_list.Items.Count; i++)
                {
                    increase_perf_list.SetItemChecked(i, false);
                }
            }
        }

        private void prio_link_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.prnwatch.com/prio");
        }

        private void ccleaner_link_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ccleaner.com");
        }

        private void hwmonitor_link_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.cpuid.com/softwares/hwmonitor.html");
        }

        private void cpuz_link_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.cpuid.com/softwares/cpu-z.html");
        }

        private void razercortex_link_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.razer.com/cortex");
        }
    }
}
