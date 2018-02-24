using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_PROJECT.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID{ get; set; }

        //public string Category { get; set; }
        [Key]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Manufacturer { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double Supplier_Price { get; set; }

        public string Pic_URL { get; set; }

        

      


    }
}