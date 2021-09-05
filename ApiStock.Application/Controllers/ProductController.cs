using ApiStock.Application.Mediator.Command;
using ApiStock.Application.Mediator.Query;
using ApiStock.Application.Models.Products;
using ApiStock.Domain.Abstract;
using ApiStock.Domain.Models;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStock.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProductController(
            IProductService productService,
            IMediator mediator,
            IMapper mapper)
        {
            this._productService = productService;
            this._mediator = mediator;
            this._mapper = mapper;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductModel viewModel)
        {
            var requestModel = this._mapper.Map<ProductModel>(viewModel);

            var returnModel = await this._mediator.Send(new CreateProductCommand(requestModel));

            if (returnModel == null) 
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

            return StatusCode(StatusCodes.Status201Created, returnModel);
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetProducts()
        {
            var productList = await this._mediator.Send(new GetProductListQuery());

            var viewModel = this._mapper.Map<IEnumerable<ProductViewModel>>(productList);

            return StatusCode(StatusCodes.Status200OK, viewModel);
        }
    }
}
