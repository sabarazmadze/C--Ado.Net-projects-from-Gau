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
using PlantsShop.enums;

namespace PlantsShop.forms
{
    public partial class CRUD : Form
    {
        public string connsting = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        CRUDs _Mode;
        Tables _Tables;
        string _query;
        string _queryViewDS;
        public string value;

        public CRUD(CRUDs Mode = CRUDs.None, Tables __Tables = Tables.none)
        {
            InitializeComponent();
            _Mode = Mode;
            _Tables = __Tables;
            InitializeUI();
        }

        private void InitializeUI()
        {
            labelID.Visible = true;
            ID.Visible = true;
            textBoxName.Visible = _Mode != CRUDs.Delete;
            name.Visible = _Mode != CRUDs.Delete;
            dataGridView.Visible = true;

            switch (_Mode)
            {
                case CRUDs.View:
                    labelID.Visible = true;
                    ID.Visible = true;
                    textBoxName.Visible = false;
                    name.Visible = false;
                    Exec.Visible = false;
                    dataGridView.Visible = true;
                    break;
                case CRUDs.Create:
                    textBoxName.Visible = true;
                    name.Visible = true;
                    labelID.Visible = false;
                    ID.Visible = false;
                    dataGridView.Visible = false;
                    break;
            }

            switch (_Mode)
            {
                case CRUDs.View:
                    switch (_Tables)
                    {
                        case Tables.watering:
                            _queryViewDS = "exec viewWatering";
                            break;
                        case Tables.groups:
                            _queryViewDS = "exec viewGroups";
                            break;
                        case Tables.soil:
                            _queryViewDS = "exec viewSoil";
                            break;
                        case Tables.sunlight:
                            _queryViewDS = "exec viewSunlight";
                            break;
                    }
                    break;
                case CRUDs.Create:
                    switch (_Tables)
                    {
                        case Tables.watering:
                            _queryViewDS = "exec viewWatering";
                            _query = "exec addWatering @Name";
                            break;
                        case Tables.groups:
                            _queryViewDS = "exec viewGroups";
                            _query = "exec addGroup @Name";
                            break;
                        case Tables.soil:
                            _queryViewDS = "exec viewSoil";
                            _query = "exec addSoil @Name";
                            break;
                        case Tables.sunlight:
                            _queryViewDS = "exec viewSunlight";
                            _query = "exec addSunlight @Name";
                            break;
                    }
                    break;
                case CRUDs.Delete:
                    switch (_Tables)
                    {
                        case Tables.watering:
                            _queryViewDS = "exec viewWatering";
                            _query = "exec removeWatering @ID";
                            break;
                        case Tables.groups:
                            _queryViewDS = "exec viewGroups";
                            _query = "exec removeGroup @ID";
                            break;
                        case Tables.soil:
                            _queryViewDS = "exec viewSoil";
                            _query = "exec removeSoil @ID";
                            break;
                        case Tables.sunlight:
                            _queryViewDS = "exec viewSunlight";
                            _query = "exec removeSunlight @ID";
                            break;
                    }
                    break;
                case CRUDs.Update:
                    switch (_Tables)
                    {
                        case Tables.watering:
                            _queryViewDS = "exec viewWatering";
                            _query = "exec editWatering @ID, @Name";
                            break;
                        case Tables.groups:
                            _queryViewDS = "exec viewGroups";
                            _query = "exec editGroup @ID, @Name";
                            break;
                        case Tables.soil:
                            _queryViewDS = "exec viewSoil";
                            _query = "exec editSoil @ID, @Name";
                            break;
                        case Tables.sunlight:
                            _queryViewDS = "exec viewSunlight";
                            _query = "exec editSunlight @ID, @Name";
                            break;
                    }
                    break;
            }
        }

