using ApiStock.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStock.Application.Mediator.Command
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public ProductModel Product { get; }

        public UpdateProductCommand(ProductModel product)
        {
            this.Product = product;
        }
    }
}
