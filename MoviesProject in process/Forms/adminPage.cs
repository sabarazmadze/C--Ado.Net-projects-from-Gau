using MoviesProject.Enums;
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
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void directorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void movieReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void createDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsCRUD crud = new DirectorsCRUD(CRUD.Create);
            crud.Show();
            this.Hide();
        }

        private void directorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsCRUD crud = new DirectorsCRUD(CRUD.Read);
            crud.Show();
            this.Hide();
        }

        private void updateDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsCRUD crud = new DirectorsCRUD(CRUD.Update);
            crud.Show();
            this.Hide();
        }
        private void deleteDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsCRUD crud = new DirectorsCRUD(CRUD.Delete);
            crud.Show();
            this.Hide();
        }

        private void movieCategoriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void addNationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NationalitiesCRUD crud = new NationalitiesCRUD(CRUD.Create);
            crud.Show();
            this.Hide();
        }

        private void listNationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NationalitiesCRUD crud = new NationalitiesCRUD(CRUD.Read);
            crud.Show();
            this.Hide();
        }

        private void updateNationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NationalitiesCRUD crud = new NationalitiesCRUD(CRUD.Update);
            crud.Show();
            this.Hide();
        }

        private void deleteNationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NationalitiesCRUD crud = new NationalitiesCRUD(CRUD.Delete);
            crud.Show();
            this.Hide();
        }

        private void addReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieReviewsCRUD crud = new MovieReviewsCRUD(CRUD.Create);
            crud.Show();
            this.Hide();
        }

        private void listReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieReviewsCRUD crud = new MovieReviewsCRUD(CRUD.Read);
            crud.Show();
            this.Hide();
        }

        private void updateReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieReviewsCRUD crud = new MovieReviewsCRUD(CRUD.Update);
            crud.Show();
            this.Hide();
        }

        private void deleteReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieReviewsCRUD crud = new MovieReviewsCRUD(CRUD.Delete);
            crud.Show();
            this.Hide();
        }

        private void addMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieCRUD crud = new MovieCRUD(CRUD.Create);
            crud.Show();
            this.Hide();
        }

        private void listMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieCRUD crud = new MovieCRUD(CRUD.Read);
            crud.Show();
            this.Hide();
        }

        private void updateMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieCRUD crud = new MovieCRUD(CRUD.Update);
            crud.Show();
            this.Hide();
        }

        private void deleteMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieCRUD crud = new MovieCRUD(CRUD.Delete);
            crud.Show();
            this.Hide();
        }

        private void addCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsCRUD crud = new DirectorsCRUD(CRUD.Create);
            crud.Show();
            this.Hide();
        }

        private void listCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsCRUD crud = new DirectorsCRUD(CRUD.Read);
            crud.Show();
            this.Hide();
        }

        private void updateCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsCRUD crud = new DirectorsCRUD(CRUD.Update);
            crud.Show();
            this.Hide();
        }

        private void deleteCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsCRUD crud = new DirectorsCRUD(CRUD.Delete);
            crud.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
