using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMovies.DL.Entity
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<Products> products { get; set; }

    }
}
