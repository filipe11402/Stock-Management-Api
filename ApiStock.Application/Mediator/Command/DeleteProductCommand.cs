using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStock.Application.Mediator.Command
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public string ProductId { get; }

        public DeleteProductCommand(string productId)
        {
            this.ProductId = productId;
        }
    }
}
