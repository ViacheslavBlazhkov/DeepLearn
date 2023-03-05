using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeepLearn.Data;
using DeepLearn.Models;

namespace DeepLearn.Controllers
{
    public class TheoryBlocksController : Controller
    {
        private readonly DeepLearnContext _context;

        public TheoryBlocksController(DeepLearnContext context)
        {
            _context = context;
        }

        // GET: TheoryBlocks
        public async Task<IActionResult> Index()
        {
              return _context.TheoryBlock != null ? 
                          View(await _context.TheoryBlock.ToListAsync()) :
                          Problem("Entity set 'DeepLearnContext.TheoryBlock'  is null.");
        }

        // GET: TheoryBlocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TheoryBlock == null)
            {
                return NotFound();
            }

            var theoryBlock = await _context.TheoryBlock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theoryBlock == null)
            {
                return NotFound();
            }

            return View(theoryBlock);
        }

        // GET: TheoryBlocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TheoryBlocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Status,LessonId")] TheoryBlock theoryBlock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theoryBlock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theoryBlock);
        }

        // GET: TheoryBlocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TheoryBlock == null)
            {
                return NotFound();
            }

            var theoryBlock = await _context.TheoryBlock.FindAsync(id);
            if (theoryBlock == null)
            {
                return NotFound();
            }
            return View(theoryBlock);
        }

        // POST: TheoryBlocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Status,LessonId")] TheoryBlock theoryBlock)
        {
            if (id != theoryBlock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theoryBlock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheoryBlockExists(theoryBlock.Id))
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
            return View(theoryBlock);
        }

        // GET: TheoryBlocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TheoryBlock == null)
            {
                return NotFound();
            }

            var theoryBlock = await _context.TheoryBlock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theoryBlock == null)
            {
                return NotFound();
            }

            return View(theoryBlock);
        }

        // POST: TheoryBlocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TheoryBlock == null)
            {
                return Problem("Entity set 'DeepLearnContext.TheoryBlock'  is null.");
            }
            var theoryBlock = await _context.TheoryBlock.FindAsync(id);
            if (theoryBlock != null)
            {
                _context.TheoryBlock.Remove(theoryBlock);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TheoryBlockExists(int id)
        {
          return (_context.TheoryBlock?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
