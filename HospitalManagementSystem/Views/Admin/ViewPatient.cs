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
    public partial class ViewPatient : UserControl
    {
        CAddPAtient obj;
        public ViewPatient()
        {
            obj = new CAddPAtient();
            InitializeComponent();
        }

        private void ViewPatient_Load(object sender, EventArgs e)
        {
            DataTable dt = obj.GetPAtient();
            dataGridView1.DataSource = dt;
        }
    }
}
