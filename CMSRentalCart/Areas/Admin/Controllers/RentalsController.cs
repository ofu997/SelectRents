using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMSRentalCart.Models;

namespace CMSRentalCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RentalsController : Controller
    {
        private readonly RentalsDb _context;

        /*
        public RentalsController(RentalsDb context)
        {
            _context = context;
        }
        */

        // Aaron C's solution to Rental controller not working
        public RentalsController()
        {
            _context = new RentalsDb();
        }

        // GET: Admin/Rentals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rentals.ToListAsync());
        }

        // GET: Admin/Rentals/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentals = await _context.Rentals
                .SingleOrDefaultAsync(m => m.Id == id);
            if (rentals == null)
            {
                return NotFound();
            }

            return View(rentals);
        }

        // GET: Admin/Rentals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Rentals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TimeStamp,Description,ImagePath")] Rentals rentals)
        {
            if (ModelState.IsValid)
            {
                rentals.Id = Guid.NewGuid();
                _context.Add(rentals);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentals);
        }

        // GET: Admin/Rentals/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentals = await _context.Rentals.SingleOrDefaultAsync(m => m.Id == id);
            if (rentals == null)
            {
                return NotFound();
            }
            return View(rentals);
        }

        // POST: Admin/Rentals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,TimeStamp,Description,ImagePath")] Rentals rentals)
        {
            if (id != rentals.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentals);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalsExists(rentals.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rentals);
        }

        // GET: Admin/Rentals/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentals = await _context.Rentals
                .SingleOrDefaultAsync(m => m.Id == id);
            if (rentals == null)
            {
                return NotFound();
            }

            return View(rentals);
        }

        // POST: Admin/Rentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var rentals = await _context.Rentals.SingleOrDefaultAsync(m => m.Id == id);
            _context.Rentals.Remove(rentals);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalsExists(Guid id)
        {
            return _context.Rentals.Any(e => e.Id == id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // create and send the mail here

            return RedirectToPage("Index");
        }
    }
}
