using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diginet.Web.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Order> GetOrder()
        {
            return null;
        }

        

    }
}
