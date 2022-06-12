﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAn.Constant;
using WebBanThucAn.Filters;

namespace WebBanThucAn.Controllers
{
    [AuthenticationFilter]
    public abstract class BaseController : Controller
    {
        public BaseController()
        {
        }
        protected string GetUserName()
        {
            return HttpContext.Session.GetString(SessionKey.NguoiDung.UserName);
        }
        protected string GetFullName()
        {
            return HttpContext.Session.GetString(SessionKey.NguoiDung.FullName);
        }

        protected string GetKHEmail()
        {
            return HttpContext.Session.GetString(SessionKey.KhachHang.KH_Email);
        }

        
    }
}
