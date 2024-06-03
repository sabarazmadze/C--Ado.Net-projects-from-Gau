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
    public partial class MovieCategoriesCRUD : Form
    {
        public MovieCategoriesCRUD(CRUD _crud)
        {
            InitializeComponent();
            CenterToScreen();
            if (_crud == CRUD.Read)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                CategoryInput.Visible = false;
                labelCategory.Visible = false;
                dataGridView.Visible = true;
            }
            else if (_crud == CRUD.Update)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                CategoryInput.Visible = false;
                labelCategory.Visible = false;
                dataGridView.Visible = false;
            }
            else if (_crud == CRUD.Create)
            {
                IDInput.Visible = false;
                labelID.Visible = false;
                CategoryInput.Visible = true;
                labelCategory.Visible = true;
                dataGridView.Visible = false;
            }
            else if (_crud == CRUD.Delete)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                CategoryInput.Visible = false;
                labelCategory.Visible = false;
                dataGridView.Visible = false;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            adminPage main = new adminPage();
            main.Show();
            this.Hide();
        }

        private void labelEmal_Click(object sender, EventArgs e)
        {

        }
    }
}
