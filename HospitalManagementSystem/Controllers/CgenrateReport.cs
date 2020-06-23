using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    class CgenrateReport
    {
        DatabaseHelper db = new DatabaseHelper();
        public DataTable getPatient()
        {
            string query = "select * from Patient";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;


        }
        public void Report(Report Obj)
        {
            string query = "insert into Report(patientid,Name,FatherName,PhoneNumber,Cnic,PAddress,diseaseType,Discription) values(" + Obj.Pid + ",'" + Obj.name + "','"+Obj.fathername+"','" + Obj.PhoneNumber + "','" + Obj.Cnic + "','" + Obj.Address + "','" + Obj.Disease + "','" + Obj.Dis+ "')";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data inserted successfully");
            }
        }
        public void AddMedicine(OfferedMedicine Obj)
        {
            string query = "insert into OfferedMedicine(PatientID,Name) values(" + Obj.patientid + ",'" + Obj.name + "')";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data inserted successfully");
            }
        }
        public DataTable getMedicine()
        {
            string query = "select * from Medicine ";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }

            public DataTable getPatient(int id)
        {
            string query = "select * from Patient where ID="+id+"";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;


        }
    }
}
