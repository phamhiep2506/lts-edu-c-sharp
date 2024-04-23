using AutoMapper;
using wa.Models;
using wa.Models.Dtos;
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

    public ResponseDto<GetKhachHangDto> CreateKhachHang(CreateKhachHangDto createKhachHangDto)
    {
        bool? isHoTen = _context.KhachHangs?.Any(x =>
            x.HoTen == createKhachHangDto.HoTen && x.SoDienThoai == createKhachHangDto.SoDienThoai
        );

        if (isHoTen == true)
        {
            return new ResponseDto<GetKhachHangDto>() { status = 0, msg = "Khách hàng đã tồn tại" };
        }

        KhachHang khachHang = _mapper.Map<CreateKhachHangDto, KhachHang>(createKhachHangDto);

        _context.Add(khachHang);
        _context.SaveChanges();

        GetKhachHangDto getKhachHangDto = _mapper.Map<KhachHang, GetKhachHangDto>(khachHang);

        return new ResponseDto<GetKhachHangDto>()
        {
            status = 200,
            msg = "Thêm khách hàng thành công",
            items = new List<GetKhachHangDto>() { getKhachHangDto }
        };
    }
}
