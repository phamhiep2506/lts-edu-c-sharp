using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using wa.Models;
using wa.Models.Dtos;
using wa.Models.Dtos.SanPham;
using wa.Services;

namespace wa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SanPhamController : Controller
{
    private readonly IMapper _mapper;
    private readonly ILogger<HoaDonController> _logger;
    private readonly CuaHangContext _context;

    public SanPhamController(
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
    public IActionResult CreateLoaiSanPham(CreateSanPhamDto createSanPhamDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        ResponseDto<GetSanPhamDto> responseDto = new SanPhamService(
            _mapper,
            _context
        ).CreateSanPham(createSanPhamDto);

        return Ok(responseDto);
    }
}
