using DIGINET.CORE.Model.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGINET.CORE.Interface.API
{
    public interface IOrderAPISvc
    {
        Task<int> SaveNewOrder(OrderRequest param);
        Task<List<FetchOrderRequest>> GetOrder();
    }
}
