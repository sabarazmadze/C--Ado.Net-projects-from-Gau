using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsShop.forms
{
    public partial class shop : Form
    {
        public shop()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LogInAsUser LogInAsUser = new LogInAsUser();
            LogInAsUser.Show();
            this.Hide();
        }

        private void shop_Load(object sender, EventArgs e)
        {

        }
    }
}
