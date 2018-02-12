using System;
using System.Drawing;
using System.Windows.Forms;

namespace OxiBoost
{
    public partial class OxiBoostForm : Form
    {
        public OxiBoostForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void OxiBoostForm_Load(object sender, EventArgs e)
        {
            animatePanel.Height = HomeB.Height;
            animatePanel.Top = HomeB.Top;
            logoMe.Image = Properties.Resources.iconpng;
            homeControl1.BringToFront();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            animatePanel.Height = HomeB.Height;
            animatePanel.Top = HomeB.Top;

            
            homeControl1.BringToFront();
        }

        private void engineB_Click(object sender, EventArgs e)
        {
            animatePanel.Height = engineB.Height;
            animatePanel.Top = engineB.Top;

            engineControl1.BringToFront();
        }
    }
}
