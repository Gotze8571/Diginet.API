using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class AssetTypeRate
    {
        [Key]
        public int ID { get; set; }
        public string AssetType { get; set; }
        public string AssetType_Description { get; set; }
        public int Is_Active { get; set; }
        public string Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
