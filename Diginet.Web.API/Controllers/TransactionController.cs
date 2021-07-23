﻿using Diginet.Domain.Entity;
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
    public class TransactionController : ControllerBase
    {
        [HttpGet("transaction-details")]
        public IEnumerable<TransactionDetails> GetTransactionDetails()
        {
            return null;
        }

    }
}
