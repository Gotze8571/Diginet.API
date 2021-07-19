using DIGINET.CORE.Model.DTO.Model;
using DIGINET.CORE.Model.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGINET.CORE.Services.Interface
{
    public interface IAddOrder
    {
        Task<ApiResponse> AddOrder(OrderDto dto);
    }
}
