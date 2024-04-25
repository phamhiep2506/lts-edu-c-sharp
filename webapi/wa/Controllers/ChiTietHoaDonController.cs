using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using wa.Models;
using wa.Models.Dtos;
using wa.Models.Dtos.ChiTietHoaDon;
using wa.Services;

namespace wa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChiTietHoaDonController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ILogger<HoaDonController> _logger;
    private readonly CuaHangContext _context;

    public ChiTietHoaDonController(
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
    [Route("{hoaDonId}")]
    public IActionResult UpdateChiTietHoaDon(
        int hoaDonId,
        List<UpdateChiTietHoaDonDto> updateChiTietHoaDons
    )
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        ResponseDto<GetChiTietHoaDonDto> responseDto = new ChiTietHoaDonService(
            _mapper,
            _context
        ).CreateChiTietHoaDon(hoaDonId, updateChiTietHoaDons);

        return Ok(responseDto);
    }
}
