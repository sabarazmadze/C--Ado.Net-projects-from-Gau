using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityProject.Forms;

namespace UniversityProject
{

    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void lecturerButton_Click(object sender, EventArgs e)
        {
            LecturerLogin LecturerLogin=new LecturerLogin();
            LecturerLogin.Show();
            this.Hide();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            StudentLogin StudentLogin=new StudentLogin();
            StudentLogin.Show();
            this.Hide();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            ManagerLogin ManagerLogin = new ManagerLogin();
            ManagerLogin.Show();
            this.Hide();
        }
    }
}
