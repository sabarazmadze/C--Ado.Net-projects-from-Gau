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
    public partial class LogInOptions : Form
    {
        public LogInOptions()
        {
            InitializeComponent();
        }

        private void LogInAsUser_Click(object sender, EventArgs e)
        {
            LogInAsUser LogInAsUser = new LogInAsUser();
            LogInAsUser.Show();
            this.Hide();
        }

        private void LogInOptions_Load(object sender, EventArgs e)
        {

        }

        private void LogInAsManager_Click(object sender, EventArgs e)
        {
            LogInAsManager LogInAsManager = new LogInAsManager();
            LogInAsManager.Show();
            this.Hide();
        }
    }
}