        private async void CRUD_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Mode != CRUDs.Create)
                {
                    DataTable ds = new DataTable();

                    using (SqlConnection connection = new SqlConnection(connsting))
                    {
                        await connection.OpenAsync();

                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = _queryViewDS;
                            using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            {
                                ds.Load(reader);
                            }
                        }
                    }
                    dataGridView.DataSource = ds;
                }

                using (SqlConnection conn = new SqlConnection(connsting))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        switch (_Tables)
                        {
                            case Tables.watering:
                                cmd.CommandText = "select count(*) AS RAOD from [dbo].[Watering]";
                                break;
                            case Tables.groups:
                                cmd.CommandText = "select count(*) AS RAOD from [dbo].[Groups]";
                                break;
                            case Tables.soil:
                                cmd.CommandText = "select count(*) AS RAOD from [dbo].[Soil] ";
                                break;
                            case Tables.sunlight:
                                cmd.CommandText = "select count(*) AS RAOD from Sunlight ";
                                break;
                        }
                        SqlDataReader dr = await cmd.ExecuteReaderAsync();
                        DataTable dt = new DataTable();
                        while (!dr.IsClosed)
                            dt.Load(dr);

                        ID.Maximum = Convert.ToInt16(dt.Rows[0]["RAOD"]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("ოპერაცია წარუმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void Exec_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connsting))
            {
                await connection.OpenAsync();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = _query;
                        if (_Mode == CRUDs.Create)
                            command.Parameters.Add(new SqlParameter("@Name", textBoxName.Text));
                        if (_Mode == CRUDs.Update)
                        {
                            command.Parameters.Add(new SqlParameter("@Name", textBoxName.Text));
                            command.Parameters.Add(new SqlParameter("@ID", ID.Value));
                        }
                        if (_Mode == CRUDs.Delete)
                            command.Parameters.Add(new SqlParameter("@ID", ID.Value));

                        int result = await command.ExecuteNonQueryAsync();
                        transaction.Commit();

                        if (result > 0)
                        {
                            MessageBox.Show("ოპერაცია წარმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("ოპერაცია წარუმატებულია!", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    transaction.Rollback();
                }
            }
        }

        private async void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (_Mode == CRUDs.Update)
                    {
                        switch (_Tables)
                        {
                            case Tables.watering:
                                value = "select [WateringDescription] from [dbo].[Watering] where [WateringID]=@ID";
                                break;
                            case Tables.groups:
                                value = "select [GroupName] from [dbo].[Groups] where [GroupID]=@ID";
                                break;
                            case Tables.soil:
                                value = "select [SoilType] from [dbo].[Soil] where [SoilID]=@ID";
                                break;
                            case Tables.sunlight:
                                value = "select SunlightIntensity from Sunlight where [SunlightID]=@ID";
                                break;
                        }

                        using (SqlConnection conn = new SqlConnection(connsting))
                        {
                            await conn.OpenAsync();
                            using (SqlCommand cmd = conn.CreateCommand())
                            {
                                cmd.CommandText = value;
                                cmd.Parameters.Add(new SqlParameter("@ID", ID.Value));
                                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                                DataTable dt = new DataTable();
                                while (!dr.IsClosed)
                                    dt.Load(dr);

                                switch (_Tables)
                                {
                                    case Tables.watering:
                                        textBoxName.Text = dt.Rows[0]["[WateringDescription]"].ToString();
                                        break;
                                    case Tables.groups:
                                        textBoxName.Text = dt.Rows[0]["[GroupName]"].ToString();
                                        break;
                                    case Tables.soil:
                                        textBoxName.Text = dt.Rows[0]["[SoilType]"].ToString();
                                        break;
                                    case Tables.sunlight:
                                        textBoxName.Text = dt.Rows[0]["SunlightIntensity"].ToString();
                                        break;
                                }
                            }
                        }
                    }

                    if (_Mode == CRUDs.View)
                    {
                        DataTable ds = new DataTable();

                        using (SqlConnection connection = new SqlConnection(connsting))
                        {
                            await connection.OpenAsync();

                            using (SqlCommand command = connection.CreateCommand())
                            {
                                string selectById = "";

                                switch (_Tables)
                                {
                                    case Tables.watering:
                                        selectById = "exec viewWateringBYId @ID";
                                        break;
                                    case Tables.groups:
                                        selectById = "exec viewGroupsBYId @ID";
                                        break;
                                    case Tables.soil:
                                        selectById = "exec viewSoilBYId @ID";
                                        break;
                                    case Tables.sunlight:
                                        selectById = "exec viewSunlightBYId @ID";
                                        break;
                                }

                                command.CommandText = selectById;
                                command.Parameters.Add(new SqlParameter("@ID", ID.Value));

                                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                                {
                                    ds.Load(reader);
                                }
                            }
                        }
                        dataGridView.DataSource = ds;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
