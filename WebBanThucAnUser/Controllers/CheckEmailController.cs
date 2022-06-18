using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAnUser.Models;

namespace WebBanThucAnUser.Controllers
{
    public class CheckEmailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private DataContext _context;

        public CheckEmailController(
                UserManager<AppUser> userManager,
                DataContext context
          )
        {
            _userManager = userManager;
            _context = context;
        }

        //[HttpPost]
        public IActionResult checkMailExist(string email)
        {

            //var _email = _userManager.FindByEmailAsync(email);
            //var _email = _context.Users.Where(s => s.UserName.ToLower().Contains(email));
            var _email = _context.Users.Any(s => s.UserName.Contains(email));
            if (_email)
            {
                return Json(false);
            }
            

            else
            {
                return Json(true);
            }
            
        }
        [AcceptVerbs("Get", "Post")]
        public JsonResult doesUserNameExist(string Email)
        {

            var user =   _context.Users.Where(s => s.UserName.ToLower().Contains(Email)); 

            return Json(user == null);
        }
    }
}
