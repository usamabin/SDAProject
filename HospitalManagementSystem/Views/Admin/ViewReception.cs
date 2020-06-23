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
    public partial class ViewReception : UserControl
    {
        CReception obj;
        public ViewReception()
        {
            InitializeComponent();
            obj = new CReception();
        }

        private void ViewReception_Load(object sender, EventArgs e)
        {
            DataTable dt = obj.GetReception();
            dataGridView1.DataSource = dt;

        }
    }
}
