using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Views;

namespace HospitalManagementSystem
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            viewPatient1.Visible = false;
            generateReport1.Visible = false;
            viewMedicine1.Visible = false;

        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            viewPatient1.Visible = true;
            generateReport1.Visible = false;
            viewMedicine1.Visible = false;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void btnViewmedicine_Click(object sender, EventArgs e)
        {
            generateReport1.Visible = true;
            viewPatient1.Visible = false;
            viewMedicine1.Visible = false;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            viewMedicine1.Visible = true;
            generateReport1.Visible = false;
            viewPatient1.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }
    }
}
