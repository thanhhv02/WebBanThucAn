using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAn.Helpers;
using WebBanThucAn.Models;
using WebBanThucAn.Models.ViewModels;

namespace WebBanThucAn.Services
{
    public interface IKhachHangSvc
    {
        List<KhachHang> GetKhachHangAll();
        KhachHang GetKhachHang(int khachHangID);
        int AddKhachHang(KhachHang KhachHang);
        int EditKhachHang(int id, KhachHang KhachHang);
        KhachHang Login(ViewWebLogin viewLogin);
    }
    public class KhachHangSvc : IKhachHangSvc
    {
        protected DataContext _context;
        protected IMaHoaHelper _maHoaHelper;

        public KhachHangSvc(DataContext context, IMaHoaHelper maHoaHelper)
        {
            _context = context;
            _maHoaHelper = maHoaHelper;
        }

        public int AddKhachHang(KhachHang KhachHang)
        {
            int ret = 0;
            try
            {
                KhachHang.Password = _maHoaHelper.MaHoa(KhachHang.Password);
                KhachHang.ConfirmPassword = KhachHang.Password;
                _context.Add(KhachHang);
                _context.SaveChanges();
                ret = KhachHang.KhachHangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditKhachHang(int id, KhachHang KhachHang)
        {
            int ret = 0;
            try
            {
                KhachHang _khachHang = null;
                _khachHang = _context.KhachHangs.Find(id);
                _khachHang.FullName = KhachHang.FullName;
                _khachHang.NgaySinh = KhachHang.NgaySinh;
                _khachHang.PhoneNumber = KhachHang.PhoneNumber;
                _khachHang.Email = KhachHang.Email;
                if (_khachHang.Password != null)
                {
                    KhachHang.Password = _maHoaHelper.MaHoa(KhachHang.Password);
                    _khachHang.Password = KhachHang.Password;
                    _khachHang.ConfirmPassword = KhachHang.Password;
                }
                _khachHang.Mota = KhachHang.Mota;
                _context.Update(_khachHang);
                _context.SaveChanges();
                ret = _khachHang.KhachHangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public KhachHang GetKhachHang(int khachHangID)
        {
            return _context.KhachHangs.Find(khachHangID);
        }

        public List<KhachHang> GetKhachHangAll()
        {
            return _context.KhachHangs.ToList();
        }

        public KhachHang Login(ViewWebLogin viewLogin)
        {
            return _context.KhachHangs.Where(p => p.Email.Equals(viewLogin.Email) && p.Password.Equals(_maHoaHelper.MaHoa(viewLogin.Password))).FirstOrDefault();
        }
    }
}
