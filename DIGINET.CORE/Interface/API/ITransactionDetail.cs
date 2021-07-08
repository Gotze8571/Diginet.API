using DIGINET.CORE.Entity;
using DIGINET.CORE.Model.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGINET.CORE.Interface.API
{
    public interface ITransactionDetail
    {
        Task<TransactionDetail> GetTransactionDetails();
        Task<TransactionDetail> CreateTransactionDetails(CreateTransactionRequest param);
        Task<bool, string> SaveTransactionDetails(CreateTransactionRequest param);
    }
}
