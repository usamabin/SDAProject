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

namespace HospitalManagementSystem.Views
{
    public partial class GenerateReport : UserControl
    {
        CgenrateReport gen;
        OfferedMedicine of;
        Report rep;
        int i = 0;
        public GenerateReport()
        {
            InitializeComponent();
            gen = new CgenrateReport();
            of = new OfferedMedicine();
            rep = new Report();
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {
            DataTable dt = gen.getPatient();
            
            foreach (DataRow row in dt.Rows)
            {
                comboBoxId.Items.Add(row["ID"]);

            }
            DataTable dtt = gen.getMedicine();
            foreach (DataRow datarow in dtt.Rows)
            {
                checkedListBox1.Items.Add(datarow["Name"]);
            }

        }

        

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            {
                
                int id = int.Parse(comboBoxId.SelectedItem.ToString());
                DataTable dt = gen.getPatient(id);
                
                foreach (DataRow dr in dt.Rows)
                {
                    txtName.Text = dr[1].ToString();
                    txtFatherName.Text = dr[2].ToString();
                    txtPhoneNumber.Text = dr[5].ToString();
                    txtCnic.Text = dr[6].ToString();
                    txtAddress.Text = dr[7].ToString();
                    txtDay.Text = dr[8].ToString();
                    txtDisease.Text = dr[9].ToString();
                }
               
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            rep.Pid = int.Parse(comboBoxId.SelectedItem.ToString());
            rep.name = txtName.Text;
            rep.fathername = txtFatherName.Text;
            rep.PhoneNumber = txtPhoneNumber.Text;
            rep.Cnic = txtCnic.Text;
            rep.Address = txtAddress.Text;
            rep.Disease = txtDisease.Text;
            rep.Dis = richTextBox1.Text;
            gen.Report(rep);

            
            //
            List<string> checkedItems = new List<string>();
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    checkedItems.Add(checkedListBox1.CheckedItems[x].ToString());
                }
            }

            foreach (string item in checkedItems)
            {
                of.patientid = int.Parse(comboBoxId.SelectedItem.ToString());
                of.name = item;
                gen.AddMedicine(of);
            }
        }
    }
}

