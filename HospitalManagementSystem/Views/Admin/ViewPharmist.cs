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
    public partial class ViewPharmist : UserControl
    {
        CPharmist obj;
        public ViewPharmist()
        {
            InitializeComponent();
            obj = new CPharmist();
        }

        private void ViewPharmist_Load(object sender, EventArgs e)
        {
            DataTable dt = obj.GetPharmist();
            dataGridView1.DataSource = dt;

        }
    }
}
