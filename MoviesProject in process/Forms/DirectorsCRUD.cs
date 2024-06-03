using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesProject.Enums;

namespace MoviesProject.Forms
{
    public partial class DirectorsCRUD : Form
    {
        public DirectorsCRUD(CRUD _crud)
        {
            InitializeComponent();
            CenterToScreen();
            if(_crud == CRUD.Read)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                FirstNameInput.Visible = false;
                labelFirstName.Visible = false;
                LastNameInput.Visible = false;
                labelLastName.Visible = false;
                NationalityDropdown.Visible = false;
                labelNationality.Visible = false;
                dataGridView.Visible = true;
            }
            else if(_crud == CRUD.Update)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                FirstNameInput.Visible = true;
                labelFirstName.Visible = true;
                LastNameInput.Visible = true;
                labelLastName.Visible = true;
                NationalityDropdown.Visible = true;
                labelNationality.Visible = true;
                dataGridView.Visible = false;
            }
            else if(_crud == CRUD.Create)
            {
                IDInput.Visible = false;
                labelID.Visible = false;
                FirstNameInput.Visible = true;
                labelFirstName.Visible = true;
                LastNameInput.Visible = true;
                labelLastName.Visible = true;
                NationalityDropdown.Visible = true;
                labelNationality.Visible = true;
                dataGridView.Visible = false;
            }
            else if(_crud == CRUD.Delete)
            {
                IDInput.Visible = true;
                labelID.Visible = true;
                FirstNameInput.Visible = false;
                labelFirstName.Visible = false;
                LastNameInput.Visible = false;
                labelLastName.Visible = false;
                NationalityDropdown.Visible = false;
                labelNationality.Visible = false;
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

        private void DirectorsCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
