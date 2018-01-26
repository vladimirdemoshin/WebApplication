using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Replace
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public char OldSymbol { get; set; }  

        [Required]
        public char NewSymbol { get; set; }
    }
}