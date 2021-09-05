using ApiStock.Application.Mediator.Query;
using ApiStock.Domain.Abstract;
using ApiStock.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiStock.Application.Mediator.Handler
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, IEnumerable<ProductModel>>
    {
        private readonly IProductService _productService;

        public GetProductListQueryHandler(IProductService productService)
        {
            this._productService = productService;
        }

        public async Task<IEnumerable<ProductModel>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return await this._productService.FetchAll();
        }
    }
}
