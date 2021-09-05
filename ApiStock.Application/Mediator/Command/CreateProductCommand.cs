using ApiStock.Application.Models.Products;
using ApiStock.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStock.Application.Mediator.Command
{
    public class CreateProductCommand : IRequest<CreateProductViewModel>
    {
        public ProductModel Product { get; }

        public CreateProductCommand(ProductModel product)
        {
            this.Product = product;
        }
    }
}
