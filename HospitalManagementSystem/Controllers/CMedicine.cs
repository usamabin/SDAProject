using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Controllers;
using System.Windows.Forms;

namespace HospitalManagementSystem.Controllers
{
    class CMedicine
    {
        DatabaseHelper db = new DatabaseHelper();
        int click = 0;
        public int GetId()
        {
            try
            {
                int id;
                string query = "SELECT MAX(MedicineID) AS LastID FROM Medicine";
                DataTable dt = db.DataNavigationOperation(query);
                id = int.Parse(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception)
            {

                return 0;
            }

        }
        public void AddMedicine(Medicine Obj)
        {
            string query = "insert into Medicine values(" + Obj.ID + ",'" + Obj.Name + "'," + Obj.Qty + "," + Obj.Price + ",'" + Obj.Exp + "','" + Obj.MFP + "')";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data inserted successfully");
            }
        }
        public DataTable GetMedicine()
        {
            string query = "select * from Medicine";
            DataTable dt = db.DataNavigationOperation(query);
            return dt;
        }
        public void UpdateMEdicine(Medicine Obj)
        {

            string query = "update Medicine set MedicineID=" + Obj.ID + ",Name='" + Obj.Name + "',quantity=" + Obj.Qty + ",price=" + Obj.Price + ",ExpDate='" + Obj.Exp + "',MF='" + Obj.MFP + "'where MedicineID=" + Obj.ID + "";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data Updated successfully");
                click++;
            }
        }
        public void delete(int id)
        {
            string query = "delete from Medicine where MedicineID='" + id + "'";
            if (db.DataManipulationOperation(query))
            {
                MessageBox.Show("Data Deleted");
            }
        }

    }
}

