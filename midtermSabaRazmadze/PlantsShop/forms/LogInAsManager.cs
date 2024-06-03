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

namespace PlantsShop.forms
{
    public partial class LogInAsManager : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public LogInAsManager()
        {
            InitializeComponent();
        }

        private void LogInAsManager_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LogInOptions LogInOptions = new LogInOptions();
            LogInOptions.Show();
            this.Hide();
        }

        private void ManagerLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connsting))
                {
                    connection.Open();


                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "EXEC adminLogin @Email, @Password";
                        command.Parameters.Add(new SqlParameter("@Email", ManagerEmailInput.Text));
                        command.Parameters.Add(new SqlParameter("@Password", ManagerPasswordInput.Text));

                        SqlDataReader reader = command.ExecuteReader();


                        if (reader.Read())
                        {
                            MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagerPage ManagerPage = new ManagerPage();
                            ManagerPage.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("შეცდომაა!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
