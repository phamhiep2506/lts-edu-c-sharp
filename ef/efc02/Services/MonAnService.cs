using System.Security.Cryptography.X509Certificates;
using efc02.Dtos;
using efc02.Models;

namespace efc02.Services;

public class MonAnService : IMonAnService
{
    private CongThucNauAnDbContext _context;

    public MonAnService()
    {
        _context = new CongThucNauAnDbContext();
    }

    public void ThemMonAn(ThemMonAnDto themMonAnDto)
    {
        bool isMonAn = _context.MonAn.Any(x => x.TenMon == themMonAnDto.TenMon);

        if (isMonAn)
        {
            return;
        }

        LoaiMonAnService loaiMonAnService = new LoaiMonAnService();
        loaiMonAnService.ThemLoaiMonAn(themMonAnDto.TenLoai);

        MonAn monAn = new MonAn()
        {
            TenMon = themMonAnDto.TenMon,
            LoaiMonAnId = loaiMonAnService.GetLoaiMonAnId(themMonAnDto.TenLoai)
        };
        _context.Add(monAn);
        _context.SaveChanges();

        foreach (ThemNguyenLieuDto themNguyenLieuDto in themMonAnDto.ThemNguyenLieuDtos)
        {
            NguyenLieu nguyenLieu = new NguyenLieu()
            {
                TenNguyenLieu = themNguyenLieuDto.TenNguyenLieu
            };
            _context.Add(nguyenLieu);
            _context.SaveChanges();

            CongThuc congThuc = new CongThuc()
            {
                MonAnId = monAn.LoaiMonAnId,
                NguyenLieuId = nguyenLieu.NguyenLieuId,
                SoLuong = themNguyenLieuDto.SoLuong,
                DonViTinh = themNguyenLieuDto.DonViTinh
            };
            _context.Add(congThuc);
            _context.SaveChanges();
        }
    }

    public void HienMonAn()
    {
        List<MonAnDto> item = (
            from monAn in _context.MonAn
            join congThuc in _context.CongThuc on monAn.MonAnId equals congThuc.MonAnId
            join nguyenLieu in _context.NguyenLieu on congThuc.NguyenLieuId equals nguyenLieu.NguyenLieuId
            select new MonAnDto() {
                TenMonAn = monAn.TenMon,
                TenNguyenLieu = nguyenLieu.TenNguyenLieu,
                SoLuong = congThuc.SoLuong,
                DonViTinh = congThuc.DonViTinh
            }
        ).ToList();
        item.ForEach(x => {
            Console.WriteLine($"Món ăn {x.TenMonAn}: {x.TenNguyenLieu} - {x.SoLuong} - {x.DonViTinh}");
        });
    }

    public int GetMonAnId(string tenMon)
    {
        int monAnId = _context
            .MonAn.Where(x => x.TenMon == tenMon)
            .Select(x => x.MonAnId)
            .SingleOrDefault();
        return monAnId;
    }
}
