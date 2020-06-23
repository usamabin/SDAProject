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
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Views.Patient
{
    public partial class ViewReport : UserControl
    {
        CCReport rep;
        public ViewReport()
        {
            InitializeComponent();
            rep = new CCReport();
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            UserId.userid = 1;

            
            DataTable dt = rep.getPReport(UserId.userid);

            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["ID"]);

            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            DataTable dt = rep.getMedicine(int.Parse(comboBox1.SelectedItem.ToString()));

            richTextBox2.Text = "";
            foreach (DataRow dr in dt.Rows)
            {

                richTextBox2.Text += dr[2].ToString() + "\n";
            }
            DataTable dtt = rep.getReport(int.Parse(comboBox1.SelectedItem.ToString()));
            foreach (DataRow dr in dtt.Rows)
            {
                txtId.Text = dr[1].ToString();
                txtName.Text = dr[2].ToString();
                txtFatherName.Text = dr[3].ToString();
                txtPhoneNumber.Text = dr[4].ToString();
                txtCnic.Text = dr[5].ToString();
                txtAddress.Text = dr[6].ToString();
                txtDisease.Text = dr[7].ToString();
                richTextBox1.Text = dr[8].ToString();
            }
        }
    }
}
