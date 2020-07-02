using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_app.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Name")]
        [StringLength(10)]
        [Required(ErrorMessage = "Name should contain at least 4 characters")]
        public string name { get; set; }

        [Display(Name = "Surname")]
        [StringLength(10)]
        [Required(ErrorMessage = "Surname should contain at least 4 characters")]
        public string surname { get; set; }

        [Display(Name = "Address")]
        [StringLength(20)]
        [Required(ErrorMessage = "Address should contain at least 8 characters")]
        public string address { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number should contain at least 7 numbers")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [StringLength(25)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Address should contain at least 5 characters")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; } 

        public List<OrderDetail> orderDetails { get; set; }
    }
}
