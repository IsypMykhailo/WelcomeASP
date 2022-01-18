using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WelcomeASP.Data;

namespace WelcomeASP.Controllers
{
    public class PricingController : Controller
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Реализация DI
        /// Получение в конструктор контекста на базу данных
        /// </summary>
        /// <param name="context"></param>

        public PricingController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Pricing.ToListAsync());
        }
    }
}
