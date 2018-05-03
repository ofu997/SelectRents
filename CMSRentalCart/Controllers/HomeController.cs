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

            /*
            SendMail( model)
            {
                // using mimekit
                var message = new MimeMessage();
                // var customerEmail = inputCustomerEmail.Text;
                // read from input
                message.From.Add(new MailboxAddress("Test Project", "fakename81@yahoo.com"));
                message.To.Add(new MailboxAddress("oliver", "OFU997@gmail.com"));
                // read
                message.Subject = "testing";
                // can also use new bodybuilder
                // read
                message.Body = new TextPart("plain") { Text = $"Hello Mars! from {.Name}" };
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    // mail, port, bool
                    // allow different types of mail, maybe
                    client.Connect("smtp.mail.yahoo.com", 465, true);

                    client.Authenticate("fakename81@yahoo.com", "seiseight.");
                    client.Send(message);
                    // Console.WriteLine("Sent");
                    client.Disconnect(true);
                }
                
            }
            */
            return View();
        }

        public void SendMail(string mailbody, ContactFormModel model)
        {
            
            // using mimekit
            var message = new MimeMessage();
            // var customerEmail = inputCustomerEmail.Text;
            // read from input
            message.From.Add(new MailboxAddress($"{model.Name}", "fakename81@yahoo.com"));
            message.To.Add(new MailboxAddress("JT Azul", "azul.pdx@gmail.com"));
            // read
            message.Subject = $"New message from {model.Name}, coming from Select Rents solution project";
            // can also use new bodybuilder
            // read
            message.Body = new TextPart("plain") { Text = $"Hello JT! {model.Message}. Sincerely, {model.Name}{model.LastName}"};
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                // mail, port, bool
                // allow different types of mail, maybe
                client.Connect("smtp.mail.yahoo.com", 465, true);

                client.Authenticate("fakename81@yahoo.com", "Star213@!.");
                client.Send(message);
                Console.WriteLine(model.Name.ToString()+
                " sent at "+ DateTime.Now.ToString());
                client.Disconnect(true);
            }
            // display success page


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

        */

    }
}
