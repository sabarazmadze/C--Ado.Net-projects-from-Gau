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

namespace UniversityProject.Forms
{
    public partial class LecturerLogin : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public LecturerLogin()
        {
            InitializeComponent();
        }

        private void LecturerLogin_Load(object sender, EventArgs e)
        {

        }

        private void lecturerLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(connsting))
                {

                    sc.Open();
                    using (SqlCommand cmd = sc.CreateCommand())
                    {
                        cmd.CommandText = "EXEC lecturerLogin @Email, @Password";
                        cmd.Parameters.Add(new SqlParameter("@Email", lecturerEmailInput.Text));
                        cmd.Parameters.Add(new SqlParameter("@Password", lecturerPasswordInput.Text));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string Id = reader["LecturerID"].ToString();
                            MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LecturerPortal LecturerPortal = new LecturerPortal(Convert.ToInt16(Id));
                            LecturerPortal.Show();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }
    }
}
