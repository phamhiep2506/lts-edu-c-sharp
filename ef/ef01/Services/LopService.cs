using ef01.Models;
using ef01.Data;

namespace ef01.Services
{
    public class LopService : ILopService
    {
        HocSinhContext hocSinhContext = new HocSinhContext();

        public void ThemThongTinLop(Lop lop)
        {
            hocSinhContext.Add(lop);
            hocSinhContext.SaveChanges();
        }
    }
}

