using ef02.Models;
using ef02.IServices;
using ef02.Dto;

namespace ef02.Services
{
    public class NhanVienService : INhanVienService
    {
        private NhanVienContext nhanVienContext = new NhanVienContext();

        public void ThemNhanVien(NhanVienDto nhanVienDto)
        {
            NhanVienModel nhanVienModel = new NhanVienModel()
            {
                HoTen = nhanVienDto.HoTen,
                HeSoLuong = nhanVienDto.HeSoLuong
            };
            nhanVienContext.Add(nhanVienModel);
            nhanVienContext.SaveChanges();
        }

        public void XoaNhanVien(XoaNhanVienDto xoaNhanVienDto)
        {
            NhanVienModel? result = nhanVienContext.NhanVienModel?.SingleOrDefault(x => x.HoTen == xoaNhanVienDto.HoTen);
            if (result != null)
            {
                nhanVienContext.Remove(result);
                nhanVienContext.SaveChanges();
            }
        }

        public int TinhLuongNhanVien(TinhLuongNhanVienDto tinhLuongNhanVienDto)
        {
            List<LuongNhanVienDto> results = (from nhanVien in nhanVienContext.NhanVienModel
                    join phanCong in nhanVienContext.PhanCongModel! on nhanVien.NhanVienId equals phanCong.NhanVienId
                    where nhanVien.HoTen == tinhLuongNhanVienDto.HoTen
                    select new LuongNhanVienDto
                    {
                        HoTen = nhanVien.HoTen,
                        HeSoLuong = nhanVien.HeSoLuong,
                        SoGioLam = phanCong.SoGioLam
                    }).ToList();
            if (results != null)
            {
                int soGioLam = 0;
                results.ForEach(x => soGioLam += x.SoGioLam);

                int tongLuong = 0;
                int heSoLuong = results.First().HeSoLuong;
                tongLuong = soGioLam * 15 * heSoLuong;

                return tongLuong;
            }
            return 0;
        }
    }
}
