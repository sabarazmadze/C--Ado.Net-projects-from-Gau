using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesProject.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            adminLogin adminlogin = new adminLogin();
            adminlogin.Show();
            this.Hide();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            userLogin userlogin = new userLogin();
            userlogin.Show();
            this.Hide();
        }
    }
}
