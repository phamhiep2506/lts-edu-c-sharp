using ef01.Models;

namespace ef01.Services
{
    public interface IHocSinhService
    {
        public void ThemThongTinHocSinh(HocSinh hocSinh);
        public void SuaThongTinHocSinh(int hocSinhId, HocSinh hocSinh);
        public void XoaThongTinHocSinh(int hocSinhId);
        public void DoiThongTinLopHocSinh(int hocSinhId, int lopId);
    }
}
