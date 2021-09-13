using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMovies.DL.Entity
{
    public class Products
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Sku { get; set; }
        public Categories Categories { get; set; }
    }

}
