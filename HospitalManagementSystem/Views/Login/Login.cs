using HospitalManagementSystem.Models;
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
   
    public partial class Login : Form
    {
       
        DatabaseHelper db;
        private object reg;

        

        public Login()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "" && comboBox1.SelectedItem.ToString() != "")
            {
               if (comboBox1.SelectedItem.ToString() == "Admin")
                {
                    string queryAdmin = "select * from [Administrator]";
                    DataTable dt = db.DataNavigationOperation(queryAdmin);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txtUserName.Text.ToLower() == dr[2].ToString().ToLower() && txtPassword.Text.ToLower() == dr[3].ToString().ToLower())
                        {
                            Admin admin = new Admin();
                         
                            admin.Show();
                            return;


                        }
                    }
                }
               //
                if (comboBox1.SelectedItem.ToString() == "Patient")
                {
                    string queryAdmin = "select * from [Patient]";
                    DataTable dt = db.DataNavigationOperation(queryAdmin);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txtUserName.Text.ToLower() == dr[3].ToString().ToLower() && txtPassword.Text.ToLower() == dr[4].ToString().ToLower())
                        {
                            Patient admin = new Patient();
                            admin.Show();
                           
                            return;


                        }
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "Pharmist")
                {
                    string queryAdmin = "select * from [Pharmist]";
                    DataTable dt = db.DataNavigationOperation(queryAdmin);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txtUserName.Text.ToLower() == dr[3].ToString().ToLower() && txtPassword.Text.ToLower() == dr[4].ToString().ToLower())
                        {
                            Pharmacy admin = new Pharmacy();
                            
                            admin.Show();
                            return;


                        }
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "Receptionist")
                {
                    string queryAdmin = "select * from [Reception]";
                    DataTable dt = db.DataNavigationOperation(queryAdmin);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txtUserName.Text.ToLower() == dr[3].ToString().ToLower() && txtPassword.Text.ToLower() == dr[4].ToString().ToLower())
                        {
                            Reciption admin = new Reciption();
                           
                            admin.Show();
                            return;


                        }
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "Doctor")
                {
                    string queryAdmin = "select * from [Doctor]";
                    DataTable dt = db.DataNavigationOperation(queryAdmin);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txtUserName.Text.ToLower() == dr[3].ToString().ToLower() && txtPassword.Text.ToLower() == dr[4].ToString().ToLower())
                        {
                            Doctor admin = new Doctor();
                            
                            admin.Show();
                            return;


                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }

            else
            {
                MessageBox.Show("Please Enter All Feilds");
            }
        }

        private void Login_FormClosed4(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed3(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed2(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
    }

