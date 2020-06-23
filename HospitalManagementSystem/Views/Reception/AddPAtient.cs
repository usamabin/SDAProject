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
using System.Text.RegularExpressions;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Views
{
    public partial class AddPAtient : UserControl
    {
        CAddPAtient patient;
        MAddPAtient add;
        int click = 0;
        public AddPAtient()
        {
            InitializeComponent();
            patient = new CAddPAtient();
            add = new MAddPAtient();
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

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFatherName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtPhoneNumber.Text != "" && txtCnic.Text != "" && txtAddress.Text != "")
            {
                if (Phone(txtPhoneNumber.Text) >= 1 && numberpass(txtPhoneNumber.Text) >= 1 && txtPhoneNumber.Text.Length == 12)
                {
                    if (Cnic(txtCnic.Text) >= 1 && numberpass(txtCnic.Text) >= 1 && txtCnic.Text.Length == 15)
                    {

                        if (txtUserName.Text.Length >= 6 && txtPassword.Text.Length >= 6)
                        {

                            if (numberpass(txtName.Text) == 0 && numberpass(txtFatherName.Text) == 0)
                            {
                                add.id = patient.GetId() + 1;
                                add.name = txtName.Text;
                                add.fathername = txtFatherName.Text;
                                add.username = txtUserName.Text;
                                add.password = txtPassword.Text;
                                add.PhoneNumber = txtPhoneNumber.Text;
                                add.Cnic = txtCnic.Text;
                                add.Address = txtAddress.Text;
                                add.Day = comboDay.SelectedItem.ToString();
                                add.Disease = comboDisease.SelectedItem.ToString();
                                add.Refered = comboRefered.SelectedItem.ToString();
                                add.dateofbirth = datetimeDOB.Value.ToString("yyyy-MM-dd");
                                patient.ADDPatient(add);
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
        public void AddRefresh()
        {
            txtAddress.Text = null;
            txtCnic.Text = null;
            txtFatherName.Text = null;
            txtName.Text = null;
            txtPassword.Text = null;
            txtPhoneNumber.Text = null;
            txtUserName.Text = null;
            comboRefered.Text = null;
            comboDisease.Text = null;
            comboDay.Text = null;
        }

        //private void comboRefered_MouseClick(object sender, MouseEventArgs e)
        //{
        //    int dayid;
        //    if (comboDay.SelectedItem.ToString() != "" && comboDisease.SelectedItem.ToString() != "")
        //    {
        //        dayid = patient.GetDayId(comboDay.SelectedItem.ToString());


        //        DataTable dt = patient.getDoc(dayid);
        //        int[] array = new int[dt.Rows.Count];
        //        for (int a = 0; a < dt.Rows.Count; a++)
        //        {
        //            array[a] = int.Parse(dt.Rows[a]["DoctorID"].ToString());
        //            MessageBox.Show(+array[a] + "");
        //        }
        //        DataTable dtt = patient.getDocID(comboDisease.SelectedItem.ToString());
        //        int[] array1 = new int[dtt.Rows.Count];
        //        for (int a = 0; a < dtt.Rows.Count; a++)
        //        {
        //            array[a] = int.Parse(dtt.Rows[a]["ID"].ToString());
        //            MessageBox.Show(+array[a] + "");
        //        }

        //        var result = array1.Union(array);
        //        int[] arrays = new int[5];
        //        arrays = result.ToArray();
        //        foreach (var item in arrays)
        //        {
        //            DataTable dts = patient.doctor(item);
        //            comboRefered.DataSource = dts;
        //            comboRefered.DisplayMember = "Name";

        //        }

        //    }

            //DataTable dt = patient.GetDoctor();
            //comboRefered.DataSource = dt;
            //comboRefered.DisplayMember = "Name";
            //comboRefered.ValueMember = "Name";
        ////}

        private void AddPAtient_Load(object sender, EventArgs e)
        {
            //DataTable dt = patient.GetDoctor();
            //comboRefered.DataSource = dt;
            //comboRefered.DisplayMember = "Name";
            //comboRefered.ValueMember = "Name";


        }

        private void comboRefered_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboDisease_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = patient.getDoct();
            comboRefered.Items.Add("--Select--");
            foreach (DataRow row in dt.Rows)
            {
                comboRefered.Items.Add(row["Name"]);

            }
            comboRefered.SelectedIndex = 0;

            //int dayid;
            //if (comboDay.SelectedItem.ToString() != "" && comboDisease.SelectedItem.ToString() != "")
            //{
            //    dayid = patient.GetDayId(comboDay.SelectedItem.ToString());


            //    DataTable dt = patient.getDoc(dayid);
            //    int[] array = new int[dt.Rows.Count];
            //    for (int a = 0; a < dt.Rows.Count; a++)
            //    {
            //        array[a] = int.Parse(dt.Rows[a]["DoctorID"].ToString());
            //        MessageBox.Show(+array[a] + "");
            //    }
            //    DataTable dtt = patient.getDocID(comboDisease.SelectedItem.ToString());
            //    int[] array1 = new int[dtt.Rows.Count];
            //    for (int a = 0; a < dtt.Rows.Count; a++)
            //    {
            //        array[a] = int.Parse(dtt.Rows[a]["ID"].ToString());
            //        MessageBox.Show(+array[a] + "");
            //    }

            //    var result = array.Intersect(array1);
            //    int[] arrays = new int[10];
            //    arrays = result.ToArray();
            //    foreach (var item in arrays)
            //    {
            //        DataTable dts = patient.doctor(item);
            //        comboRefered.DataSource = dts;
            //        comboRefered.DisplayMember = "Name";

            //    }

            //}
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            DataTable dt = patient.GetPAtient();
            dataGridView1.DataSource = dt;

           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtCnic.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comboDay.Text= dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboDisease.Text= dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            comboRefered.Text= dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            datetimeDOB.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && txtFatherName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtPhoneNumber.Text != "" && txtCnic.Text != "" && txtAddress.Text != "")
            {
                if (Phone(txtPhoneNumber.Text) >= 1 && numberpass(txtPhoneNumber.Text) >= 1 && txtPhoneNumber.Text.Length == 12)
                {
                    if (Cnic(txtCnic.Text) >= 1 && numberpass(txtCnic.Text) >= 1 && txtCnic.Text.Length == 15)
                    {

                        if (txtUserName.Text.Length >= 6 && txtPassword.Text.Length >= 6)
                        {

                            if (numberpass(txtName.Text) == 0 && numberpass(txtFatherName.Text) == 0)
                            {
                                add.id = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                                add.name = txtName.Text;
                                add.fathername = txtFatherName.Text;
                                add.username = txtUserName.Text;
                                add.password = txtPassword.Text;
                                add.PhoneNumber = txtPhoneNumber.Text;
                                add.Cnic = txtCnic.Text;
                                add.Address = txtAddress.Text;
                                add.dateofbirth = datetimeDOB.Value.ToString("yyyy-MM-dd");
                                patient.UpdatePatient(add);
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                if (click > 0)
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    patient.delete(id);
                    AddRefresh();
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

