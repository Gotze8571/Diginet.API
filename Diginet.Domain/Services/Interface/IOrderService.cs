using Diginet.Domain.Models.API;
using Diginet.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Services.Interface
{
    public interface IOrderService
    {
        Task<ApiResponse> GetOrder(OrderDto dto);
        Task<ApiResponse> GetOrderMaster(OrderMasterDto dto);
    }
}
