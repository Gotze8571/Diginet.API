using Diginet.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diginet.Web.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppConfigurationController : ControllerBase
    {
        [HttpGet("AppConfiguration")]
        public IEnumerable<AppConfiguration> GetAppConfiguration()
        {
            return null;
        }
    }
}
