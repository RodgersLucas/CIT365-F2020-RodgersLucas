using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Rodgers
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }


        private void addNewQuoteButton_Click(object sender, EventArgs e) 
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            this.Hide();
        }

        private void viewQuoteButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            this.Hide();
        }

        private void searchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuote = new SearchQuotes();
            searchQuote.Tag = this;
            searchQuote.Show(this);
            this.Hide();
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }

}
