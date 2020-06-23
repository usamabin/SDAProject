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
    public partial class Reciption : Form
    {
        public Reciption()
        {
            InitializeComponent();
            addPAtient1.Visible = false;
            viewReport1.Visible = false;
            generateBill1.Visible = false;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            addPAtient1.Visible = true;
            viewReport1.Visible = false;
            generateBill1.Visible = false;
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            viewReport1.Visible = true;
            addPAtient1.Visible = false;
            generateBill1.Visible = false;
        }

        private void btnGeneratebill_Click(object sender, EventArgs e)
        {
            generateBill1.Visible = true;
            addPAtient1.Visible = false;
          
            viewReport1.Visible = false;
        }

        private void generateBill1_Load(object sender, EventArgs e)
        {

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
