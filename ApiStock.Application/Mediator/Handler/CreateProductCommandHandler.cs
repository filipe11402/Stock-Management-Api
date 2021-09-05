using ApiStock.Application.Mediator.Command;
using ApiStock.Application.Models.Products;
using ApiStock.Domain.Abstract;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ApiStock.Application.Mediator.Handler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public CreateProductCommandHandler(IMapper mapper, IProductService productService)
        {
            this._mapper = mapper;
            this._productService = productService;
        }

        public async Task<CreateProductViewModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var creationResponse = await this._productService.Add(request.Product);

            var viewModel = this._mapper.Map<CreateProductViewModel>(creationResponse);

            return viewModel;
        }
    }
}
