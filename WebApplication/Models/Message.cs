using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication.Models
{
    //original not encrypted message
    public class Message
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        // text of the message
        [Required, MaxLength(50)]
        public string Text { get; set; }

        //time of the message receiving
        [Required]
        public DateTime ReceivingTime { get; set; }
    }
}