using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class OrderMaster
    {
        [Key]
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public string ExternalSystemOrder_ID { get; set; }
        public decimal Order_Amount { get; set; }
        public DateTime Order_Date { get; set; }
        public int WebhookResponse_ID { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
