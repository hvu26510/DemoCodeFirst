using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoCodeFirst.Data;
using DemoCodeFirst.Models;

namespace DemoCodeFirst.Controllers
{
    public class SinhVienDetailsController : Controller
    {
        private readonly QLSVDbContext _context;

        public SinhVienDetailsController(QLSVDbContext context)
        {
            _context = context;
        }

        // GET: SinhVienDetails
        public async Task<IActionResult> Index()
        {
            var qLSVDbContext = _context.sinhVienDetails.Include(s => s.sv);
            return View(await qLSVDbContext.ToListAsync());
        }

        // GET: SinhVienDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhVienDetail = await _context.sinhVienDetails
                .Include(s => s.sv)
                .FirstOrDefaultAsync(m => m.MaSV == id);
            if (sinhVienDetail == null)
            {
                return NotFound();
            }

            return View(sinhVienDetail);
        }

        // GET: SinhVienDetails/Create
        public IActionResult Create()
        {
            ViewData["MaSV"] = new SelectList(_context.sinhViens, "Id", "Id");
            return View();
        }

        // POST: SinhVienDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSV,Info")] SinhVienDetail sinhVienDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinhVienDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaSV"] = new SelectList(_context.sinhViens, "Id", "Id", sinhVienDetail.MaSV);
            return View(sinhVienDetail);
        }

        // GET: SinhVienDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhVienDetail = await _context.sinhVienDetails.FindAsync(id);
            if (sinhVienDetail == null)
            {
                return NotFound();
            }
            ViewData["MaSV"] = new SelectList(_context.sinhViens, "Id", "Id", sinhVienDetail.MaSV);
            return View(sinhVienDetail);
        }

        // POST: SinhVienDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaSV,Info")] SinhVienDetail sinhVienDetail)
        {
            if (id != sinhVienDetail.MaSV)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinhVienDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SinhVienDetailExists(sinhVienDetail.MaSV))
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
            ViewData["MaSV"] = new SelectList(_context.sinhViens, "Id", "Id", sinhVienDetail.MaSV);
            return View(sinhVienDetail);
        }

        // GET: SinhVienDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhVienDetail = await _context.sinhVienDetails
                .Include(s => s.sv)
                .FirstOrDefaultAsync(m => m.MaSV == id);
            if (sinhVienDetail == null)
            {
                return NotFound();
            }

            return View(sinhVienDetail);
        }

        // POST: SinhVienDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sinhVienDetail = await _context.sinhVienDetails.FindAsync(id);
            if (sinhVienDetail != null)
            {
                _context.sinhVienDetails.Remove(sinhVienDetail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SinhVienDetailExists(int id)
        {
            return _context.sinhVienDetails.Any(e => e.MaSV == id);
        }
    }
}
