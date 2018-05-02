/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// added this one
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CMSRentalCart.Models
{
    public class Contact
    {
    }

    public class ContactFormModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        [BindProperty]
        public ContactFormModel Contact { get; set; }

        var mailbody = $@"Hallo website owner,

            This is a new contact request from your website:

            Name: {Contact.Name}
            LastName: {Contact.LastName}
            Email: {Contact.Email}
            Message: ""{Contact.Message}""


            Cheers,
            The websites contact form";

        SendMail(mailbody);
    }
}
*/