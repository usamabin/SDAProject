using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    class DatabaseHelper
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public DatabaseHelper()
        {
            string constring = @"Data Source=DESKTOP-HVQ3E0K;Initial Catalog=HospitalMS;Integrated Security=True";
            conn = new SqlConnection(constring);
        }

        public bool DataManipulationOperation(string query)
        {
            try
            {

                conn.Open();
                cmd = new SqlCommand(query, conn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return false;

            }

        }
        public DataTable DataNavigationOperation(string query)
        {
            cmd = new SqlCommand(query, conn);

            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return new DataTable();
        }
        public DataTable ProcedureDataNavigation(string query)
        {

            cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return new DataTable();
        }
    }
}
