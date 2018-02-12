using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxiBoost
{
    public partial class S1UIControl : UserControl
    {
        public S1UIControl()
        {
            InitializeComponent();
        }

        private readonly byte FLAG_GPU = 2;
        private readonly byte FLAG_DIRECT_BLIT = 4;

        public void gpuBoost()
        {
            try
            {
                // Cool regex stuff by neowutran
                var files = Directory.GetFiles(labPathGPK.Text, "*.gpk", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    Regex.CacheSize = 0;
                    GC.Collect();
                    var data = BitConverter.ToString(File.ReadAllBytes(file)).Replace("-", "");
                    foreach (Match match in Regex.Matches(data, "474658.{30,400}4411(?<key>.).{7}"))
                    {
                        var oldCache = Regex.CacheSize;
                        Regex.CacheSize = 0;
                        GC.Collect();
                        Regex.CacheSize = oldCache;
                        var gpuParameters = Convert.ToByte(match.Groups[1].Value);
                        gpuParameters |= FLAG_DIRECT_BLIT;
                        gpuParameters |= FLAG_GPU;
                        data = data.Remove(match.Groups[1].Index, 1).Insert(match.Groups[1].Index, gpuParameters.ToString("X1"));
                        Regex.CacheSize = 0;
                        GC.Collect();
                    }
                    File.WriteAllBytes(file, data.StringToByteArray());
                    Regex.CacheSize = 0;
                    GC.Collect();
                }
                Application.Restart();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Memory leak
            }
        }
        private void FileGPK_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                labPathGPK.Text = fbd.SelectedPath;
                labPathGPK.Visible = true;
            }
        }

        private void boostGPK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labPathGPK.Text))
                return;

            gpuBoost();
        }
    }
}
