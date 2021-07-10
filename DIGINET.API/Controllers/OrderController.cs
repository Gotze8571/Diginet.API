using DIGINET.CORE.Interface.API;
using DIGINET.CORE.Model.DTO.Model;
using DIGINET.CORE.Model.DTO.Response;
using DIGINET.CORE.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIGINET.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IStatusCode _statusCode;
        private readonly IAddOrder _addOrder;

        [HttpPost]
        [Route("AddOrder")]
        public async Task<IActionResult> AddOrder(OrderDto dto)
        {
            try
            {
                var error = new ApiResponse()
                {
                    Code = "400",
                    Description = "one or more input field not correctly passed/empty"
                };
                if (!ModelState.IsValid)
                {
                    return BadRequest(error);
                }
                var response = await _addOrder.AddOrder(dto);

                var statusCode = _statusCode.GetStatusCode(response.Code);
                return StatusCode(statusCode, response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse() { Code = "96", Description = "System malfunction" });
            }
        }

    }
}
