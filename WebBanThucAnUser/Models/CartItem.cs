using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanThucAnUser.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public MonAn product { set; get; }
    }
}
