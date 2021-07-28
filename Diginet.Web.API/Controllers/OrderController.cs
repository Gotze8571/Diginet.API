using Diginet.Domain.Entity;
using Diginet.Domain.Helpers.Interface;
using Diginet.Domain.Models.API;
using Diginet.Domain.Models.DTOs;
using Diginet.Domain.Services.Interface;
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
        private readonly IUtil _util;
        private readonly IOrderService _orderService;

        public OrderController(IUtil util, IOrderService orderService)
        {
            _util = util;
            _orderService = orderService;
        }

        [HttpGet("order-detail")]
        public async Task<IActionResult> GetOrderDetails(OrderDto dto)
        {
            try
            {
                var response = await _orderService.GetOrder(dto);

                var statusCode = _util.GetStatusCode(response.Code);
                return StatusCode(statusCode, response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse() { Code = "96", Description = "System malfunction" });
            }
          
        }

        [HttpGet("order-master")]
        public async Task<IActionResult> GetOrderMaster(OrderMasterDto dto)
        {
            try
            {
                var response = await _orderService.GetOrderMaster(dto);

                var statusCode = _util.GetStatusCode(response.Code);
                return StatusCode(statusCode, response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse() { Code = "96", Description = "System malfunction" });
            }
        }



    }
}
