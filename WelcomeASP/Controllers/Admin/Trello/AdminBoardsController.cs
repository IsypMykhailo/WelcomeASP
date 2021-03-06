using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WelcomeASP.Data;
using WelcomeASP.Data.Entities.trello;

namespace WelcomeASP.Controllers.Admin.Trello
{
    public class AdminBoardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminBoardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminBoards
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boards.Include(b=>b.Tags).ToListAsync());
        }

        // GET: AdminBoards/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Boards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (board == null)
            {
                return NotFound();
            }

            return View(board);
        }

        // GET: AdminBoards/Create
        public IActionResult Create()
        {
            ViewData["TagsId"] = new MultiSelectList(_context.Tags, "Id", "Name");
            ViewBag.TagsAll = _context.Tags;
            return View();
        }

        // POST: AdminBoards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ImgUrl,Logo")] Board board, Guid[] Tags)
        {
            if (Tags != null)
                board.Tags = _context.Tags.Where(t => Tags.Contains(t.Id)).ToList();

            if (ModelState.IsValid)
            {
                board.Id = Guid.NewGuid();
                _context.Add(board);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(board);
        }

        // GET: AdminBoards/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Boards.FindAsync(id);
            if (board == null)
            {
                return NotFound();
            }
            return View(board);
        }

        // POST: AdminBoards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,ImgUrl,Logo")] Board board)
        {
            if (id != board.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(board);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoardExists(board.Id))
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
            return View(board);
        }

        // GET: AdminBoards/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Boards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (board == null)
            {
                return NotFound();
            }

            return View(board);
        }

        // POST: AdminBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var board = await _context.Boards.FindAsync(id);
            _context.Boards.Remove(board);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoardExists(Guid id)
        {
            return _context.Boards.Any(e => e.Id == id);
        }
    }
}
