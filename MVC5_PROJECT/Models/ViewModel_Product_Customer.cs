using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_PROJECT.Models
{
    public class ViewModel_Product_Customer
    {
        public Product prod { get; set; }
        public Customer cust { get; set; }

        public ViewModel_Product_Customer(Product P, Customer C)
        {
            prod = P;
            cust = C;
        }


        public List<string> Menu
        {
            get {

                List<string> temp = new List<string>();
                temp.Add("Main");
                temp.Add("page2");
                temp.Add("page3");
                temp.Add("page4");
                return temp;
                }
        }


    }
}