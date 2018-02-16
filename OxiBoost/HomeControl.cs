using System;
using System.Windows.Forms;

namespace OxiBoost
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private string GetRandomQuote()
        {
            richQuotes.SelectionAlignment = HorizontalAlignment.Center;
            string[] quotes = { "Welcome Welcome Bby", "Oh! Why hello there!", "OxiBoost OxiBoost!", "Terable fps no more!", "(. u .)", "Have a great day!", "*Dances*", "github.com/purizer/OxiBoost", "What next?", "Real Billy Mays please notice...", "FPS FPS!"};
            Random random = new Random();
            int i = random.Next(0, quotes.Length);
            return quotes[i];
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            richQuotes.Text = GetRandomQuote();
        }
    }
}
