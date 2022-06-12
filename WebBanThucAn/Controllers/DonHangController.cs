using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAn.Models;
using WebBanThucAn.Services;

namespace WebBanThucAn.Controllers
{
    public class DonHangController : BaseController
    {
        private IDonHangSvc _donHangSvc;

        public DonHangController(IDonHangSvc donHangSvc)
        {
            _donHangSvc = donHangSvc;
        }

        public ActionResult Index()
        {
            return View(_donHangSvc.GetDonHangAll());
        }

        // GET: DonHangController/Details/5
        public ActionResult Details(int id)
        {
            return View(_donHangSvc.GetDonHang(id));
        }

        // GET: DonHangController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonHangController/Create
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

        // GET: DonHangController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_donHangSvc.GetDonHang(id));
        }

        // POST: DonHangController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DonHang donHang)
        {
            try
            {
                donHang.KhachHang = null;
                _donHangSvc.EditDonHang(id, donHang);
                return RedirectToAction(nameof(Details), new{id = donHang.DonHangID});
            }
            catch
            {
                return View();
            }
        }

        // GET: DonHangController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DonHangController/Delete/5
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
