using Diginet.Domain.Models.DTOs.Concrete;
using Diginet.Domain.Repositories.Interface;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Repositories.Concrete
{
    public class OrderRepository : IOrderRepo
    {
        private readonly AppSettings _settings;
        private readonly IDbConnection _dbConnection;
        public OrderRepository(IOptions<AppSettings> settings)
        {
            //_dbConnection = dbConnection;
            _settings = settings.Value;
        }
        public  Task<int> AddOrder()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddOrderMaster()
        {
            throw new NotImplementedException();
        }
    }
}
