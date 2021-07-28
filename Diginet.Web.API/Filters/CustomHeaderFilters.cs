using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diginet.Web.API.Filters
{
    public class CustomHeaderFilters
    {
        public class AddRequiredHeaderParameter : IOperationFilter
        {
            public void Apply(OpenApiOperation operation, OperationFilterContext context)
            {
                if (operation.Parameters == null)
                    operation.Parameters = new List<OpenApiParameter>();

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "x-correlation-id",
                    In = ParameterLocation.Header,
                    Required = false,
                    Description = "Correlation Id"
                });

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "client_id",
                    In = ParameterLocation.Header,
                    Required = false,
                    Description = "Client Identifier (Required)"
                });
            }
        }
           
    }
}
