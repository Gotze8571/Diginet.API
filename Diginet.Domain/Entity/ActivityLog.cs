using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class ActivityLog
    {
        [Key]
        public int Id { get; set; }
        public string MethodName { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityDate { get; set; }
    }
}
