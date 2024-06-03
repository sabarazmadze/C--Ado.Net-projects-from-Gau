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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UniversityProject.Forms
{
    public partial class StudentLogin : Form
    {

        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void studentLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(connsting))
                {

                    sc.Open();
                    using (SqlCommand cmd = sc.CreateCommand())
                    {
                        cmd.CommandText = "EXEC studentLogin @Email, @Password";
                        cmd.Parameters.Add(new SqlParameter("@Email", studentEmailInput.Text));
                        cmd.Parameters.Add(new SqlParameter("@Password", studentPasswordInput.Text));

                        SqlDataReader reader = cmd.ExecuteReader();


                        if (reader.Read())
                        {
                            string Email = reader["Email"].ToString();
                            string StudentName = reader["StudentName"].ToString();
                            string StudentId = reader["StudentID"].ToString();
                            MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StudentPortal StudentPortal = new StudentPortal(Email, StudentName, StudentId);
                            StudentPortal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ოპერაცია წარუმატებლიად!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }
    }
}
