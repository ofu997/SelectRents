using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMSRentalCart.Models;
// added these
using MimeKit;
using MailKit.Net.Smtp;
//using System.Net.Mail.SmtpClient();
using System.Net.Mail;

namespace CMSRentalCart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult EventCanopies()
        {
            ViewData["Message"] = "Your Event Canopies page.";

            return View();
        }

        public IActionResult ThrillMountain()
        {
            ViewData["Message"] = "Your thrill mountain page.";

            return View();
        }
        public IActionResult Reservations()
        {
            ViewData["Message"] = "Your Reservations page.";

            return View();
        }
        public IActionResult Photos()
        {
            ViewData["Message"] = "Your Photos page.";

            return View();
        }
        public IActionResult Rates()
        {
            ViewData["Message"] = "Your Rates page.";

            return View();
        }
        public IActionResult ContactPage()
        {
            ViewData["Message"] = "Your Contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*
        public void SendMail(string mailbody)
        {
            // using mimekit
            var message = new MimeMessage();
            // var customerEmail = inputCustomerEmail.Text;
            message.From.Add(new MailboxAddress("Test Project", "trees73@gmail.com"));
            message.To.Add(new MailboxAddress("oliver", "OFU997@gmail.com"));
            message.Subject = "testing";
            // can also use new bodybuilder
            message.Body = new TextPart("plain"){Text = "Hello Mars!"};
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com",587,false);
                client.Authenticate("trees73@gmail.com","thepassword.");
                client.Send(message);
                client.Disconnect(true);
            }
        }
        */

    }
}
