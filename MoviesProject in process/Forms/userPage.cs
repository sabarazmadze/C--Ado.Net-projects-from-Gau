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
    public partial class userPage : Form
    {
        public userPage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void createDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void directorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userPage_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
