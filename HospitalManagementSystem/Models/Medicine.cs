using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Qty{ get; set; }
        public string Exp { get; set; }
        public string MFP{ get; set; }
        public int Price { get; set; }
        
    }
}
