using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class AppConfiguration
    {
        public int ID { get; set; }
        public string Configuration_Name { get; set; }
        public string Configuartion_Description { get; set; }
        public string Configuration_Value { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
