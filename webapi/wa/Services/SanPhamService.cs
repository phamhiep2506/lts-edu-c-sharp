using AutoMapper;
using wa.Models;
using wa.Models.Dtos;
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

    public ResponseDto<GetSanPhamDto> CreateSanPham(
        CreateSanPhamDto createSanPhamDto
    )
    {
        SanPham sanPham = _mapper.Map<CreateSanPhamDto, SanPham>(
            createSanPhamDto
        );

        bool? isTenSanPham = _context.SanPhams?.Any(x =>
            x.TenSanPham == createSanPhamDto.TenSanPham
        );

        if (isTenSanPham == true)
        {
            return new ResponseDto<GetSanPhamDto>()
            {
                status = "error",
                message = "Sản phẩm đã tồn tại",
            };
        }

        bool? isTenLoaiSanPham = _context.LoaiSanPhams?.Any(x =>
            x.TenLoaiSanPham == createSanPhamDto.TenLoaiSanPham
        );

        if (isTenLoaiSanPham == false || isTenLoaiSanPham == null)
        {
            return new ResponseDto<GetSanPhamDto>()
            {
                status = "error",
                message = "Loại sản phẩm không tồn tại",
            };
        }

        int? loaiSanPhamId = _context
            .LoaiSanPhams?.Where(x =>
                x.TenLoaiSanPham == createSanPhamDto.TenLoaiSanPham
            )
            .Select(x => x.LoaiSanPhamId)
            .FirstOrDefault();

        if (loaiSanPhamId == null)
        {
            return new ResponseDto<GetSanPhamDto>()
            {
                status = "error",
                message = "Không thể tìm kiếm loại sản phẩm id",
            };
        }
        sanPham.LoaiSanPhamId = (int)loaiSanPhamId;

        _context.Add(sanPham);
        _context.SaveChanges();

        GetSanPhamDto getSanPhamDto = _mapper.Map<SanPham, GetSanPhamDto>(
            sanPham
        );
        getSanPhamDto.TenLoaiSanPham = createSanPhamDto.TenLoaiSanPham;

        return new ResponseDto<GetSanPhamDto>()
        {
            status = "success",
            message = "ok",
            items = new List<GetSanPhamDto>() { getSanPhamDto }
        };
    }

    public int GetSanPhamIdByName(string tenSanPham)
    {
        int? sanPhamId = _context
            .SanPhams?.Where(x => x.TenSanPham == tenSanPham)
            .Select(x => x.SanPhamId)
            .FirstOrDefault();

        if (sanPhamId == null)
        {
            return -1;
        }

        return (int)sanPhamId;
    }
}
