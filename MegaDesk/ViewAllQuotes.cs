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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
