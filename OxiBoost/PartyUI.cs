using System.Windows.Forms;
using System.Diagnostics;

namespace OxiBoost
{
    public partial class PartyUI : UserControl
    {
        public PartyUI()
        {
            InitializeComponent();
        }

        private void partyUILINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://yadi.sk/d/T2WaA2dg3HPEA3");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://yadi.sk/d/XRofm1v53JkLGV");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://yadi.sk/d/oyTByfd43GG6aM");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://yadi.sk/d/WLtFzjUf3JgAE4");
        }
    }
}
