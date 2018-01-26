using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        MessageEncryptionContext context = new MessageEncryptionContext();
        public ActionResult Index()
        {
            // take from db all message objects
            IEnumerable<Message> messages = context.Messages;
            // send all objects to dynamic property Messages in ViewBag
            ViewBag.Messages = messages;
            return View();
        }

        [HttpPost]
        public ActionResult Send(Message message)
        {
            message.ReceivingTime = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            IEnumerable<Message> messages = context.Messages;
            ViewBag.Messages = messages;
            return View("Index");
        }
     
    }
}