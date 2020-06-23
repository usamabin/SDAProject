using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Controllers;

namespace HospitalManagementSystem.Views.Admin
{
    public partial class ViewMedicine : UserControl
    {
        CMedicine obj;

        public ViewMedicine()
        {
            InitializeComponent();
            obj = new CMedicine();
        }

        private void ViewMedicine_Load(object sender, EventArgs e)
        {
            DataTable dt = obj.GetMedicine();
            dataGridView1.DataSource = dt;
        }
    }
}
