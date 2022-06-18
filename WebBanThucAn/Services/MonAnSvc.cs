using System.Collections.Generic;
using System.Linq;
using WebBanThucAn.Models;
using Microsoft.EntityFrameworkCore;

namespace WebBanThucAn.Services
{
    public interface IMonAnSvc
    {
        public List<MonAn> GetMonAnAll();
        MonAn GetMonAn(int id);
        int AddMonAn(MonAn monAn);
        int EditMonAn(int id, MonAn monAn);
    }
    public class MonAnSvc:IMonAnSvc

    {
        
        protected DataContext _context;
        public MonAnSvc(DataContext context)
        {
            _context = context;
        }

        public int AddMonAn(MonAn monAn)
        {
            int ret = 0;
            try
            {
                _context.Add(monAn);
                _context.SaveChanges();
                ret = monAn.Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditMonAn(int id, MonAn monAn)
        {
            int ret = 0;
            try
            {
                _context.Update(monAn);
                _context.SaveChanges();
                ret = monAn.Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public MonAn GetMonAn(int id)
        {
            MonAn monAn = null;
            monAn = _context.MonAns.Find(id);
            return monAn;
        }

        public List<MonAn> GetMonAnAll()
        {
            List<MonAn> monAns = new List<MonAn>();
            monAns = _context.MonAns.Include(x=>x.Photos).ToList();
            return monAns;
        }
    }
}
