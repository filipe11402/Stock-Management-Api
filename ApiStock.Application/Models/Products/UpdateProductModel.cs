using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStock.Application.Models.Products
{
    public class UpdateProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int AmountInStock { get; set; }
        public int UnitPrice { get; set; }
    }
}
