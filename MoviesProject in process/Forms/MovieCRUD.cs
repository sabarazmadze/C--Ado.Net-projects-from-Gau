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
    public partial class MovieCRUD : Form
    {
        public MovieCRUD(CRUD _crud)
        {
            InitializeComponent();
            CenterToScreen();
            if (_crud == CRUD.Read)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                MovieCatInput.Visible = false;
                labelMovieCat.Visible = false;
                TitleInput.Visible = false;
                labelTitle.Visible = false;
                DirectorIDInput.Visible = false;
                labelDirectorID.Visible = false;
                DurationInput.Visible = false;
                labelDuration.Visible = false;
                YearInput.Visible = false;
                labelReleaseYear.Visible = false;
                dataGridView.Visible = true;
            }
            else if (_crud == CRUD.Update)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                MovieCatInput.Visible = true;
                labelMovieCat.Visible = true;
                TitleInput.Visible = true;
                labelTitle.Visible = true;
                DirectorIDInput.Visible = true;
                labelDirectorID.Visible = true;
                DurationInput.Visible = true;
                labelDuration.Visible = true;
                YearInput.Visible = true;
                labelReleaseYear.Visible = true;
                dataGridView.Visible = false;
            }
            else if (_crud == CRUD.Create)
            {
                IDInput.Visible = false;
                labelID.Visible = false;
                MovieCatInput.Visible = true;
                labelMovieCat.Visible = true;
                TitleInput.Visible = true;
                labelTitle.Visible = true;
                DirectorIDInput.Visible = true;
                labelDirectorID.Visible = true;
                DurationInput.Visible = true;
                labelDuration.Visible = true;
                YearInput.Visible = true;
                labelReleaseYear.Visible = true;
                dataGridView.Visible = false;
            }
            else if (_crud == CRUD.Delete)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                MovieCatInput.Visible = false;
                labelMovieCat.Visible = false;
                TitleInput.Visible = false;
                labelTitle.Visible = false;
                DirectorIDInput.Visible = false;
                labelDirectorID.Visible = false;
                DurationInput.Visible = false;
                labelDuration.Visible = false;
                YearInput.Visible = false;
                labelReleaseYear.Visible = false;
                dataGridView.Visible = false;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            adminPage main = new adminPage();
            main.Show();
            this.Hide();
        }

        private void MovieCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
