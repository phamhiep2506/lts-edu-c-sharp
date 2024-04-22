using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using wa.Models;
using wa.Models.Dtos.LoaiSanPham;
using wa.Services;

namespace wa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoaiSanPhamController : Controller
{
    private readonly IMapper _mapper;
    private readonly ILogger<HoaDonController> _logger;
    private readonly CuaHangContext _context;

    public LoaiSanPhamController(
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
    public IActionResult CreateLoaiSanPham(CreateLoaiSanPhamDto createLoaiSanPhamDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        GetLoaiSanPhamDto LoaiSanPham = new LoaiSanPhamService(_mapper, _context).CreateLoaiSanPham(
            createLoaiSanPhamDto
        );

        return Ok(LoaiSanPham);
    }

    [HttpGet]
    public IActionResult GetLoaiSanPham()
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        List<GetLoaiSanPhamDto> getLoaiSanPhamDtos = new LoaiSanPhamService(
            _mapper,
            _context
        ).GetAllLoaiSanPham();

        return Ok(getLoaiSanPhamDtos);
    }
}
