using Diginet.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diginet.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankController : ControllerBase
    {
        [HttpGet("rank")]
        public IEnumerable<Rank> GetRank()
        {
            return null;
        }
        [HttpGet("rank-history")]
        public IEnumerable<Rank> GetRankHistory()
        {
            return null;
        }
    }
}
