using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// added this
using Microsoft.EntityFrameworkCore;

namespace CMSRentalCart.Models.Data
{

    public class Db : DbContext
    {
        public DbSet<PageDTO> Pages{get;set;}
    }
}
