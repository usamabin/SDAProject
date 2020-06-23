using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;
using System.Windows.Forms;

namespace HospitalManagementSystem.Controllers
{
    class CAddPAtient
    {
        DatabaseHelper db = new DatabaseHelper();
        public int GetDayId(string name)
        {
            try
            {
                int id;
                string query = "select DayId from WorkingDays where Name='" + name + "'";
                DataTable dt = db.DataNavigationOperation(query);
                id = int.Parse(dt.Rows[0][0].ToString());
                return id;
            }
            catch
            {
                
                return 0;
            }
        }
       public void ADDPatient(MAddPAtient Obj)
        {
            string query = "insert into Patient values(" + Obj.id + ",'" + Obj.name + "','" + Obj.fathername + "','" + Obj.username + "','" + Obj.password + "','" + Obj.PhoneNumber + "','" + Obj.Cnic + "','" + Obj.Address + "','" + Obj.Day+ "','" + Obj.Disease + "','" + Obj.Refered + "','" + Obj.dateofbirth + "')";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data inserted successfully");
            }
        }
        public int GetId()
        {
            try
            {
                int id;
                string query = "SELECT MAX(ID) AS LastID FROM Patient";
                DataTable dt = db.DataNavigationOperation(query);
                id = int.Parse(dt.Rows[0][0].ToString());
                return id;
            }
            catch
            {

                return 0;
            }
        }
        public DataTable doctor(int id)
        {
            string query = "select Name from Doctor where ID='" + id + "'";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
        public DataTable getDoct()
        {
            string query = "select * from Doctor ";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;

        }
        public DataTable getDoc(int name)
        {
            string query = "select DoctorID from AvailableDays where DayId='" + name + "'";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;

        }
        public DataTable getDocID(string name)
        {
            string query = "select ID from Doctor where Speciality='" + name + "'";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;

        }
        public void UpdatePatient(MAddPAtient Obj)
        {

            string query = "update Patient set ID= " + Obj.id + ",Name='" + Obj.name + "',FatherNAme='" + Obj.fathername + "',UserName='" + Obj.username + "',Userpass='" + Obj.password + "',PhoneNumber='" + Obj.PhoneNumber + "',CNIC='" + Obj.Cnic + "',Address='" + Obj.Address + "',day='" + Obj.Day + "',DiseaseType='" + Obj.Disease + "',ReferedTo='" + Obj.Refered + "',DOB='" + Obj.dateofbirth + "'";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data Updated successfully");
               
            }
        }
        public void delete(int id)
        {
            string query = "delete from Patient where ID='" + id + "'";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data Deleted");
            }
        }
        public DataTable GetPAtient()
        {
            string query = "select * from Patient";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
    }
}
