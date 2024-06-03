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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PlantsShop.forms
{
    public partial class LogInAsUser : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public LogInAsUser()
        {
            InitializeComponent();
        }

        private void LogInAsUser_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LogInOptions LogInOptions = new LogInOptions();
            LogInOptions.Show();
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            UserRegistration UserRegistration = new UserRegistration();
            UserRegistration.Show();
            this.Hide();
        }

        private void ManagerLoginButton_Click(object sender, EventArgs e)
        {

        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connsting))
                {
                    connection.Open();


                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "EXEC userLogin @Email, @Password";
                        command.Parameters.Add(new SqlParameter("@Email", userEmailInput.Text));
                        command.Parameters.Add(new SqlParameter("@Password", UserPasswordInput.Text));

                        SqlDataReader reader = command.ExecuteReader();


                        if (reader.Read())
                        {
                            MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            shop shop = new shop();
                            shop.Show();
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
