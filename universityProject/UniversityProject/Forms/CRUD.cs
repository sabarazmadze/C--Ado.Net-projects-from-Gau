using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityProject.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UniversityProject.Forms
{
    public partial class CRUD : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        Modes _Mode;
        Who _Who;
        public CRUD(Modes mode = Modes.View, Who who = Who.Lecurer)
        {
            InitializeComponent();
            _Mode = mode;
            _Who = who;
            if (_Mode == Modes.Create)
            {
                ID.Visible = false;
                labelID.Visible = false;
                dataGridView.Visible = false;
            }
            else if (_Mode == Modes.Delete)
            {
                textBoxEmail.Visible = false;
                labelEmal.Visible = false;
                textBoxFullName.Visible = false;
                labelFullName.Visible = false;
                textBoxPassword.Visible = false;
                labelPassword.Visible = false;
            }
            else if (_Mode == Modes.View)
            {
                ID.Visible = false;
                labelID.Visible = false;
                textBoxEmail.Visible = false;
                labelEmal.Visible = false;
                textBoxFullName.Visible = false;
                labelFullName.Visible = false;
                textBoxPassword.Visible = false;
                labelPassword.Visible = false;
                Exec.Visible = false;
            }
            else
            {
                dataGridView.Visible = false;
            }
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable ds = new DataTable();

                using (SqlConnection connection = new SqlConnection(connsting))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        if (_Who == Who.Student)
                        {
                            if (_Mode == Modes.View)
                            {
                                command.CommandText = "EXEC viewAllSudents";
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    ds.Load(reader);

                                }
                            }
                            else if (_Mode == Modes.Delete)
                            {
                                command.CommandText = "EXEC viewAllSudents";
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    ds.Load(reader);

                                }
                            }
                        }
                        else
                        {
                            if (_Mode == Modes.View)
                            {
                                command.CommandText = "EXEC viewAllLecturers";
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    ds.Load(reader);

                                }
                            }
                            else if (_Mode == Modes.Delete)
                            {
                                command.CommandText = "EXEC viewAllLecturers";
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    ds.Load(reader);

                                }
                            }

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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Exec_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connsting))
            {
                connection.Open();


                using (SqlCommand command = connection.CreateCommand())
                {
                    if (_Who == Who.Student)
                    {
                        if (_Mode == Modes.Delete)
                        {
                            command.CommandText = "EXEC removeStudent @ID";
                            command.Parameters.Add(new SqlParameter("@ID", ID.Text));
                        }
                        else if (_Mode == Modes.Create)
                        {
                            command.CommandText = "EXEC addStudent @StudentName, @Email, @Password";
                            command.Parameters.Add(new SqlParameter("@StudentName", textBoxFullName.Text));
                            command.Parameters.Add(new SqlParameter("@Email", textBoxEmail.Text));
                            command.Parameters.Add(new SqlParameter("@Password", textBoxPassword.Text));
                        }
                        else if (_Mode == Modes.Update)
                        {
                            command.CommandText = "EXEC updateStudent @StudentID @StudentName, @Email, @Password";
                            command.Parameters.Add(new SqlParameter("@StudentID", ID.Text));
                            command.Parameters.Add(new SqlParameter("@StudentName", textBoxFullName.Text));
                            command.Parameters.Add(new SqlParameter("@Email", textBoxEmail.Text));
                            command.Parameters.Add(new SqlParameter("@Password", textBoxPassword.Text));
                        }
                    }
                    else
                    {
                        if (_Mode == Modes.Delete)
                        {
                            command.CommandText = "EXEC removeLecturer @ID";
                            command.Parameters.Add(new SqlParameter("@ID", Convert.ToInt64(ID.Text)));
                        }
                        else if (_Mode == Modes.Create)
                        {
                            command.CommandText = "EXEC addLecturer @LecurerName, @Email, @Password";
                            command.Parameters.Add(new SqlParameter("@LecurerName", textBoxFullName.Text));
                            command.Parameters.Add(new SqlParameter("@Email", textBoxEmail.Text));
                            command.Parameters.Add(new SqlParameter("@Password", textBoxPassword.Text));
                        }
                        else if (_Mode == Modes.Update)
                        {
                            command.CommandText = "EXEC updateLecturer @LecturerID @LecturerName, @Email, @Password";
                            command.Parameters.Add(new SqlParameter("@LecturerID", ID.Text));
                            command.Parameters.Add(new SqlParameter("@LecturerName", textBoxFullName.Text));
                            command.Parameters.Add(new SqlParameter("@Email", textBoxEmail.Text));
                            command.Parameters.Add(new SqlParameter("@Password", textBoxPassword.Text));
                        }
                    }
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
            }
        }

        private void ID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connsting))
                    {
                        conn.Open();
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            if (_Who == Who.Student)
                            {
                                cmd.CommandText = "SELECT StudentName, Email, Password FROM students WHERE StudentID = @Id";
                                cmd.Parameters.Add(new SqlParameter("@Id", ID.Value));
                                SqlDataReader dr = cmd.ExecuteReader();
                                DataTable dt = new DataTable();
                                while (!dr.IsClosed)
                                    dt.Load(dr);

                                textBoxEmail.Text = dt.Rows[0]["Email"].ToString();
                                textBoxPassword.Text = dt.Rows[0]["Password"].ToString();
                                textBoxFullName.Text = dt.Rows[0]["StudentName"].ToString();
                            }
                            else
                            {
                                cmd.CommandText = "SELECT LecturerName, Email, Password FROM Lecturers WHERE LecturerID = @Id";
                                cmd.Parameters.Add(new SqlParameter("@Id", ID.Value));
                                SqlDataReader dr = cmd.ExecuteReader();
                                DataTable dt = new DataTable();
                                while (!dr.IsClosed)
                                    dt.Load(dr);

                                textBoxEmail.Text = dt.Rows[0]["Email"].ToString();
                                textBoxPassword.Text = dt.Rows[0]["Password"].ToString();
                                textBoxFullName.Text = dt.Rows[0]["LecturerName"].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
