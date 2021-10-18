using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLBH.Data;
using QLBH.Models;

namespace QLBH.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly QLBHContext _context;

        public KhachHangController(QLBHContext context)
        {
            _context = context;
        }

        // GET: KhachHang
        public async Task<IActionResult> Index()
        {
            return View(await _context.KhachHangs.ToListAsync());
        }

        // GET: KhachHang/Details/5
        public async Task<IActionResult> Details(int? MaKH)
        {
            if (MaKH == null)
            {
                return NotFound();
            }

            var KhachHang = await _context.KhachHangs
                .FirstOrDefaultAsync(m => m.MaKH == MaKH);
            if (KhachHang == null)
            {
                return NotFound();
            }

            return View(KhachHang);
        }

        // GET: KhachHang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhachHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaKH,HoTenKH,DiaChi,DienThoai")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khachHang);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? MaKH)
        {
            if (MaKH == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHangs.FindAsync(MaKH);
            if (MaKH == null)
            {
                return NotFound();
            }
            return View(MaKH);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int MaKH, [Bind("MaKH,HoTenKH,DiaChi,DienThoai")] KhachHang khachHang)
        {
            if (MaKH != khachHang.MaKH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangExists(khachHang.MaKH))
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
            return View(khachHang);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? MaKH)
        {
            if (MaKH == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHangs
                .FirstOrDefaultAsync(m => m.MaKH == MaKH);
            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int MaKH)
        {
            var khachHang = await _context.KhachHangs.FindAsync(MaKH);
            _context.KhachHangs.Remove(khachHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachHangExists(int MaKH)
        {
            return _context.KhachHangs.Any(e => e.MaKH == MaKH);
        }
    }
}
