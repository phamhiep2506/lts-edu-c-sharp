using System.Globalization;
using AutoMapper;
using wa.Models;
using wa.Models.Dtos.KhachHang;
namespace wa.Services;

public class KhachHangService
{
    private readonly IMapper _mapper;
    private readonly CuaHangContext _context;

    public KhachHangService(IMapper mapper, CuaHangContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public KhachHang AddKhachHang(AddKhachHangDto addKhachHangDto)
    {
        KhachHang khachHang = _mapper.Map<KhachHang>(addKhachHangDto);
        if(addKhachHangDto.NgaySinh != null)
        {
            khachHang.NgaySinh = DateTime.ParseExact(addKhachHangDto.NgaySinh, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
        _context.Add(khachHang);
        _context.SaveChanges();
        return khachHang;
    }
}
