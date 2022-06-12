using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAn.Constant;
using WebBanThucAn.Models;
using WebBanThucAn.Models.ViewModels;

namespace WebBanThucAn.Controllers
{
    public class AdminController : Controller  
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private INguoidungSvc _nguoidungSvc;

        public AdminController(IWebHostEnvironment webHostEnvironment, INguoidungSvc nguoidungSvc)
        {
            _webHostEnvironment = webHostEnvironment;
            _nguoidungSvc = nguoidungSvc;
        }

        // GET: AdminController
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            string userName = HttpContext.Session.GetString(SessionKey.NguoiDung.UserName);
            if(userName !=null && userName != "")
            {
                return RedirectToAction("Home", "Index");
            }
            ViewLogin login = new ViewLogin();
            login.ReturnUrl = returnUrl;

            return View(login);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(ViewLogin viewLogin)
        {
            if (ModelState.IsValid)
            {
                Nguoidung nguoidung = _nguoidungSvc.Login(viewLogin);
                if(nguoidung != null)
                {
                    HttpContext.Session.SetString(SessionKey.NguoiDung.UserName, nguoidung.UserName);
                    HttpContext.Session.SetString(SessionKey.NguoiDung.FullName, nguoidung.FullName);
                    HttpContext.Session.SetString(SessionKey.NguoiDung.ID.ToString(), nguoidung.NguoiDungId.ToString());
                    HttpContext.Session.SetString(SessionKey.NguoiDung.NguoiDungContext, JsonConvert.SerializeObject(nguoidung));
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
            }

            return View(viewLogin);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

       
    }
}
