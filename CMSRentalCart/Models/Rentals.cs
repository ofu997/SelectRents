using System;
using System.Collections.Generic;
// This was created for Guid Id
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// I added this one
using Microsoft.EntityFrameworkCore;
// Comment out this one because we don't like the data model
// using CMSRentalCart.Models.ViewModels.Pages;

namespace CMSRentalCart.Models
{
    public class Rentals
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        
    }

    public class RentalsDb : DbContext
    {
        public DbSet<Rentals> Rentals { get; set; }

        // Aaron C's solution
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = CMSRentalCart; Trusted_Connection = True; ConnectRetryCount = 0");
        }

        // comment this one out because we don't like our database
        // public DbSet<CMSRentalCart.Models.ViewModels.Pages.PageVM> PageVM { get; set; }
    }
}
