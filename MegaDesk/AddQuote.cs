using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close addquote form
            this.Close();
        }

        private void btnSaveQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk();
            desk.Width = numWidth.Value;

            var deskQuote = new DeskQuote();
            //set customername equal to use input
            deskQuote.CustomerName = txtCustomerName.Text;

            deskQuote.QuotePrice = deskQuote.GetQuotePrice();

        }
    }
}
