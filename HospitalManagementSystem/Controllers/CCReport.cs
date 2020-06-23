using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Controllers;
using System.Text.RegularExpressions;
using HospitalManagementSystem.Models;
using System.Data;

namespace HospitalManagementSystem.Controllers
{

    class CCReport
    {
        DatabaseHelper db = new DatabaseHelper();
        public DataTable getReport(int id)
        {
            string query = "Select * from Report where patientid=" + id + "";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
        public DataTable getMedicine(int id)
        {
            string query = "Select * from OfferedMedicine where patientid=" + id + "";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
        public DataTable getPReport(int id)
        {
            string query = "Select * from Report where patientid=" + id + "";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
    }


}

