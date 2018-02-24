using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_PROJECT.Models
{
    public class Manufacturer
    {
        [Key]
        public string Name { get; set; }
        public string Phone { get; set; }

    }
}