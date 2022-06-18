using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAn.Services;

namespace WebBanThucAn.Controllers
{
    public class KhachHangController : BaseController
    {
        private IKhachHangSvc _khachHangSvc;
        public KhachHangController(IKhachHangSvc khachHangSvc)
        {
            _khachHangSvc = khachHangSvc;
        }

        // GET: KhachHangController
        public ActionResult Index()
        {
            return View(_khachHangSvc.GetKhachHangAll());
        }

        // GET: KhachHangController/Details/5
        public ActionResult Details(string id)
        {
            var nguoidung = _khachHangSvc.GetKhachHang(id);
            if (nguoidung == null)
            {
                return NotFound();
            }

            return View(nguoidung);
        }

        // GET: KhachHangController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHangController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KhachHangController/Edit/5
        public ActionResult Edit(string id)
        {
            var khachHang = _khachHangSvc.GetKhachHang(id);
            return View(khachHang);
        }

        // POST: KhachHangController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, AppUser khachHang)
        {
            if (id != khachHang.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
            try
            {
                _khachHangSvc.EditKhachHang(id, khachHang);
            }
            catch 
            {
                
            }
            return RedirectToAction(nameof(Details), new { id = khachHang.Id });
            //}
        }

        // GET: KhachHangController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KhachHangController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
