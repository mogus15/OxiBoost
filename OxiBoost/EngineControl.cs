using Microsoft.Win32;
using OxiBoost.Properties;
using System;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace OxiBoost
{
    public partial class EngineControl : UserControl
    {
        public EngineControl()
        {
            InitializeComponent();
        }

        private void EngineControl_Load(object sender, EventArgs e)
        {
            Spec.Text = compInfo();
            engineBPanel.BringToFront();
            s1UIControl1.SendToBack();
            s1UIControl1.Visible = false;
            video1.SendToBack();
            video1.Visible = false;
            partyUI1.SendToBack();
            partyUI1.Visible = false;
            itemSelect.SelectedIndex = 0;
            HelpComboBox.SelectedIndex = 0;
        }

        private void match_Replace(string oldTxt, string newTxt)
        {
            if (optiRich.Text.Contains(oldTxt))
            {
                optiRich.Text = optiRich.Text.Replace(oldTxt, newTxt);
            }
        }

        private int gpuMem()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select AdapterRAM from Win32_VideoController");
            var ram_double = 0.0;
            foreach (ManagementObject mo in searcher.Get())
            {
                var ram = mo.Properties["AdapterRAM"].Value;
                ram_double = Convert.ToDouble(ram) / 1048576;
            }
            return Convert.ToInt32(ram_double);
        }

        private int coreCount()
        {
            var cores = Environment.ProcessorCount;
            return cores;
        }

        private int memCalc()
        {
            StringBuilder sb = new StringBuilder();
            ManagementObjectSearcher searcherz = new ManagementObjectSearcher("root\\CIMV2", "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");

            foreach (ManagementObject queryObj in searcherz.Get())
            {
                double dblMemory;
                if (double.TryParse(Convert.ToString(queryObj["TotalPhysicalMemory"]), out dblMemory))
                {
                    var ram = Convert.ToInt32(dblMemory / (1024 * 1024 * 1024));
                    sb.AppendLine(ram.ToString());
                }
            }

            var mem_string = sb.ToString();
            var mem_num = Convert.ToInt32(mem_string);
            var calc_mem = (mem_num * 1024) / 4;

            return calc_mem;
        }

        private string compInfo()
        {
            StringBuilder sb = new StringBuilder();
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    string cpuName = processor_name.GetValue("ProcessorNameString").ToString();
                    sb.AppendLine("Processor: " + cpuName);
                }
            }


            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                        sb.AppendLine("Graphics Card: " + graphicsCard);
                    }
                }
            }
            ManagementObjectSearcher searcherz = new ManagementObjectSearcher("root\\CIMV2", "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");

            foreach (ManagementObject queryObj in searcherz.Get())
            {
                double dblMemory;
                if (double.TryParse(Convert.ToString(queryObj["TotalPhysicalMemory"]), out dblMemory))
                {
                    var ram = "Installed Memory (Ram): " + Convert.ToInt32(dblMemory / (1024 * 1024 * 1024)) + " GB";
                    sb.AppendLine(ram.ToString());
                }
            }

            return sb.ToString();
        }

        private void oxiFix_Input()
        {
            File.SetAttributes(labPathEngine.Text, FileAttributes.Normal);
            match_Replace("bEnableMouseSmoothing=true", "bEnableMouseSmoothing=false");
            using (StreamWriter writer = new StreamWriter(labPathEngine.Text, false))
            {
                writer.Write(optiRich.Text);
            }
            File.SetAttributes(labPathEngine.Text, FileAttributes.ReadOnly);
            MessageBox.Show("S1Input Optimized!");
        }


        private void oxiFix_Engine()
        {
            var file = currentRich.Text;
            var core_num = coreCount().ToString();
            var gpu_num = gpuMem();
            var gpu_stalecache = (gpu_num / 1024) * 50;
            var gpu_maxcache = (gpu_num / 1024) * 300;
            var gpu_package_calc = (gpu_num / 1024) * 350;
            var gpu_package = gpu_package_calc + 350;
            var gpu_hysteresis = (gpu_num / 1024) * 10;
            var gpu_dropmiplevelslimit = (gpu_num / 1024) * 30;
            var memSize = memCalc().ToString();

            if (string.IsNullOrWhiteSpace(file))
            {
                MessageBox.Show("Configuration Box is empty! Please select a file!");
            }
            else
            {
                if (Spec.Text.Contains("NVIDIA"))
                {
                    File.SetAttributes(labPathEngine.Text, FileAttributes.Normal);

                    match_Replace("bAllowMatureLanguage=FALSE", "bAllowMatureLanguage=TRUE");
                    match_Replace("TinyFontName=EngineFonts.TinyFont", "TinyFontName=EngineFonts.MediumFont");
                    match_Replace("SmallFontName=EngineFonts.SmallFont", "SmallFontName=EngineFonts.MediumFont");
                    match_Replace("SubtitleFontName=EngineFonts.SmallFont", "SubtitleFontName=EngineFonts.MediumFont");
                    match_Replace("UseMinimalNVIDIADriverShaderOptimization=True", "UseMinimalNVIDIADriverShaderOptimization=False");
                    match_Replace("DisableATITextureFilterOptimizationChecks=False", "DisableATITextureFilterOptimizationChecks=True");
                    match_Replace("bSmoothFrameRate=TRUE", "bSmoothFrameRate=FALSE");
                    match_Replace("MaxSmoothedFrameRate=80", "MaxSmoothedFrameRate=120");
                    match_Replace("FLightPrimitiveInteractionInitialBlockSize=512", $"FLightPrimitiveInteractionInitialBlockSize={memSize}");
                    match_Replace("FModShadowPrimitiveInteractionInitialBlockSize=512", $"FModShadowPrimitiveInteractionInitialBlockSize={memSize}");
                    match_Replace("DynamicLights=True", "DynamicLights=False");
                    match_Replace("DynamicShadows=True", "DynamicShadows=False");
                    match_Replace("MotionBlur=True", "MotionBlur=False");
                    match_Replace("DepthOfField=True", "DepthOfField=False");
                    match_Replace("AmbientOcclusion=True", "AmbientOcclusion=False");
                    match_Replace("Bloom=True", "Bloom=False");
                    match_Replace("UseHighQualityBloom=True", "UseHighQualityBloom=False");
                    match_Replace("Distortion=True", "Distortion=False");
                    match_Replace("LensFlares=True", "LensFlares=False");
                    match_Replace("FogVolumes=True", "FogVolumes=False");
                    match_Replace("FogVolumes=True", "FogVolumes=False");
                    match_Replace("AllowD3D11=False", "AllowD3D11=True");
                    match_Replace("MaxStaleCacheSize=10", $"MaxStaleCacheSize={gpu_stalecache.ToString()}");
                    match_Replace("MaxOverallCacheSize=30", $"MaxOverallCacheSize={gpu_maxcache.ToString()}");
                    match_Replace("PackageSizeSoftLimit=300", $"PackageSizeSoftLimit={gpu_package.ToString()}");
                    match_Replace("PoolSize=140", $"PoolSize={gpu_package.ToString()}");
                    match_Replace("HysteresisLimit=30", $"HysteresisLimit={gpu_hysteresis}");
                    match_Replace("DropMipLevelsLimit=24", $"DropMipLevelsLimit={gpu_dropmiplevelslimit.ToString()}");
                    match_Replace("StopIncreasingLimit=18", $"StopIncreasingLimit={gpu_dropmiplevelslimit.ToString()}");
                    match_Replace("StopStreamingLimit=12", $"StopStreamingLimit={gpu_dropmiplevelslimit.ToString()}");
                    if (!optiRich.Text.Contains($"CPUNumLogicalProcessors={core_num}"))
                    {
                        optiRich.AppendText($"CPUNumLogicalProcessors={core_num}");
                    }

                    using (StreamWriter writer = new StreamWriter(labPathEngine.Text, false))
                    {
                        writer.Write(optiRich.Text);
                    }
                    File.SetAttributes(labPathEngine.Text, FileAttributes.ReadOnly);

                    MessageBox.Show("S1Engine.ini Optimization Complete!");

                }


                if (Spec.Text.Contains("Radeon"))
                {
                    File.SetAttributes(labPathEngine.Text, FileAttributes.Normal);

                    match_Replace("bAllowMatureLanguage=FALSE", "bAllowMatureLanguage=TRUE");
                    match_Replace("TinyFontName=EngineFonts.TinyFont", "TinyFontName=EngineFonts.MediumFont");
                    match_Replace("SmallFontName=EngineFonts.SmallFont", "SmallFontName=EngineFonts.MediumFont");
                    match_Replace("SubtitleFontName=EngineFonts.SmallFont", "SubtitleFontName=EngineFonts.MediumFont");
                    match_Replace("UseMinimalNVIDIADriverShaderOptimization=False", "UseMinimalNVIDIADriverShaderOptimization=True");
                    match_Replace("DisableATITextureFilterOptimizationChecks=True", "DisableATITextureFilterOptimizationChecks=False");
                    match_Replace("bSmoothFrameRate=TRUE", "bSmoothFrameRate=FALSE");
                    match_Replace("MaxSmoothedFrameRate=80", "MaxSmoothedFrameRate=120");
                    match_Replace("FLightPrimitiveInteractionInitialBlockSize=512", $"FLightPrimitiveInteractionInitialBlockSize={memSize}");
                    match_Replace("FModShadowPrimitiveInteractionInitialBlockSize=512", $"FModShadowPrimitiveInteractionInitialBlockSize={memSize}");
                    match_Replace("DynamicLights=True", "DynamicLights=False");
                    match_Replace("DynamicShadows=True", "DynamicShadows=False");
                    match_Replace("MotionBlur=True", "MotionBlur=False");
                    match_Replace("DepthOfField=True", "DepthOfField=False");
                    match_Replace("AmbientOcclusion=True", "AmbientOcclusion=False");
                    match_Replace("Bloom=True", "Bloom=False");
                    match_Replace("UseHighQualityBloom=True", "UseHighQualityBloom=False");
                    match_Replace("Distortion=True", "Distortion=False");
                    match_Replace("LensFlares=True", "LensFlares=False");
                    match_Replace("FogVolumes=True", "FogVolumes=False");
                    match_Replace("FogVolumes=True", "FogVolumes=False");
                    match_Replace("AllowD3D11=False", "AllowD3D11=True");
                    match_Replace("MaxStaleCacheSize=10", $"MaxStaleCacheSize={gpu_stalecache.ToString()}");
                    match_Replace("MaxOverallCacheSize=30", $"MaxOverallCacheSize={gpu_maxcache.ToString()}");
                    match_Replace("PackageSizeSoftLimit=300", $"PackageSizeSoftLimit={gpu_package.ToString()}");
                    match_Replace("PoolSize=140", $"PoolSize={gpu_package.ToString()}");
                    match_Replace("HysteresisLimit=30", $"HysteresisLimit={gpu_hysteresis.ToString()}");
                    match_Replace("DropMipLevelsLimit=24", $"DropMipLevelsLimit={gpu_dropmiplevelslimit.ToString()}");
                    match_Replace("StopIncreasingLimit=18", $"StopIncreasingLimit={gpu_dropmiplevelslimit.ToString()}");
                    match_Replace("StopStreamingLimit=12", $"StopStreamingLimit={gpu_dropmiplevelslimit.ToString()}");

                    if (!optiRich.Text.Contains($"CPUNumLogicalProcessors={core_num}"))
                    {
                        optiRich.AppendText($"CPUNumLogicalProcessors={core_num}");
                    }

                    using (StreamWriter writer = new StreamWriter(labPathEngine.Text, false))
                    {
                        writer.Write(optiRich.Text);
                    }
                    File.SetAttributes(labPathEngine.Text, FileAttributes.ReadOnly);
                    MessageBox.Show("S1Engine.ini Optimization Complete!");
                }
            }
        }

        private void itemSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (itemSelect.SelectedItem == null)
            {
                engineBPanel.BringToFront();
            }

            if (itemSelect.SelectedIndex == 0)
            {
                engineBPanel.BringToFront();
                s1UIControl1.SendToBack();
                s1UIControl1.Visible = false;
                video1.SendToBack();
                video1.Visible = false;
                partyUI1.SendToBack();
                partyUI1.Visible = false;
                externalConfig1.SendToBack();
                externalConfig1.Visible = false;
            }
            if (itemSelect.SelectedIndex == 1)
            {
                s1UIControl1.BringToFront();
                s1UIControl1.Visible = true;
            }
            if (itemSelect.SelectedIndex == 2)
            {
                video1.BringToFront();
                video1.Visible = true;
            }
            if (itemSelect.SelectedIndex == 3)
            {
                partyUI1.BringToFront();
                partyUI1.Visible = true;
            }
            if (itemSelect.SelectedIndex == 4)
            {
                externalConfig1.BringToFront();
                externalConfig1.Visible = true;
            }

        }

        private void FileEngine_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                currentRich.Text = File.ReadAllText(opentext.FileName);
                labPathEngine.Text = opentext.InitialDirectory + opentext.FileName;
                labPathEngine.Visible = true;

            }
            optiRich.Text = currentRich.Text;
        }

        private void BoostEngine_Click_1(object sender, EventArgs e)
        {
            GC.Collect();
            var s1e = "S1Engine.ini";
            var s1i = "S1Input.ini";

            if (string.IsNullOrEmpty(labPathEngine.Text))
                return;
            if (labPathEngine.Text.EndsWith(s1e))
                oxiFix_Engine();
            if (labPathEngine.Text.EndsWith(s1i))
                oxiFix_Input();
        }

        private void HelpComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (HelpComboBox.SelectedIndex == 0)
                tutPicBox.Image = Resources.s1B;
            if (HelpComboBox.SelectedIndex == 1)
                tutPicBox.Image = Resources.s1UIB;
            if (HelpComboBox.SelectedIndex == 2)
                tutPicBox.Image = Resources.introB;
            if (HelpComboBox.SelectedIndex == 3)
                tutPicBox.Image = Resources.PartyUI1;
            if (HelpComboBox.SelectedIndex == 4)
                tutPicBox.Image = Resources.ncSettings;
            if (HelpComboBox.SelectedIndex == 5)
                tutPicBox.Image = Resources.prioSettings;
        }
    }
}
