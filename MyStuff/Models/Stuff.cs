using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyStuff.Models
{
    public class Stuff
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Desc { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}