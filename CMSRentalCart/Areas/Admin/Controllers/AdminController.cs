// NOTE: THIS IS NOT IN COURSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CMSRentalCart.Areas.Admin.Controllers { 
    
    [Area("Admin")]
	[Route("admin")]
    
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
