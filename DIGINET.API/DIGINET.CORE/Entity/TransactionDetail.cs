using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGINET.CORE.Entity
{
    public class TransactionDetail
    {
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public int AssetType_ID { get; set; }
        public int TransferFromLedger_ID { get; set; }
        public int TransferToLedger_ID { get; set; }
        public int TransferCustomer_ID { get; set; }
        public decimal TransferFrom_Quantity { get; set; }
        public decimal TranferTo_Quantity { get; set; }
        public decimal Conversion_Value { get; set; }
        public string Transfer_Reason { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
