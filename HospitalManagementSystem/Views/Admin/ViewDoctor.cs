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
    public partial class ViewDoctor : UserControl
    {
        CDoctor cc;
        DatabaseHelper db;
        
        public ViewDoctor()
        {
            InitializeComponent();
            cc = new CDoctor();
            db = new DatabaseHelper();
        }

        private void ViewDoctor_Load(object sender, EventArgs e)
        {
            DataTable dt = cc.GetDoc();
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
        }
    }
}
