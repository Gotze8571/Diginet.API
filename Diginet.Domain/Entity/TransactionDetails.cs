using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class TransactionDetails
    {
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public int AssetType_ID { get; set; }
        public int TransferFromLedger_ID { get; set; }
        public int MyProperty { get; set; }
    }
}
