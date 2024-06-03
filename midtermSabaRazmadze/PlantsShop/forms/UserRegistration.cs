using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlantsShop.forms
{
    public partial class UserRegistration : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LogInAsUser LogInAsUser = new LogInAsUser();
            LogInAsUser.Show();
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserPassword.Text == passwordConfirm.Text)
                {
                    using (SqlConnection connection = new SqlConnection(connsting))
                    {
                        connection.Open();


                        using (SqlCommand command = connection.CreateCommand())
                        {


                            command.CommandText = "EXEC addUser @Username, @Email, @Password";
                            command.Parameters.Add(new SqlParameter("@Username", UserName.Text));
                            command.Parameters.Add(new SqlParameter("@Email", UserEmailInput.Text));
                            command.Parameters.Add(new SqlParameter("@Password", UserPassword.Text));

                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LogInAsUser LogInAsUser = new LogInAsUser();
                                LogInAsUser.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("პაროლები ერთნაირი არაა!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("შეცდომაა!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
