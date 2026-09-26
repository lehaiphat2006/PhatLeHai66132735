using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using web_csdlbanhang.Data;
using web_csdlbanhang.Models;

namespace web_csdlbanhang.Controllers
{
    public class DonViTinhsController : Controller
    {
        private readonly AppDbContext _context;

        public DonViTinhsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DonViTinhs
        public async Task<IActionResult> Index()
        {
            return View(_context.DonViTinh_DS());
        }

        // GET: DonViTinhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donViTinh = await _context.DonViTinhs
                .FirstOrDefaultAsync(m => m.MaDVT == id);
            if (donViTinh == null)
            {
                return NotFound();
            }

            return View(donViTinh);
        }

        // GET: DonViTinhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DonViTinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDVT,TenDVT")] DonViTinh donViTinh)
        {
            if (ModelState.IsValid)
            {
               
                 _context.DonViTinh_Them(donViTinh);
                return RedirectToAction(nameof(Index));
            }
            return View(donViTinh);
        }

        // GET: DonViTinhs/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donViTinh = await _context.DonViTinhs.FindAsync(id);//neu bao sai cho nay thi vao Model-->DonViTinh.cs de sua .
            if (donViTinh == null)
            {
                return NotFound();
            }
            return View(donViTinh);
        }

        // POST: DonViTinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("MaDVT,TenDVT")] DonViTinh donViTinh)
        {
            if (id != donViTinh.MaDVT)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.DonViTinh_Sua(donViTinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonViTinhExists(donViTinh.MaDVT))
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
            return View(donViTinh);
        }

        // GET: DonViTinhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donViTinh = await _context.DonViTinhs
                .FirstOrDefaultAsync(m => m.MaDVT == id);
            if (donViTinh == null)
            {
                return NotFound();
            }

            return View(donViTinh);
        }

        // POST: DonViTinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donViTinh = await _context.DonViTinhs.FindAsync(id);
            if (donViTinh != null)
            {
                _context.DonViTinhs.Remove(donViTinh);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonViTinhExists(int id)
        {
            return _context.DonViTinhs.Any(e => e.MaDVT == id);
        }
    }
}
