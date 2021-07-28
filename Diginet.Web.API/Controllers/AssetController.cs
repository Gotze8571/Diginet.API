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
    public class AssetController : ControllerBase
    {
        [HttpGet("assetType")]
        public IEnumerable<AssetType> GetProductAssetType()
        {
            return null;
        }

        [HttpGet("assetTypeRate")]
        public IEnumerable<AssetTypeRate> GetProductAssetTypeRate()
        {
            return null;
        }
    }
}
