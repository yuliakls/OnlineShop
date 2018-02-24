using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_PROJECT.Models
{
    public class User
    {
        [Key]
        [Required]
        [RegularExpression("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Wrong email, please check again")] 
        public string Email { get; set; }
        [Required]
        public string PW { get; set; }
        public bool Manager { get; set; }

    }
}