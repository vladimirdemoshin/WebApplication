using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication.Models
{
    public class MessageEncryptionContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Replace> Replaces { get; set; }
    }
}