using Microsoft.EntityFrameworkCore;
using test_ef.Dtos;
using test_ef.IServices;
using test_ef.Models;

namespace test_ef.Services;

public class KhachHangService : IKhachHangService
{
    private AppDbContext _context;

    public KhachHangService()
    {
        _context = new AppDbContext();
    }

    public string LayKhachHangMuaNhieuNhat()
    {
        int khachHangId = _context
            .ChiTietDonDatHang.GroupBy(x => x.DonDatHangId)
            .OrderByDescending(x => x.Count())
            .Select(x => x.Key)
            .FirstOrDefault();
        string? hoTen = _context
            .KhachHang?.Where(x => x.KhachHangId == khachHangId)
            .Select(x => x.HoTen)
            .FirstOrDefault();
        if (hoTen == null)
        {
            return "";
        }
        return hoTen;
    }

    public List<KhachHangDto> LayKhachHangMuaSanPhamHaNoi()
    {
        List<KhachHangDto> khachHangDtos = _context
            .DonDatHang.Include(x => x.KhachHang)
            .Where(x =>
                x.KhachHang.DiaChi == "Hà Nội" && x.NgayDat.Year == 2020 && x.NgayDat.Month == 6
            )
            .Select(x => new KhachHangDto()
            {
                HoTen = x.KhachHang.HoTen,
                DiaChi = x.KhachHang.DiaChi
            })
            .ToList();
        return khachHangDtos;
    }

    public List<KhachHangSLDto> LayKhachHangDatTren100SP()
    {
        List<KhachHangSLDto> khachHangSLDtos = _context
            .ChiTietDonDatHang.Include(x => x.DonDatHang)
            .ThenInclude(x => x.KhachHang)
            .GroupBy(x => new
            {
                x.DonDatHang.KhachHang.HoTen,
                x.DonDatHang.KhachHang.DiaChi,
                x.SoLuong
            })
            .Select(x => new KhachHangSLDto()
            {
                HoTen = x.Key.HoTen,
                DiaChi = x.Key.DiaChi,
                SoLuongSP = x.Sum(x => x.SoLuong)
            })
            .Where(x => x.SoLuongSP >= 100)
            .ToList();
        return khachHangSLDtos;
    }
}
