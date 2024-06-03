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
using PlantsShop.enums;

namespace PlantsShop.forms
{
    public partial class ManagerPage : Form
    {
        
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
      
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LogInAsManager LogInAsManager = new LogInAsManager();
            LogInAsManager.Show();
            this.Hide();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.View, Tables.sunlight);
            CRUD.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Delete, Tables.sunlight);
            CRUD.Show();
        }

        private void wateringToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManagerPage_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable ds = new DataTable();

                using (SqlConnection connection = new SqlConnection(connsting))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "EXEC showAllPlants";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ds.Load(reader);

                        }
                    }
                }
                dataGridView1.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("ოპერაცია წარუმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.View, Tables.soil);
            CRUD.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Create, Tables.soil);
            CRUD.Show();
        }

        private void s_e_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Update, Tables.soil);
            CRUD.Show();
        }

        private void S_R_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Delete, Tables.soil);
            CRUD.Show();
        }

        private void sun_add_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Create, Tables.sunlight);
            CRUD.Show();
        }

        private void sun_e_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Update, Tables.sunlight);
            CRUD.Show();
        }

        private void G_a_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Create, Tables.groups);
            CRUD.Show();
        }

        private void groupsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.View, Tables.groups);
            CRUD.Show();
        }

        private void groupsRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Delete, Tables.groups);
            CRUD.Show();
        }

        private void groupsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Update, Tables.groups);
            CRUD.Show();
        }

        private void wateringViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.View, Tables.watering);
            CRUD.Show();
        }

        private void wateringAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Create, Tables.watering);
            CRUD.Show();
        }

        private void wateringRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Delete, Tables.watering);
            CRUD.Show();
        }

        private void wateringUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD CRUD = new CRUD(CRUDs.Update, Tables.watering);
            CRUD.Show();
        }

        private void plantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--------------- plants daamate mere
        }

        private void plantEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Plant CRUD_Plant = new CRUD_Plant(CRUDs.Update);
            CRUD_Plant.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Plant CRUD_Plant = new CRUD_Plant(CRUDs.View);
            CRUD_Plant.Show();
        }

        private void plantAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Plant CRUD_Plant = new CRUD_Plant(CRUDs.Create);
            CRUD_Plant.Show();
        }

        private void plantRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Plant CRUD_Plant = new CRUD_Plant(CRUDs.Delete);
            CRUD_Plant.Show();
        }

        private void plantAddPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--------need to be added
            uploadImg uploadImg = new uploadImg();
            uploadImg.Show();
        }
    }
}
