using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// added this one
using CMSRentalCart.Models.Data;
// added this one
using CMSRentalCart.Models.ViewModels.Pages;
using Microsoft.AspNetCore.Mvc;

namespace CMSRentalCart.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            // Declare list of PagesVM
            List<PageVM> pagesList;

            // Initialize the list
            using (Db db = new Db())
            {
                pagesList = db.Pages.ToArray().OrderBy( x => x.Sorting).Select( x => new PageVM(x)).ToList();
            }

                // Return view with list
                return View();
        }
    }
}