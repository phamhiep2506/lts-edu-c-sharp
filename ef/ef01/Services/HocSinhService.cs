using ef01.Data;
using ef01.Models;

namespace ef01.Services
{
    public class HocSinhService : IHocSinhService
    {
        protected HocSinhContext hocSinhContext = new HocSinhContext();

        public void ThemThongTinHocSinh(HocSinh hocSinh)
        {
            hocSinhContext.Add(hocSinh);
            hocSinhContext.SaveChanges();
        }

        public void SuaThongTinHocSinh(int hocSinhId, HocSinh hocSinh)
        {
            HocSinh? result = hocSinhContext.HocSinh?.SingleOrDefault(
                x => x.HocSinhID == hocSinhId
            );
            if (result != null)
            {
                result.LopID = hocSinh.LopID;
                result.HoTen = hocSinh.HoTen;
                result.NgaySinh = hocSinh.NgaySinh;
                result.QueQuan = hocSinh.QueQuan;
                hocSinhContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("[?] Hoc Sinh Khong Ton Tai");
            }
        }

        public void XoaThongTinHocSinh(int hocSinhId)
        {
            HocSinh? result = hocSinhContext.HocSinh?.SingleOrDefault(
                x => x.HocSinhID == hocSinhId
            );
            if (result != null)
            {
                hocSinhContext.Remove(result);
                hocSinhContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("[?] Hoc Sinh Khong Ton Tai");
            }
        }

        public void DoiThongTinLopHocSinh(int hocSinhId, int lopId)
        {
            HocSinh? result = hocSinhContext.HocSinh?.SingleOrDefault(
                x => x.HocSinhID == hocSinhId
            );
            if (result != null)
            {
                result.LopID = lopId;
                hocSinhContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("[?] Hoc Sinh Khong Ton Tai");
            }
        }
    }
}

