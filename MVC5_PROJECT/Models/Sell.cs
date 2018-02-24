using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_PROJECT.Models
{
    public class Sell
    {
        [Required]
        public int Product_ID{ get; set; }
        [Required]
        public int Customer_ID { get; set; }
        [Required]
        public double Price { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int PurchaseID{ get; set; }
    }
}