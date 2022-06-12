﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanThucAn.Constant
{
    public class SessionKey
    {
        public static class NguoiDung
        {
            public const string UserName = "UserName";
            public const string FullName = "FullName";
            public const string Valid = "Valid";
            public const string NguoiDungContext = "NguoiDungContext";
            public static int ID = 0;
        }
        public static class KhachHang
        {
            public const string KH_Email = "KH_Email";
            public const string KH_FullName = "KH_FullName";
        }
    }
}
