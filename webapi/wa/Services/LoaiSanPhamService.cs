using AutoMapper;
using wa.Models;
using wa.Models.Dtos;
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

    public ResponseDto<GetLoaiSanPhamDto> CreateLoaiSanPham(CreateLoaiSanPhamDto createLoaiSanPhamDto)
    {
        bool? isTenLoaiSanPham = _context.LoaiSanPhams?.Any(x =>
            x.TenLoaiSanPham == createLoaiSanPhamDto.TenLoaiSanPham
        );

        if (isTenLoaiSanPham == true)
        {
            return new ResponseDto<GetLoaiSanPhamDto>()
            {
                status = 0,
                msg = "Loại sản phẩm đã tồn tại"
            };
        }

        LoaiSanPham loaiSanPham = _mapper.Map<CreateLoaiSanPhamDto, LoaiSanPham>(
            createLoaiSanPhamDto
        );

        _context.Add(loaiSanPham);
        _context.SaveChanges();

        GetLoaiSanPhamDto getLoaiSanPhamDto = _mapper.Map<LoaiSanPham, GetLoaiSanPhamDto>(
            loaiSanPham
        );

        return new ResponseDto<GetLoaiSanPhamDto>()
        {
            status = 200,
            msg = "Thêm loại sản phẩm thành công",
            items = new List<GetLoaiSanPhamDto>() 
            {
                getLoaiSanPhamDto
            }
        };
    }

    public ResponseDto<GetLoaiSanPhamDto> GetAllLoaiSanPham()
    {
        List<LoaiSanPham>? loaiSanPhams = _context.LoaiSanPhams?.ToList();

        if (loaiSanPhams == null)
        {
            return new ResponseDto<GetLoaiSanPhamDto>();
        }

        List<GetLoaiSanPhamDto> loaiSanPhamDtos = _mapper.Map<
            List<LoaiSanPham>,
            List<GetLoaiSanPhamDto>
        >(loaiSanPhams);

        return new ResponseDto<GetLoaiSanPhamDto>()
        {
            status = 200,
            msg = "Thành công",
            items = loaiSanPhamDtos
        };
    }
}
