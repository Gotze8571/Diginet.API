using Diginet.Domain.Helpers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diginet.Domain.Helpers.Concrete
{
    public class Util : IUtil
    {
        public int GetStatusCode(string responseCode)
        {
            int statusCode = 5;
            switch (responseCode)
            {
                case "25":
                    statusCode = 404;
                    break;

                case "26":
                    statusCode = 400;
                    break;

                case "96":
                    statusCode = 500;
                    break;

                case "00":
                    statusCode = 200;
                    break;

                default:
                    statusCode = 200;
                    break;
            }
            return statusCode;
        }
    }
}
