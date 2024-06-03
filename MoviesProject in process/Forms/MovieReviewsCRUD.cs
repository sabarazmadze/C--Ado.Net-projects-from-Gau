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
    public partial class MovieReviewsCRUD : Form
    {
        public MovieReviewsCRUD(CRUD _crud)
        {
            InitializeComponent();
            CenterToScreen();
            if (_crud == CRUD.Read)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                MovieIDInput.Visible = false;
                labelMovieID.Visible = false;
                ScoreInput.Visible = false;
                labelScore.Visible = false;
                reviewDateSelector.Visible = false;
                labelReviewDate.Visible = false;
                CommentInput.Visible = false;
                labelComment.Visible = false;
                dataGridView.Visible = true;
            }
            else if (_crud == CRUD.Update)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                MovieIDInput.Visible = true;
                labelMovieID.Visible = true;
                ScoreInput.Visible = true;
                labelScore.Visible = true;
                reviewDateSelector.Visible = true;
                labelReviewDate.Visible = true;
                CommentInput.Visible = true;
                labelComment.Visible = true;
                dataGridView.Visible = false;
            }
            else if (_crud == CRUD.Create)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                MovieIDInput.Visible = true;
                labelMovieID.Visible = true;
                ScoreInput.Visible = true;
                labelScore.Visible = true;
                reviewDateSelector.Visible = true;
                labelReviewDate.Visible = true;
                CommentInput.Visible = true;
                labelComment.Visible = true;
                dataGridView.Visible = false;
            }
            else if (_crud == CRUD.Delete)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                MovieIDInput.Visible = false;
                labelMovieID.Visible = false;
                ScoreInput.Visible = false;
                labelScore.Visible = false;
                reviewDateSelector.Visible = false;
                labelReviewDate.Visible = false;
                CommentInput.Visible = false;
                labelComment.Visible = false;
                dataGridView.Visible = false;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            adminPage main = new adminPage();
            main.Show();
            this.Hide();
        }
    }
}
