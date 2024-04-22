using AutoMapper;
using wa.Models;
using wa.Models.Dtos.LoaiSanPham;
using wa.Services.IServices;

namespace wa.Services;

public class LoaiSanPhamService : ILoaiSanPhamService
{
    private readonly IMapper _mapper;
    private readonly CuaHangContext _context;

    public LoaiSanPhamService(IMapper mapper, CuaHangContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public GetLoaiSanPhamDto CreateLoaiSanPham(CreateLoaiSanPhamDto createLoaiSanPhamDto)
    {
        bool? isTenLoaiSanPham = _context.LoaiSanPhams?.Any(x =>
            x.TenLoaiSanPham == createLoaiSanPhamDto.TenLoaiSanPham
        );

        if (isTenLoaiSanPham == true)
        {
            return new GetLoaiSanPhamDto();
        }

        LoaiSanPham loaiSanPham = _mapper.Map<CreateLoaiSanPhamDto, LoaiSanPham>(
            createLoaiSanPhamDto
        );

        _context.Add(loaiSanPham);
        _context.SaveChanges();

        GetLoaiSanPhamDto getKhachHangDto = _mapper.Map<LoaiSanPham, GetLoaiSanPhamDto>(
            loaiSanPham
        );

        return getKhachHangDto;
    }

    public List<GetLoaiSanPhamDto> GetAllLoaiSanPham()
    {
        List<LoaiSanPham>? loaiSanPhams = _context.LoaiSanPhams?.ToList();

        if (loaiSanPhams == null)
        {
            return new List<GetLoaiSanPhamDto>();
        }

        List<GetLoaiSanPhamDto> loaiSanPhamDtos = _mapper.Map<
            List<LoaiSanPham>,
            List<GetLoaiSanPhamDto>
        >(loaiSanPhams);

        return loaiSanPhamDtos;
    }
}
