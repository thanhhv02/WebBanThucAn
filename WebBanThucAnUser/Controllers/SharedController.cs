using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanThucAnUser.Controllers
{
    public class SharedController : Controller
    {
        [HttpGet]
        public PartialViewResult RefreshLoginPartial()
        {
            // do something

            return PartialView("_Header");
        }
    }
}
