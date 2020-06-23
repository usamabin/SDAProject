using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    
    class CDoctor
    {
        DatabaseHelper db;
       
        public CDoctor()
        {
            db = new DatabaseHelper();
        }
        public int GetId()
        {
            try
            {
                int id;
                string query = "SELECT MAX(ID) AS LastID FROM Doctor";
                DataTable dt = db.DataNavigationOperation(query);
                id = int.Parse(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public int GetDayId(string name)
        {
            string query="select DayID from WorkingDays where Name ='"+name+"'";
            DataTable dt = db.DataNavigationOperation(query);
            int id = int.Parse(dt.Rows[0][0].ToString());
            return id;

        }
        public void AddDoctor(MAddDoctor Obj)
        {
            string query = "insert into Doctor values(" + Obj.id + ",'" + Obj.name + "','" + Obj.fathername + "','" + Obj.username + "','" + Obj.password + "','"+Obj.salary+"','"+Obj.speciality+"','" + Obj.PhoneNumber + "','" + Obj.Cnic + "','" + Obj.Address + "','" + Obj.dateofbirth + "')";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data inserted successfully");
            }
        }
        public void AddDay(MAvalibleDays Obj)
        {
            string query = "insert into AvailableDays(DayID,DocID) values(" + Obj.Dayid + "," + Obj.DocID + ")";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data inserted successfully");
            }
        }
        public void UpdateDoctor(MAddDoctor Obj)
        {
            string query = "update Doctor set ID=" + Obj.id + ",Name='" + Obj.name + "',FatherName='" + Obj.fathername + "',Username='" + Obj.username + "',UserPass='" + Obj.password + "',PhoneNumber='" + Obj.PhoneNumber + "',Cnic='" + Obj.Cnic + "',Address='" + Obj.Address + "',Salary='" + Obj.salary + "',DOB='" + Obj.dateofbirth + "',Speciality='"+Obj.speciality+"'where ID=" + Obj.id + "";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data Updated successfully");
            }
        }
        public int getid(string name)
        {
            try
            {
                int id;
                string query = "select Id from AvailibleDays where Name='" + name + "'";
                DataTable dt = db.DataNavigationOperation(query);
                id = int.Parse(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while getting id");
                return 0;
                
            }
        }
        public void deleteDay(int id)
        {
            string query = "delete from AvailableDays where DocID='" + id + "'";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("success");
            }
        }

        public void delete(int id)
        {
            string query = "delete from Doctor where ID='" + id + "'";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("success");
            }
        }

        public void UpdateDays(MAvalibleDays Obj)
        {
            string query = "update AvailableDays set DayID=" + Obj.Dayid + ",DoctorID="+Obj.Dayid+ "where DoctorID=" + Obj.Dayid + "";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data Updated successfully");
            }
        }
        public DataTable GetDays()
        {
            string query = "select * from WorkingDays";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
        public DataTable GetDoc()
        {
            string query = "select * from Doctor";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
    }
}
