using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_PROJECT.Models
{
    public class Customer
    {
        [Key]
        [Required]
        [RegularExpression("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$",ErrorMessage ="Wrong email, please check again")]         // [RegularExpression("^[0-9]{4}$")]   
        public string Email { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 4,ErrorMessage ="Password length should be 4-15 characters")]
        public string PW { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name should be 2-30 characters")]
        public string FName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Last name should be 2-30 characters")]
        public string LName { get; set; }
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID{ get; set; }

        /*
                [Required]
                public string ZipCode { get; set; }

                [Required]

                public string Country { get; set; }

                [Required]
                [StringLength(30, MinimumLength = 2)]
                public string City { get; set; }

                [Required]
                [StringLength(30, MinimumLength = 2)]
                public string Street { get; set; }

                [Required]
                public string HouseNum { get; set; }

                public string ApartmentNum { get; set; }

                [Required]
                //[RegularExpression("^[0-9]{3}-[0-9]{7}$",ErrorMessage ="")]
                public string Phone { get; set; }

                public string Phone2 { get; set; }


                */

    }
}