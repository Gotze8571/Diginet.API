using Diginet.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Repositories.Interface
{
    public interface IOrderRepo
    {
        Task<int> AddOrder();
        Task<int> AddOrderMaster();
    }
}
