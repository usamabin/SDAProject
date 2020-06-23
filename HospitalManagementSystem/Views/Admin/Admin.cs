using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HospitalManagementSystem
{
    public partial class Admin : Form
    {

        public Admin()

        {

            InitializeComponent();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            addDoctor1.Show();
            addPharmist1.Hide();
            addReception1.Hide();
            viewDoctor1.Hide();
            viewMedicine1.Hide();
            viewPharmist1.Hide();
            viewReception1.Hide();
        }

        private void btnAddreciption_Click(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPharmist1.Hide();
            addReception1.Show();
            viewDoctor1.Hide();
            viewMedicine1.Hide();
            viewPharmist1.Hide();
            viewReception1.Hide();

        }

        private void btnAddPharmist_Click(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPharmist1.Show();
            addReception1.Hide();
            viewDoctor1.Hide();
            viewMedicine1.Hide();
            viewPharmist1.Hide();
            viewReception1.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPharmist1.Hide();
            addReception1.Hide();
            viewDoctor1.Show();
            viewMedicine1.Hide();
            viewPharmist1.Hide();
            viewReception1.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPharmist1.Hide();
            addReception1.Hide();
            viewDoctor1.Hide();
            viewMedicine1.Hide();
            viewPharmist1.Show();
            viewReception1.Hide();
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPharmist1.Hide();
            addReception1.Hide();
            viewDoctor1.Hide();
            viewMedicine1.Hide();
            viewPharmist1.Hide();
            viewReception1.Show();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPharmist1.Hide();
            addReception1.Hide();
            viewDoctor1.Hide();
            viewMedicine1.Show();
            viewPharmist1.Hide();
            viewReception1.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPharmist1.Hide();
            addReception1.Hide();
            viewDoctor1.Hide();
            viewMedicine1.Hide();
            viewPharmist1.Hide();
            viewReception1.Hide();
        }
    }
}
