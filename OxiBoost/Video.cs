using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OxiBoost
{
    public partial class Video : UserControl
    {
        public Video()
        {
            InitializeComponent();
        }

        private void FileVideo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                labPathFile.Text = fbd.SelectedPath;
                labPathFile.Visible = true;
            }
        }

        private void BoostFile_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(labPathFile.Text))
                return;

            try
            {
                // LOOOL tbh I was tired idk what I wrote

                var path1 = $@"{labPathFile.Text}\" + "intro_atari.bik";
                var path2 = $@"{labPathFile.Text}\" + "intro_bhs.bik";
                var path3 = $@"{labPathFile.Text}\" + "intro_eme.bik";
                var path4 = $@"{labPathFile.Text}\" + "intro_fog.bik";
                var path5 = $@"{labPathFile.Text}\" + "intro_ubi.bik";

                if (File.Exists(path1))
                {
                    File.Delete(path1);
                }
                if (File.Exists(path2))
                {
                    File.Delete(path2);
                }
                if (File.Exists(path3))
                {
                    File.Delete(path3);
                }
                if (File.Exists(path4))
                {
                    File.Delete(path4);
                }
                if (File.Exists(path5))
                {
                    File.Delete(path5);
                }

                videoRich.Text = "Successfully deleted intro files!";

                string[] dir = Directory.GetFiles(labPathFile.Text);
                string richTextFileList = dir.Select(file => Path.GetFileName(file))
                               .Aggregate((x, y) => x + Environment.NewLine + y);
                FileNames.Text = richTextFileList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
