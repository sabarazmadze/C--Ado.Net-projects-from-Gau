using PlantsShop.enums;
using System;
using System.Collections;
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
    public partial class CRUD_Plant : Form
    {

        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public CRUDs _Mode;
        public string _query;
        public CRUD_Plant(CRUDs Mode = CRUDs.None, string query = null)
        {
            InitializeComponent();
            _Mode = Mode;
            switch (Mode)
            {
                case CRUDs.None:
                    break;
                case CRUDs.Update:
                    dataGridView.Visible = false;
                    _query = "exec editPlant @ID, @PlantName, @GroupID, @WateringID, @SoilID, @SunlightID";
                    break;
                case CRUDs.Delete:
                    dataGridView.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    labelEmal.Visible = false;
                    labelPassword.Visible = false;
                    group.Visible = false;
                    GroupId.Visible = false;
                    watering.Visible = false;
                    wateringId.Visible = false;
                    soil.Visible = false;
                    soilId.Visible = false;
                    sunlight.Visible = false;
                    sunlightId.Visible = false;
                    PlantName.Visible = false;
                    _query = "exec removePlant @ID";
                    break;
                case CRUDs.Create:
                    dataGridView.Visible = false;
                    ID.Visible = false;
                    labelID.Visible = false;
                    _query = "exec addPlant @PlantName, @GroupID, @WateringID, @SoilID, @SunlightID";
                    break;
                case CRUDs.View:
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    labelEmal.Visible = false;
                    labelPassword.Visible = false;
                    group.Visible = false;
                    GroupId.Visible = false;
                    watering.Visible = false;
                    wateringId.Visible = false;
                    soil.Visible = false;
                    soilId.Visible = false;
                    sunlight.Visible = false;
                    sunlightId.Visible = false;
                    PlantName.Visible = false;
                    _query = "exec showPlantsBYId @ID";
                    break;
            }

        }

        private void labelPassword_Click(object sender, EventArgs e)
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
                            cmd.CommandText = "select [PlantName],[GroupID],[WateringID],[SoilID],[SunlightID] from [dbo].[Plant] where [PlantID]=@Id";
                            cmd.Parameters.Add(new SqlParameter("@Id", ID.Value));
                            SqlDataReader dr = cmd.ExecuteReader();
                            DataTable dt = new DataTable();
                            while (!dr.IsClosed)
                                dt.Load(dr);

                            PlantName.Text = dt.Rows[0]["PlantName"].ToString();
                            GroupId.Value = Convert.ToInt16(dt.Rows[0]["GroupID"]);
                            wateringId.Value = Convert.ToInt16(dt.Rows[0]["WateringID"]);
                            soilId.Value = Convert.ToInt16(dt.Rows[0]["SoilID"]);
                            sunlightId.Value = Convert.ToInt16(dt.Rows[0]["SunlightID"]);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CRUD_Plant_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connsting))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select count(*) AS RAOD from [dbo].[Groups]";
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    while (!dr.IsClosed)
                        dt.Load(dr);

                    GroupId.Maximum = Convert.ToInt16(dt.Rows[0]["RAOD"]);

                }
            }
            using (SqlConnection conn = new SqlConnection(connsting))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select count(*) AS RAOD from [dbo].[Watering]";
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    while (!dr.IsClosed)
                        dt.Load(dr);

                    wateringId.Maximum = Convert.ToInt16(dt.Rows[0]["RAOD"]);

                }
            }
            using (SqlConnection conn = new SqlConnection(connsting))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select count(*) AS RAOD from [dbo].[Soil] ";
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    while (!dr.IsClosed)
                        dt.Load(dr);

                    soilId.Maximum = Convert.ToInt16(dt.Rows[0]["RAOD"]);

                }
            }
            using (SqlConnection conn = new SqlConnection(connsting))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select count(*) AS RAOD from Sunlight ";
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    while (!dr.IsClosed)
                        dt.Load(dr);

                    sunlightId.Maximum = Convert.ToInt16(dt.Rows[0]["RAOD"]);

                }
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GroupId_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connsting))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select [GroupName] from [dbo].[Groups] where [GroupID]=@ID";
                        cmd.Parameters.Add(new SqlParameter("@ID", GroupId.Value));
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        while (!dr.IsClosed)
                            dt.Load(dr);

                        group.Text = dt.Rows[0]["GroupName"].ToString();

                    }
                }
            }
            catch
            {
                group.Text = "";
            }
        }

        private void wateringId_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connsting))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select [WateringDescription] from [dbo].[Watering] where [WateringID]=@ID";
                        cmd.Parameters.Add(new SqlParameter("@ID", wateringId.Value));
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        while (!dr.IsClosed)
                            dt.Load(dr);

                        watering.Text = dt.Rows[0]["WateringDescription"].ToString();

                    }
                }
            }
            catch
            {
                watering.Text = "";
            }
        }

        private void soilId_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connsting))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select [SoilType] from [dbo].[Soil] where [SoilID]=@ID";
                        cmd.Parameters.Add(new SqlParameter("@ID", soilId.Value));
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        while (!dr.IsClosed)
                            dt.Load(dr);

                        soil.Text = dt.Rows[0]["SoilType"].ToString();

                    }
                }
            }
            catch
            {
                soil.Text = "";
            }
        }

        private void sunlightId_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connsting))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select SunlightIntensity from Sunlight where [SunlightID]=@ID";
                        cmd.Parameters.Add(new SqlParameter("@ID", sunlightId.Value));
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        while (!dr.IsClosed)
                            dt.Load(dr);

                        sunlight.Text = dt.Rows[0]["SunlightIntensity"].ToString();

                    }
                }
            }
            catch
            {
                sunlight.Text = "";
            }
        }

        private void Exec_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ds = new DataTable();
                using (SqlConnection conn = new SqlConnection(connsting))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = _query;
                        if (_Mode != CRUDs.View)
                        {
                            switch (_Mode)
                            {
                                case CRUDs.Delete:
                                    cmd.Parameters.Add(new SqlParameter("@ID", ID.Value));
                                    break;
                                case CRUDs.Update:
                                    cmd.Parameters.Add(new SqlParameter("@ID", ID.Value));
                                    cmd.Parameters.Add(new SqlParameter("@PlantName", PlantName.Text));
                                    cmd.Parameters.Add(new SqlParameter("@GroupID", GroupId.Value));
                                    cmd.Parameters.Add(new SqlParameter("@WateringID", wateringId.Value));
                                    cmd.Parameters.Add(new SqlParameter("@SoilID", soilId.Value));
                                    cmd.Parameters.Add(new SqlParameter("@SunlightID", sunlightId.Value));
                                    break;
                                case CRUDs.Create:
                                    cmd.Parameters.Add(new SqlParameter("@PlantName", PlantName.Text));
                                    cmd.Parameters.Add(new SqlParameter("@GroupID", GroupId.Value));
                                    cmd.Parameters.Add(new SqlParameter("@WateringID", wateringId.Value));
                                    cmd.Parameters.Add(new SqlParameter("@SoilID", soilId.Value));
                                    cmd.Parameters.Add(new SqlParameter("@SunlightID", sunlightId.Value));
                                    break;
     
                            }

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                            }
                        }
                        else
                        {
                            cmd.Parameters.Add(new SqlParameter("@ID", ID.Value));
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                ds.Load(reader);

                            }
                        }
                    }
                }
                dataGridView.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
