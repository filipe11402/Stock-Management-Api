using ApiStock.Domain.Abstract;
using ApiStock.Domain.Models;
using ApiStock.Infrastructure.Context;
using ApiStock.Infrastructure.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStock.Infrastructure.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public async Task<ProductModel> Add(ProductModel newProduct)
        {
            if (this._dbContext.Products.FirstOrDefault(token => token.Name.ToLower() == newProduct.Name.ToLower()) != null) 
            {
                return null;
            }

            var dataModel = this._mapper.Map<Product>(newProduct);

            var creationResponse = await this._dbContext.Products.AddAsync(dataModel);

            await this._dbContext.SaveChangesAsync();

            newProduct.Id = dataModel.Id;

            return newProduct;
        }

        public async Task<bool> Delete(string productId)
        {
            var product = await this._dbContext.Products.FirstOrDefaultAsync(token => token.Id == productId);

            if (product == null) 
            {
                return false;
            }

            this._dbContext.Products.Remove(product);

            await this._dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<ProductModel>> FetchAll()
        {
            var products = this._dbContext.Products;

            var productList = this._mapper.Map<IEnumerable<ProductModel>>(products);

            return productList;
        }

        public async Task<ProductModel> FetchProduct(string productId)
        {
            var product = await this._dbContext.Products.FirstOrDefaultAsync(token => token.Id == productId);

            if (product == null) { return null; }

            var productDto = this._mapper.Map<ProductModel>(product);

            return productDto;
        }

        public async Task<bool> Update(ProductModel updatedProduct)
        {
            var product = await this._dbContext.Products.FirstOrDefaultAsync(token => token.Id == updatedProduct.Id);

            if (product == null) { return false; }

            product.Name = updatedProduct.Name;
            product.AmountInStock = updatedProduct.AmountInStock;
            product.UnitPrice = updatedProduct.UnitPrice;

            await this._dbContext.SaveChangesAsync();

            return true;
        }
    }
}
