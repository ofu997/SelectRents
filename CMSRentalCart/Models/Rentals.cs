using System;
using System.Collections.Generic;
// This was created for Guid Id
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// I added this one
using Microsoft.EntityFrameworkCore;

namespace CMSRentalCart.Models
{
    public class Rentals
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime timeStamp { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
        
    }
    public class RentalsDb : DbContext
    {
        public DbSet<Rentals> Rentals { get; set; }
    }

}
