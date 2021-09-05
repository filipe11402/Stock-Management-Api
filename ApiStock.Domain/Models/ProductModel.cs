using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStock.Domain.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int AmountInStock { get; set; }
        public int UnitPrice { get; set; }
    }
}
