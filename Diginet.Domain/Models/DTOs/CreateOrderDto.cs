using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Models.DTOs
{
    public class CreateOrderDto
    {
        public int Order_ID { get; set; }
        public int Product_ID { get; set; }
        public decimal Product_Amount { get; set; }
        public decimal SVP { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
