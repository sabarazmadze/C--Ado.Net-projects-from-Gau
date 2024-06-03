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
    public partial class ManagerLogin : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void managerLoginButton_Click(object sender, EventArgs e)
        {



            try
            {
                using (SqlConnection sc = new SqlConnection(connsting))
                {

                    sc.Open();
                    using (SqlCommand cmd = sc.CreateCommand())
                    {
                        cmd.CommandText = "EXEC managerLogin @Email, @Password";
                        cmd.Parameters.Add(new SqlParameter("@Email", managerEmailInput.Text));
                        cmd.Parameters.Add(new SqlParameter("@Password", managerPasswordInput.Text));

                        SqlDataReader reader = cmd.ExecuteReader();


                        if (reader.Read())
                        {
                            MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagerPortal ManagerPortal = new ManagerPortal();
                            ManagerPortal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ოპერაცია წარუმატებლია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
