using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMovies.Commons.Model
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; } 
        public dynamic Sku { get; set; } 
    }
}
