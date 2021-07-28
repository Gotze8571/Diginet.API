using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGINET.CORE.Entity
{
    public class CustomerLedger
    {
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public int AssetType_ID { get; set; }
        public decimal Quantity { get; set; }
        public DateTime Transaction_Date { get; set; }
        public int Is_Active { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
