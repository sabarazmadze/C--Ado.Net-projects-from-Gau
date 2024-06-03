using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityProject
{
    public partial class LecturerPortal : Form
    {

        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public int _Id;
        public LecturerPortal(int Id)
        {
            InitializeComponent();
            _Id = Id;
        }

        private void LecturerPortal_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable ds = new DataTable();

                using (SqlConnection connection = new SqlConnection(connsting))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        // -------------------view all stundets by lecturer
                        //command.CommandText = "EXEC -------------- @ID";
                        command.CommandText = "EXEC viewAllSudentsByLecturer @ID";
                        command.Parameters.Add(new SqlParameter("@ID", _Id));
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ds.Load(reader);

                        }
                    }
                }
                dataGridView.DataSource = ds;
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

        private void AddGrade_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connsting))
            {
                connection.Open();


                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "EXEC addGrade @StudentId, @LecturerID, @Grade";
                    command.Parameters.Add(new SqlParameter("@StudentId", numericUpDownID.Value));
                    command.Parameters.Add(new SqlParameter("@LecturerID", _Id));
                    command.Parameters.Add(new SqlParameter("@Grade", numericUpDownGrade.Value));

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
