using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyStuff.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string CustName { get; set; }
        public string Address { get; set; }
        public bool CanCharge { get; set; }

    }
}