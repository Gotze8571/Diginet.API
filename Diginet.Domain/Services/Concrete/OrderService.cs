using Diginet.Domain.Models.API;
using Diginet.Domain.Models.DTOs;
using Diginet.Domain.Repositories.Interface;
using Diginet.Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IDbConnection _dbConnection;

        public OrderService(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
            //_dbConnection = dbConnection;
        }
      
        public async Task<ApiResponse> GetOrder(OrderDto dto)
        {
            var result = await _orderRepo.AddOrder();
            if (result == 1)
            {
                return new ApiResponse() { Code = "00", Description = "Order was successfully added." };
            }
            return new ApiResponse() { Code = "96", Description = "System malfunction" };
        }

        public async Task<ApiResponse> GetOrderMaster(OrderMasterDto dto)
        {
            var result = await _orderRepo.AddOrderMaster();
            if (result == 1)
            {
                return new ApiResponse() { Code = "00", Description = "Order was successfully added." };
            }
            return new ApiResponse() { Code = "96", Description = "System malfunction" };
        }
    }
}
