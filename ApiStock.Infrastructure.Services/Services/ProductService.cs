using ApiStock.Domain.Abstract;
using ApiStock.Domain.Models;
using ApiStock.Infrastructure.Context;
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

        public ProductService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Task<ProductModel> Add(ProductModel newProduct)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> FetchProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ProductModel updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
