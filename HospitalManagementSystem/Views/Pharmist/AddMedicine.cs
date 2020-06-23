using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Controllers;

namespace HospitalManagementSystem.Views
{
    
    public partial class AddMedicine : UserControl
    {
        Medicine med;
        int click = 0;
        CMedicine Cmed;
        public AddMedicine()
        {
            InitializeComponent();
            med = new Medicine();
            Cmed = new CMedicine();
        }
        public int numberpass(string a)
        {
            int num = 0;
            foreach (char ch in a)
            {
                if (char.IsDigit(ch))
                {
                    num++;
                }
            }
            return num;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                if (numberpass(txtName.Text) == 0 && numberpass(txtPrice.Text) >= 1 && numberpass(txtQuantity.Text) >= 1)
                {
                    if (int.Parse(txtPrice.Text) > 0 && int.Parse(txtQuantity.Text) > 0)
                    {
                        med.ID = Cmed.GetId() + 1;
                        med.Name = txtName.Text;
                        med.Price = int.Parse(txtPrice.Text);
                        med.Qty = int.Parse(txtQuantity.Text);
                        med.Exp = datetimeExp.Value.ToString("yyyy-MM-dd");
                        med.MFP = dateTimeMF.Value.ToString("yyyy-MM-dd");
                        Cmed.AddMedicine(med);
                        ClearDAta();
                        DataTable dt = Cmed.GetMedicine();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("NEgative Values Are Not Allowed");
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Correct information Feilds");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Feilds");
            }

            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataTable dt = Cmed.GetMedicine();
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
        }
        public void ClearDAta()
        {
            txtName.Text=null;
            txtPrice.Text=null;
            txtQuantity.Text = null; ;
            datetimeExp.Text=null;
            dateTimeMF.Text=null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (txtName.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                if (numberpass(txtName.Text) == 0 && numberpass(txtPrice.Text) >= 1 && numberpass(txtQuantity.Text) >= 1)
                {
                    if (int.Parse(txtPrice.Text) > 0 && int.Parse(txtQuantity.Text) > 0)
                    {
                        med.ID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()); ;
                        med.Name = txtName.Text;
                        med.Price = int.Parse(txtPrice.Text);
                        med.Qty = int.Parse(txtQuantity.Text);
                        med.Exp = datetimeExp.Value.ToString("yyyy-MM-dd");
                        med.MFP = dateTimeMF.Value.ToString("yyyy-MM-dd");
                        Cmed.UpdateMEdicine(med);
                        click--;
                        ClearDAta();
                        DataTable dt = Cmed.GetMedicine();
                        dataGridView1.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("NEgative Values Are Not Allowed");
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Correct information Feilds");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Feilds");
            }


        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            datetimeExp.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimeMF.Text= dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            click++;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (click > 0)
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    Cmed.delete(id);
                    ClearDAta();
                    DataTable dt = Cmed.GetMedicine();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Please Select any Row to Delete");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select any Row to Delete");
            }
        }

    }
}

