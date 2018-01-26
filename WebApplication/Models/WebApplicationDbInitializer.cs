using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication.Models
{
    public class WebApplicationDbInitializer : DropCreateDatabaseAlways<MessageEncryptionContext>
    {
        protected override void Seed(MessageEncryptionContext context)
        {
            context.Messages.Add(new Message { Text = "Привет", ReceivingTime = DateTime.Now });
            context.Messages.Add(new Message { Text = "Hello", ReceivingTime = DateTime.Now });
            context.Messages.Add(new Message { Text = "123", ReceivingTime = DateTime.Now });

            base.Seed(context);
        }
    }
}