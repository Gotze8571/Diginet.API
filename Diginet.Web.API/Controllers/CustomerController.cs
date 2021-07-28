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
    public class CustomerController : ControllerBase
    {
        [HttpGet("Customer")]
        public IEnumerable<Customer> GetCustomer()
        {
            return null;
        }

        [HttpGet("customer-ledger")]
        public IEnumerable<CustomerLedger> GetCustomerLedger()
        {
            return null;
        }

        [HttpGet("customer-rank")]
        public IEnumerable<CustomerRank> GetCustomerRank()
        {
            return null;
        }

        [HttpGet("customer-type")]
        public IEnumerable<CustomerType> GetCustomerType()
        {
            return null;
        }
    }
}
