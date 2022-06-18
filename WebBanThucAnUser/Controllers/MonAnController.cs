using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAnUser.Models;
using WebBanThucAnUser.Services;

namespace WebBanThucAnUser.Controllers
{
    public class MonAnController : Controller
    {
        private readonly DataContext _context;
        private readonly CartService _cartService;
        public MonAnController(DataContext context, CartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        // GET: MonAn
        public async Task<IActionResult> Index()
        {
            return View(await _context.MonAns.Where(x => x.TrangThai == true).Include(p => p.Photos).ToListAsync());
        }

        // GET: MonAn/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monAn = await _context.MonAns.Where(x=>x.TrangThai == true).Include(p=>p.Photos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monAn == null)
            {
                return NotFound();
            }

            return View(monAn);
        }

        private bool MonAnExists(int id)
        {
            return _context.MonAns.Any(e => e.Id == id);
        }
        /// Thêm sản phẩm vào cart
        [Route("addcart/{productid:int}")]
        public IActionResult AddToCart([FromRoute] int productid, int quantity)
        {
            if (quantity <= 0)
            {
                quantity = 1;
            }
            
            var product = _context.MonAns
                            .Where(p => p.Id == productid && p.TrangThai == true)
                           
                            .FirstOrDefault();
            if (product == null)
                return NotFound("Không có sản phẩm");
            if (quantity > product.Quantity)
            {
                quantity = product.Quantity;
            }

                // Xử lý đưa vào Cart ...
                var cart = _cartService.GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == productid);
            if (cartitem != null)
            {
                
                cartitem.quantity += quantity;
                if (cartitem.quantity > cartitem.product.Quantity)
                {
                    cartitem.quantity = cartitem.product.Quantity;
                }
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { quantity = quantity, product = product });
            }
            //product.Quantity -= quantity;
            //_context.Update(product);
            //_context.SaveChanges();
            // Lưu cart vào Session
            _cartService.SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Cart));
        }
        [HttpPost]
        public IActionResult AddToCartPost([FromForm] int productid)
        {
            
            var product = _context.MonAns
                            .Where(p => p.Id == productid && p.TrangThai == true)
                            
                            .FirstOrDefault();
            if (product == null)
                return NotFound("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = _cartService.GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity++;
                if (cartitem.quantity > cartitem.product.Quantity)
                {
                    cartitem.quantity = cartitem.product.Quantity;
                }
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { quantity = 1, product = product });
            }
            //product.Quantity -= 1;
            //_context.Update(product);
            //_context.SaveChanges();
            // Lưu cart vào Session
            _cartService.SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return Ok();
        }
        /// xóa item trong cart
        [Route("/removecart/{productid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int productid)
        {
            var cart = _cartService.GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartitem);
            }
            //cartitem.product.Quantity += cartitem.quantity;
            //_context.Update(cartitem.product);
            //_context.SaveChanges();
            _cartService.SaveCartSession(cart);
            // Xử lý xóa một mục của Cart ...
            return RedirectToAction(nameof(Cart));
        }

        /// Cập nhật
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int productid, [FromForm] int quantity)
        {

            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = _cartService.GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == productid);
            if(quantity > cartitem.product.Quantity)
            {
                quantity = cartitem.product.Quantity;
            }
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity = quantity;
            }
            //MonAn monAn = new MonAn();
            //monAn.Quantity -= quantity;
            //_context.Update(monAn);
            //_context.SaveChanges();
            _cartService.SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return RedirectToAction(nameof(Cart)); 
        }


        // Hiện thị giỏ hàng
        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View(_cartService.GetCartItems());
        }

        [Route("/checkout")]
        public IActionResult CheckOut()
        {
            _cartService.GetCartItems();
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(string diachi)
        {
            _cartService.ClearCart();
            return View();
        }
        [HttpPost]
        public IActionResult Search(string search)
        {
            if (!string.IsNullOrWhiteSpace(search) && string.IsNullOrEmpty(search))
                
            return View(_context.MonAns
                            .Where(p => p.Name.ToLower().Contains(search.ToLower()) && p.TrangThai == true)
                            
                            .ToList());

            else
            {
                MonAn monAn = new MonAn();
                monAn = null;
                return View(monAn);
            }
                
        }

    }
}