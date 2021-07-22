using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class CustomerRank
    {
        [Key]
        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public int Rank_ID { get; set; }
        public DateTime RankAchieve_Date { get; set; }
        public decimal Rank_Points { get; set; }
        public int Is_Current { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }// More explanation
        public DateTime Updated_Date { get; set; }
    }
}
