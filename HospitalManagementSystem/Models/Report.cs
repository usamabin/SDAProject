using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    class Report
    {
        public int id { get; set; }
        public int Pid { get; set; }
        public string name { get; set; }
        public string fathername { get; set; }
       
        public string Disease { get; set; }
        public string Cnic { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Dis { get; set; }
    }
}
