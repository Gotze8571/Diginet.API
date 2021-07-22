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
    public class ProductController : ControllerBase
    {
        [HttpGet("Product")]
        public IEnumerable<Product> GetProduct()
        {
            return null;
        }
        [HttpGet("ProductAssetType")]
        public IEnumerable<ProductAssetType> GetProductAssetType()
        {
            return null;
        }
        [HttpGet("ProductCountry")]
        public IEnumerable<ProductCountry> GetProductCountry()
        {
            return null;
        }
    }
}
