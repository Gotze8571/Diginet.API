using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Models.API
{
    public class ApiResponse
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public object Data { get; set; }
    }
}
