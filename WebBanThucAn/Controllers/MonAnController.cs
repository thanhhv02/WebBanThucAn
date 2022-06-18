using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private DataContext _context;
        public const int ITEM_PER_PAGE = 3;
        [BindProperty(SupportsGet = true,Name ="p")]
        public static int currentPage { get; set; }
        public static int countPage { get; set; }
        public MonAnController(IWebHostEnvironment webHostEnvironment, IMonAnSvc monAnSvc, IUploadHeper uploadHeper, DataContext dataContext)
        {
            this._webHostEnvironment = webHostEnvironment;
            _monAnSvc = monAnSvc;
            _uploadHelper = uploadHeper;
            _context = dataContext;
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
                
                //if (monAn.ImageFile != null)
                //{
                //    if (monAn.ImageFile.Length > 0)
                //    {
                //        string rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                //        _uploadHelper.UploadImage(monAn.ImageFile, rootPath, "MonAn");
                //        monAn.Hinh = monAn.ImageFile.FileName;
                //    }
                //}
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
                    //if (monAn.ImageFile != null)
                    //{
                    //    if (monAn.ImageFile.Length > 0)
                    //    {
                    //        string rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    //        _uploadHelper.DeleteImage(rootPath + thumuccon + monAn.Hinh);
                    //        _uploadHelper.UploadImage(monAn.ImageFile, rootPath, thumuccon);
                    //        monAn.Hinh = monAn.ImageFile.FileName;
                    //    }
                    //}
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
        [HttpPost]
        public IActionResult ListPhotos(int id)
        {
            var product = _context.MonAns.Where(e => e.Id == id)
                .Include(p => p.Photos).FirstOrDefault();

            if(product == null)
            {
                return Json(
                    new
                    {
                        succes = 0,
                        message = "Product not found"
                    }
                    ) ;
            }

            var listphotos = product.Photos.Select(photo => new
            {
                id = photo.Id,
                path = "/images/MonAn/" + photo.FileName
            });
            return Json(
                new
                {
                    success = 1,
                    photos = listphotos
                });
        }
        [HttpPost]
        public IActionResult DeletePhoto(int id)
        {
            var photo = _context.ProductPhotos.Where(p => p.Id == id).FirstOrDefault();
            if (photo != null)
            {
                _context.Remove(photo);
                _context.SaveChanges();

                var filename = "wwwroot/images/MonAn/" + photo.FileName;
                System.IO.File.Delete(filename);
            }
            return Ok();
        }
        public class UploadOneFile
        {
            [Required(ErrorMessage = "Phải chọn file upload")]
            [DataType(DataType.Upload)]
            [FileExtensions(Extensions = "png,jpg,jpeg,gif")]
            [Display(Name = "Chọn file upload")]
            public IFormFile FileUpload { get; set; }
        }
        [HttpPost]
        public async Task<IActionResult> UploadPhotoApi(int id, [Bind("FileUpload")] UploadOneFile f)
        {
            var product = _context.MonAns.Where(e => e.Id == id)
                .Include(p => p.Photos)
                .FirstOrDefault();
            
            if (product == null)
            {
                return NotFound("Không có sản phẩm");
            }


            if (f != null)
            {
                var file1 = Path.GetFileNameWithoutExtension(Path.GetRandomFileName())
                            + Path.GetExtension(f.FileUpload.FileName);

                var file = Path.Combine(_webHostEnvironment.WebRootPath, "images", "MonAn", file1);

                using (var filestream = new FileStream(file, FileMode.Create))
                {
                    await f.FileUpload.CopyToAsync(filestream);
                }

                _context.Add(new ProductPhoto()
                {
                    ProductId = product.Id,
                    FileName = file1
                });

                await _context.SaveChangesAsync();
            }


            return Ok();
        }

    }
}
