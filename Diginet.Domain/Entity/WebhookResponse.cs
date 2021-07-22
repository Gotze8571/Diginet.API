using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Entity
{
    public class WebhookResponse
    {
        public int ID { get; set; }
        public string JSON_Response { get; set; }
        public string Method_Name { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Update_Date { get; set; }
        public int Update_By { get; set; }
    }
}
