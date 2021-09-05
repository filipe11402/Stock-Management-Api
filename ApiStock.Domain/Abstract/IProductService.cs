using ApiStock.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStock.Domain.Abstract
{
    public interface IProductService
    {
        Task<ProductModel> Add(ProductModel newProduct);
        Task<bool> Update(ProductModel updatedProduct);
        Task<bool> Delete(int productId);
        Task<ProductModel> FetchProduct(int productId);
    }
}
