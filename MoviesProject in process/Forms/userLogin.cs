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
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            userPage userpage = new userPage();
            userpage.Show();
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
