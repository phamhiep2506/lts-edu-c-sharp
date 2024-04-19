using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using wa.Models;
using wa.Models.Dtos.KhachHang;
using wa.Services;

namespace wa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KhachHangController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ILogger<HoaDonController> _logger;
    private readonly CuaHangContext _context;

    public KhachHangController(
        IMapper mapper,
        ILogger<HoaDonController> logger,
        CuaHangContext context
    )
    {
        _mapper = mapper;
        _logger = logger;
        _context = context;
    }

    [HttpPost]
    public IActionResult CreateKhachHang(AddKhachHangDto addKhachHangDto)
    {
        KhachHang khachHang = new KhachHangService(_mapper, _context).AddKhachHang(addKhachHangDto);

        return Ok(khachHang);
    }
}
