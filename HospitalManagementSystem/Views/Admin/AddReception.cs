﻿using System;
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
using System.Text.RegularExpressions;

namespace HospitalManagementSystem.Views.Admin
{
    public partial class AddReception : UserControl
    {
        CReception rec;
        MAddReception add;
        int click = 0;
        public AddReception()
        {
            InitializeComponent();
            rec = new CReception();
            add = new MAddReception();
        }

        public int Phone(string a)
        {
            int num = 0;
            Regex r = new Regex(@"\d{4}-\d{7}");
            if (r.IsMatch(a))
            {
                num++;
            }

            return num;
        }
        public int Cnic(string a)
        {
            int num = 0;
            Regex r1 = new Regex(@"\d{5}-\d{7}-\d{1}");
            if (r1.IsMatch(a))
            {
                num++;
            }

            return num;
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
        private void AddRefresh()
        {
            txtAddress.Text = null;
            txtCnic.Text = null;
            txtFatherName.Text = null;
            txtName.Text = null;
            txtPassword.Text = null;
            txtPhoneNumber.Text = null;
            txtSalary.Text = null;
            txtUserName.Text = null;
        }
        private void RefreshData()
        {
            DataTable dt = rec.GetReception();
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
            txtAddress.Text = null;
            txtCnic.Text = null;
            txtFatherName.Text = null;
            txtName.Text = null;
            txtPassword.Text = null;
            txtPhoneNumber.Text = null;
            txtSalary.Text = null;
            txtUserName.Text = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFatherName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtPhoneNumber.Text != "" && txtSalary.Text != "" && txtCnic.Text != "" && txtAddress.Text != "")
            {
                if (Phone(txtPhoneNumber.Text) >= 1 && numberpass(txtPhoneNumber.Text) >= 1 && txtPhoneNumber.Text.Length == 12)
                {
                    if (Cnic(txtCnic.Text) >= 1 && numberpass(txtCnic.Text) >= 1 && txtCnic.Text.Length == 15)
                    {
                        if (numberpass(txtSalary.Text) >= 1)
                        {
                            if (txtUserName.Text.Length >= 6 && txtPassword.Text.Length >= 6)
                            {

                                if (numberpass(txtName.Text) == 0 && numberpass(txtFatherName.Text) == 0)
                                {
                                    add.ID = rec.GetId() + 1;
                                    add.Name = txtName.Text;
                                    add.FatherName = txtFatherName.Text;
                                    add.UserName = txtUserName.Text;
                                    add.Password = txtPassword.Text;
                                    add.PhoneNum = txtPhoneNumber.Text;
                                    add.CNIC = txtCnic.Text;
                                    add.Address = txtAddress.Text;
                                    add.Salary = txtSalary.Text;
                                    add.Dob = datetimeDOB.Value.ToString("yyyy-MM-dd");
                                    rec.AddReception(add);
                                    AddRefresh();
                                }
                                else
                                {
                                    MessageBox.Show("Name feild must contain only alphabets");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your Username and Password lenght must be greater than 5");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Correct Salary in Numeric Form");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Make sure the format should be 00000-0000000-0 ");

                    }
                }
                else
                {
                    MessageBox.Show("Make sure the Phone Number format is 0000-0000000");
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Feilds");
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataTable dt = rec.GetReception();
            dataGridView1.DataSource = dt;
            //dataGridView1.AllowUserToAddRows = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (click > 0)
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    add.ID = id;
                    add.Name = txtName.Text;
                    add.FatherName = txtFatherName.Text;
                    add.UserName = txtUserName.Text;
                    add.Password = txtPassword.Text;
                    add.PhoneNum = txtPhoneNumber.Text;
                    add.CNIC = txtCnic.Text;
                    add.Address = txtAddress.Text;
                    add.Salary = txtSalary.Text;
                    add.Dob = datetimeDOB.Value.ToString("yyyy-MM-dd");
                    rec.UpdateReception(add);
                }
                else
                {
                    MessageBox.Show("Please select anyrow to update");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select any Row to Update");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            click++;
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtCnic.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtSalary.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (click > 0)
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    rec.delete(id);
                    RefreshData();
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

