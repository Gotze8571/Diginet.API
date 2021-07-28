using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class ErrorLog
    {
        [Key]
        public int Id { get; set; }
        public string MethodName { get; set; }
        public string ErrorName { get; set; }
        public DateTime ErrorDate { get; set; }
    }
}
