using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class ProductAssetType
    {
        public int ID { get; set; }
        public int Product_ID { get; set; }
        public int AssetType_ID { get; set; }
        public decimal Quantity { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
