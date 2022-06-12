using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAn.Helpers;
using WebBanThucAn.Interface;
using WebBanThucAn.Models;
using WebBanThucAn.Services;

namespace WebBanThucAn.Controllers
{
    public class MonAnController : BaseController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private IMonAnSvc _monAnSvc;
        private IUploadHeper _uploadHelper;
        public const int ITEM_PER_PAGE = 3;
        [BindProperty(SupportsGet = true,Name ="p")]
        public static int currentPage { get; set; }
        public static int countPage { get; set; }
        public MonAnController(IWebHostEnvironment webHostEnvironment, IMonAnSvc monAnSvc, IUploadHeper uploadHeper)
        {
            this._webHostEnvironment = webHostEnvironment;
            _monAnSvc = monAnSvc;
            _uploadHelper = uploadHeper;
        }

        // GET: MonAnController
        public ActionResult Index()
        {
            //int totalMonAn = _monAnSvc.GetMonAnAll().Count;
            //countPage =(int) Math.Ceiling((double)totalMonAn / ITEM_PER_PAGE);
            //if (currentPage < 1)
            //    currentPage = 1;
            //if (currentPage > countPage)
            //    currentPage = countPage;
            return View(_monAnSvc.GetMonAnAll());
        }

        // GET: MonAnController/Details/5
        public ActionResult Details(int id)
        {
            var monAn = _monAnSvc.GetMonAn(id);
            return View(monAn);
        }

        // GET: MonAnController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonAnController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MonAn monAn)
        {
            try
            {
                
                if (monAn.ImageFile != null)
                {
                    if (monAn.ImageFile.Length > 0)
                    {
                        string rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                        _uploadHelper.UploadImage(monAn.ImageFile, rootPath, "MonAn");
                        monAn.Hinh = monAn.ImageFile.FileName;
                    }
                }
                _monAnSvc.AddMonAn(monAn);
                return RedirectToAction(nameof(Details), new { id = monAn.Id });
            }
            catch
            {
                return View();
            }

        }

        // GET: MonAnController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var monAn = _monAnSvc.GetMonAn(id);
            return View(monAn);
        }

        // POST: MonAnController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MonAn monAn)
        {
            if (id != monAn.Id)
            {
                return NotFound();
            }
            string thumuccon = "MonAn";
            try
            {
                //if (ModelState.IsValid)
                //{
                    if (monAn.ImageFile != null)
                    {
                        if (monAn.ImageFile.Length > 0)
                        {
                            string rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                            _uploadHelper.DeleteImage(rootPath + thumuccon + monAn.Hinh);
                            _uploadHelper.UploadImage(monAn.ImageFile, rootPath, thumuccon);
                            monAn.Hinh = monAn.ImageFile.FileName;
                        }
                    }
                    _monAnSvc.EditMonAn(id, monAn);
                    return RedirectToAction(nameof(Details), new { id = monAn.Id });
                //}
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));

        }

        // GET: MonAnController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonAnController/Delete/5
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
