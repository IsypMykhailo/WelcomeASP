using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WelcomeASP.Data;
using WelcomeASP.Data.Entities;

namespace WelcomeASP.Controllers.Admin
{
    public class AdminPricingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminPricingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminPricings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pricing.ToListAsync());
        }

        // GET: AdminPricings/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricing = await _context.Pricing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pricing == null)
            {
                return NotFound();
            }

            return View(pricing);
        }

        // GET: AdminPricings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminPricings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Product,Price")] Pricing pricing)
        {
            if (ModelState.IsValid)
            {
                pricing.Id = Guid.NewGuid();
                _context.Add(pricing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pricing);
        }

        // GET: AdminPricings/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricing = await _context.Pricing.FindAsync(id);
            if (pricing == null)
            {
                return NotFound();
            }
            return View(pricing);
        }

        // POST: AdminPricings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Product,Price")] Pricing pricing)
        {
            if (id != pricing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pricing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PricingExists(pricing.Id))
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
            return View(pricing);
        }

        // GET: AdminPricings/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricing = await _context.Pricing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pricing == null)
            {
                return NotFound();
            }

            return View(pricing);
        }

        // POST: AdminPricings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pricing = await _context.Pricing.FindAsync(id);
            _context.Pricing.Remove(pricing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PricingExists(Guid id)
        {
            return _context.Pricing.Any(e => e.Id == id);
        }
    }
}
