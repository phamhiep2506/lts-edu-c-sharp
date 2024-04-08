using test_ef.Dtos;
using test_ef.IServices;
using test_ef.Models;

namespace test_ef.Services;

public class SanPhamService : ISanPhamService
{
    private AppDbContext _context;

    public SanPhamService()
    {
        _context = new AppDbContext();
    }

    public List<ThongTinSanPham> LayThongTinSanPham()
    {
        List<ThongTinSanPham> thongTinSanPhams = (
            from sp in _context.SanPham
            join lsp in _context.LoaiSanPham on sp.LoaiSanPhamId equals lsp.LoaiSanPhamId
            select new ThongTinSanPham { TenSanPham = sp.TenSanPham, TenLoai = lsp.TenLoai }
        ).ToList();
        return thongTinSanPhams;
    }
}
