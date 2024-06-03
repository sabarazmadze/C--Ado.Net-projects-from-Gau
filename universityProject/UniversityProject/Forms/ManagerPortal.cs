using System;
using System.Windows.Forms;
using UniversityProject.Enums;
using UniversityProject.Forms;

namespace UniversityProject
{
    public partial class ManagerPortal : Form
    {
        public ManagerPortal()
        {
            InitializeComponent();
        }

        private void ManagerPortal_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void addLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(Modes.Create);
            CRUD.Show();
        }

        private void deleteLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CRUD CRUD = new CRUD(Modes.Delete);
            CRUD.Show();
        }

        private void updateLecturorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CRUD CRUD = new CRUD(Modes.Update);
            CRUD.Show();
        }

        private void viewAllLecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CRUD CRUD = new CRUD();
            CRUD.Show();
        }

        private void DeleteStundet_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(Modes.Delete, Who.Student);
            CRUD.Show();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(Modes.Create, Who.Student);
            CRUD.Show();
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(Modes.Update, Who.Student);
            CRUD.Show();
        }

        private void ViewAllStudents_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(Modes.View, Who.Student);
            CRUD.Show();
        }
    }
}
