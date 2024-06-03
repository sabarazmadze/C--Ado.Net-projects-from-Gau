using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesProject.Forms
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            adminPage main = new adminPage();
            main.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
