using AutoMapper;
using wa.Models;
using wa.Models.Dtos.SanPham;
using wa.Services.IServices;

namespace wa.Services;

public class SanPhamService : ISanPhamService
{
    private readonly IMapper _mapper;
    private readonly CuaHangContext _context;

    public SanPhamService(IMapper mapper, CuaHangContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public GetSanPhamDto CreateSanPham(CreateSanPhamDto createSanPhamDto)
    {
        SanPham sanPham = _mapper.Map<CreateSanPhamDto, SanPham>(createSanPhamDto);

        _context.Add(sanPham);
        _context.SaveChanges();

        GetSanPhamDto getSanPhamDto = _mapper.Map<SanPham, GetSanPhamDto>(sanPham);

        return getSanPhamDto;
    }
}
