using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Views
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
            viewMedicine1.Visible = false;
            addMedicine1.Visible = false;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            addMedicine1.Visible = true;
            viewMedicine1.Visible = false;

        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            viewMedicine1.Visible = true;
            addMedicine1.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
