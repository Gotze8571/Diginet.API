using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGINET.CORE.Entity
{
    public class Rank
    {
        public int ID { get; set; }
        public string Rank_Name { get; set; }
        public string Rank_Description { get; set; }
        public decimal RankMaximum_Points { get; set; }
        public decimal RankMinimum_Points { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
