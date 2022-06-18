using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBanThucAn.Models;

namespace WebBanThucAn.Controllers
{
    public class NguoiDungController : BaseController
    {
        private readonly DataContext _context;
        private INguoidungSvc _nguoidungSvc;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public NguoiDungController(DataContext context, INguoidungSvc nguoidungSvc, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _nguoidungSvc = nguoidungSvc;
            _webHostEnvironment = webHostEnvironment;
        }




        // GET: NguoiDung
        public IActionResult Index()
        {
            return View(_nguoidungSvc.GetNguoiDungAll());
        }

        // GET: NguoiDung/Details/5
        public IActionResult Details(int id)
        {
            var nguoidung = _nguoidungSvc.GetNguoiDung(id);
            if (nguoidung == null)
            {
                return NotFound();
            }

            return View(nguoidung);
        }

        // GET: NguoiDung/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NguoiDung/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Nguoidung nguoidung)
        {
            if (ModelState.IsValid)
            {
                _nguoidungSvc.AddNguoiDung(nguoidung);
                return RedirectToAction(nameof(Details),new { id = nguoidung.NguoiDungId});
            }
            return View(nguoidung);
        }

        // GET: NguoiDung/Edit/5
        public IActionResult Edit(int id)
        {

            var nguoidung = _nguoidungSvc.GetNguoiDung(id);
            if (nguoidung == null)
            {
                return NotFound();
            }
            return View(nguoidung);
        }

        // POST: NguoiDung/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,Nguoidung nguoidung)
        {
            if (id != nguoidung.NguoiDungId)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _nguoidungSvc.EditNguoiDung(id, nguoidung);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoidungExists(nguoidung.NguoiDungId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details), new { id = nguoidung.NguoiDungId });
            //}
            return View(nguoidung);
        }

        // GET: NguoiDung/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var nguoidung = await _context.NguoiDungs
                .FirstOrDefaultAsync(m => m.NguoiDungId == id && m.IsAdmin == false);
            if (nguoidung == null)
            {
                return NotFound();
            }

            return View(nguoidung);
        }

        // POST: NguoiDung/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nguoidung = await _context.NguoiDungs.FindAsync(id);
            _context.NguoiDungs.Remove(nguoidung);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoidungExists(int id)
        {
            return _context.NguoiDungs.Any(e => e.NguoiDungId == id);
        }
    }
}
