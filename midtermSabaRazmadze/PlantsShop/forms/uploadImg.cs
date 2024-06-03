using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsShop.forms
{
    public partial class uploadImg : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public uploadImg()
        {
            InitializeComponent();
        }

        private void uploadImg_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            //string selectedFileName = "";
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    selectedFileName = ofd.FileName;
            //    pictureBox1.ImageLocation = selectedFileName;
            //    string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //    string resourcesDirectory = Path.Combine(appDirectory, "Resources");
            //    if (!Directory.Exists(resourcesDirectory))
            //    {
            //        Directory.CreateDirectory(resourcesDirectory);
            //    }
            //    string destinationFileName = Path.Combine(resourcesDirectory, Path.GetFileName(selectedFileName));
            //    File.Copy(selectedFileName, destinationFileName, true);

            //    if (!File.Exists(destinationFileName))
            //    {
            //        using (File.Create(destinationFileName)) { }
            //    }

            //    using (SqlConnection conn = new SqlConnection(connsting))
            //    {
            //        conn.Open();
            //        using (SqlCommand cmd = conn.CreateCommand())
            //        {
            //            cmd.CommandText = "exec addPhoto @PlantID, @PhotoURL";
            //            cmd.Parameters.Add(new SqlParameter("@PlantID", id.Value));
            //            cmd.Parameters.Add(new SqlParameter("@PhotoURL", destinationFileName));

            //            int result = cmd.ExecuteNonQuery();

            //            if (result > 0)
            //            {
            //                MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //    }
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
