using AutoMapper;
using wa.Models;
using wa.Models.Dtos.KhachHang;
using wa.Services.IServices;

namespace wa.Services;

public class KhachHangService : IKhachHangService
{
    private readonly IMapper _mapper;
    private readonly CuaHangContext _context;

    public KhachHangService(IMapper mapper, CuaHangContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public GetKhachHangDto CreateKhachHang(CreateKhachHangDto createKhachHangDto)
    {
        KhachHang khachHang = _mapper.Map<CreateKhachHangDto, KhachHang>(createKhachHangDto);

        _context.Add(khachHang);
        _context.SaveChanges();

        GetKhachHangDto getKhachHangDto = _mapper.Map<KhachHang, GetKhachHangDto>(khachHang);

        return getKhachHangDto;
    }
}
