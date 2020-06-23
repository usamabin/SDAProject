using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;
using System.Data;
using System.Windows.Forms;


namespace HospitalManagementSystem.Controllers
{
    class CPharmist
    {
        DatabaseHelper db = new DatabaseHelper();

        public int GetId()
        {
            try
            {
                int id;
                string query = "SELECT MAX(ID) AS LastID FROM Pharmist";
                DataTable dt = db.DataNavigationOperation(query);
                id = int.Parse(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception)
            {
               
                return 0;
            }

        }
        public int GetPid(string name)
        {
            try
            {
                int id;
                string query = "select Id from Pharmist where UserName='" + name + "'";
                DataTable dt = db.DataNavigationOperation(query);
                id = int.Parse(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while getting id");
                return -1;
            }
        }
        public void AddPharmist(MAddPharmist Obj)
        {
            string query = "insert into Pharmist values(" + Obj.ID + ",'" + Obj.Name + "','" + Obj.FatherName + "','" + Obj.UserName + "','" + Obj.Password + "','" + Obj.PhoneNum + "','" + Obj.CNIC + "','" + Obj.Address + "','" + Obj.Salary + "','" + Obj.Dob + "')";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data inserted successfully");
            }
        }
        public DataTable GetPharmist()
        {
            string query = "select * from Pharmist";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
       
        public void UpdatePharmist(MAddPharmist Obj)
        {
            string query = "update Pharmist set ID="+Obj.ID +",Name='" + Obj.Name + "',FatherName='" + Obj.FatherName + "',Username='" + Obj.UserName + "',UserPass='" + Obj.Password + "',PhoneNumber='" + Obj.PhoneNum + "',Cnic='" + Obj.CNIC + "',Address='" + Obj.Address + "',Salary='" + Obj.Salary + "',DOB='" + Obj.Dob + "'where ID=" + Obj.ID+ "";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data Updated successfully");
            }
        }
        public void delete(int id)
        {
            string query = "delete from Pharmist where ID='" + id+ "'";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("success");
            }
        }
       
    }
}
