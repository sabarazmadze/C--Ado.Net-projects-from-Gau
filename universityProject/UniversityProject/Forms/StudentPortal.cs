using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityProject
{
    public partial class StudentPortal : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public string _StudentName;
        public string _StudentEmail;
        public string _StudentID;
        public StudentPortal(string studentName, string studentEmail, string studentId)
        {
            InitializeComponent();
            _StudentName = studentName;
            _StudentEmail = studentEmail;
            _StudentID = studentId;

        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            try
            {
                AvgGrade.Text = "";
                StudentName.Text = _StudentName;
                Email.Text = _StudentEmail;
                DataTable ds = new DataTable();

                using (SqlConnection connection = new SqlConnection(connsting))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "EXEC showGradesByDate @ID";
                        command.Parameters.Add(new SqlParameter("@ID", _StudentID));
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ds.Load(reader);

                        }
                    }
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "EXEC studentAverageGrade @ID";
                        command.Parameters.Add(new SqlParameter("@ID", _StudentID));

                        SqlDataReader dr = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        while (!dr.IsClosed)
                            dt.Load(dr);

                        AvgGrade.Text = "average Grade :" + dt.Rows[0]["Student Average Grade"].ToString();

                    }
                }
                dataGridView1.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("ოპერაცია წარუმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void StudentName_Click(object sender, EventArgs e)
        {

        }
    }
}
