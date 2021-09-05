using ApiStock.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStock.Application.Mediator.Query
{
    public class GetProductListQuery : IRequest<IEnumerable<ProductModel>>
    {
    }
}
