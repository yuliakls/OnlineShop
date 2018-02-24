using MVC5_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_PROJECT.ModelView
{
    public class CustomerViewModel
    {

        public Customer Cust { get; set; }

        public List<Customer> Cust_List { get; set; }

    }
}