using MVC5_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_PROJECT.ModelView
{
    public class ProductViewModel
    {
        public Product Prod { get; set; }

        public List<Product> Prod_List { get; set; }

    }
}