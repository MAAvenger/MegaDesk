﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            //build new addquote form object
            var frmAddQuote = new AddQuote();
            // add tag to get back to main menu
            frmAddQuote.Tag = this;
            frmAddQuote.Show();
            //hide menu
            this.Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            var frmViewAllQuotes = new ViewAllQuotes();
            frmViewAllQuotes.Tag = this;
            frmViewAllQuotes.Show();
            this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var frmSearchQuotes = new SearchQuotes();
            frmSearchQuotes.Tag = this;
            frmSearchQuotes.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
