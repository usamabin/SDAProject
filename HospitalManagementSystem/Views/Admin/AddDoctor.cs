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
using System.Text.RegularExpressions;

namespace HospitalManagementSystem.Views
{
    public partial class AddDoctor : UserControl
    {
        CDoctor doc;
        MAddDoctor add;
        MAvalibleDays av;
        int click = 0;
        public AddDoctor()
        {
            InitializeComponent();
            doc = new CDoctor();
            add = new MAddDoctor();
            av = new MAvalibleDays();
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
        private void AddDoctor_Load(object sender, EventArgs e)
        {
            DataTable dt = doc.GetDays();
            foreach (DataRow datarow in dt.Rows)
            {
                checkedListBox1.Items.Add(datarow["Name"]);
            }


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFathername.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtPhoneNumber.Text != "" && txtSalary.Text != "" && txtCnic.Text != "" && txtAddress.Text != "" && comboSpeciality.SelectedItem.ToString() != "" && checkedListBox1.CheckedIndices.ToString() != "")
            {
                if (Phone(txtPhoneNumber.Text) >= 1 && numberpass(txtPhoneNumber.Text) >= 1 && txtPhoneNumber.Text.Length == 12)
                {
                    if (Cnic(txtCnic.Text) >= 1 && numberpass(txtCnic.Text) >= 1 && txtCnic.Text.Length == 15)
                    {
                        if (numberpass(txtSalary.Text) >= 1)
                        {
                            if (txtUserName.Text.Length >= 6 && txtPassword.Text.Length >= 6)
                            {

                                if (numberpass(txtName.Text) == 0 && numberpass(txtFathername.Text) == 0)
                                {
                                    add.id = doc.GetId() + 1;
                                    add.name = txtName.Text;
                                    add.fathername = txtFathername.Text;
                                    add.username = txtUserName.Text;
                                    add.password = txtPassword.Text;
                                    add.PhoneNumber = txtPhoneNumber.Text;
                                    add.Cnic = txtCnic.Text;
                                    add.Address = txtAddress.Text;
                                    add.salary = txtSalary.Text;
                                    add.dateofbirth = dtDOB.Value.ToString("yyyy-MM-dd");
                                    add.speciality = comboSpeciality.SelectedItem.ToString();
                                    doc.AddDoctor(add);
                                    //
                                    string[] days = new string[5];
                                    for (int i = 0; i < days.Length; i++)
                                    {
                                        days[0] = "0";
                                    }

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
                                        av.DocID = doc.GetId();
                                        av.Dayid = doc.GetDayId(item);
                                        doc.AddDay(av);
                                    }
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
            DataTable dt = doc.GetDoc();
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            //if (txtName.Text != "" && txtFathername.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtPhoneNumber.Text != "" && txtSalary.Text != "" && txtCnic.Text != "" && txtAddress.Text != "" && comboSpeciality.SelectedItem.ToString() != "" && checkedListBox1.CheckedIndices.ToString() != "")
            //{
               if (Phone(txtPhoneNumber.Text) >= 1 && numberpass(txtPhoneNumber.Text) >= 1 && txtPhoneNumber.Text.Length == 12)
                {
                    if (Cnic(txtCnic.Text) >= 1 && numberpass(txtCnic.Text) >= 1 && txtCnic.Text.Length == 15)
                    {
                        if (numberpass(txtSalary.Text) >= 1)
                        {
                            if (txtUserName.Text.Length >= 6 && txtPassword.Text.Length >= 6)
                            {

                                if (numberpass(txtName.Text) == 0 && numberpass(txtFathername.Text) == 0)
                                {
                                    if (click >= 1)
                                {
                                    try
                                    {
                                        string[] days = new string[5];
                                        for (int i = 0; i < days.Length; i++)
                                        {
                                            days[0] = "0";
                                        }

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
                                            //av.id = doc.getid(item);
                                            av.DocID = doc.GetId();
                                            av.Dayid = doc.GetDayId(item);
                                            doc.UpdateDays(av);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Please Enter Any Row to Update");
                                    }

                                    add.id = doc.GetId() + 1;
                                    add.name = txtName.Text;
                                    add.fathername = txtFathername.Text;
                                    add.username = txtUserName.Text;
                                    add.password = txtPassword.Text;
                                    add.PhoneNumber = txtPhoneNumber.Text;
                                    add.Cnic = txtCnic.Text;
                                    add.Address = txtAddress.Text;
                                    add.salary = txtSalary.Text;
                                    add.dateofbirth = dtDOB.Value.ToString("yyyy-MM-dd");
                                    add.speciality = comboSpeciality.SelectedItem.ToString();
                                    doc.UpdateDoctor(add);
                                }
                                //

                                else
                                {
                                    MessageBox.Show("Please Enter Any Row to Update");
                                }
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
            //}
            //else
            //{
            //    MessageBox.Show("Please Enter All Feilds");
            //}

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtFathername.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtSalary.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtCnic.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            click++;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (click >= 1)
            {
                try
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    doc.deleteDay(id);
                    doc.delete(id);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Any Row to Delete");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Any Row to Delete");
            }
        }
    }
}
