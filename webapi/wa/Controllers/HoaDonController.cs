using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using wa.Models;
using wa.Models.Dtos;
using wa.Models.Dtos.ChiTietHoaDon;
using wa.Models.Dtos.HoaDon;
using wa.Services;

namespace wa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HoaDonController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ILogger<HoaDonController> _logger;
    private readonly CuaHangContext _context;

    public HoaDonController(
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
    public IActionResult CreateHoaDon(CreateHoaDonDto createHoaDonDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        ResponseDto<GetHoaDonDto> responseDto = new HoaDonService(
            _mapper,
            _context
        ).CreateHoaDon(createHoaDonDto);

        return Ok(responseDto);
    }

    [HttpPost]
    [Route("{hoaDonId}")]
    public IActionResult AddChiTietHoaDon(
        int hoaDonId,
        List<AddChiTietHoaDonDto> chiTietHoaDons
    )
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        ResponseDto<GetHoaDonDto> responseDto = new ChiTietHoaDonService(
            _mapper,
            _context
        ).AddChiTietHoaDon(hoaDonId, chiTietHoaDons);

        return Ok(responseDto);
    }

    [HttpPatch]
    [Route("{hoaDonId}")]
    public IActionResult UpdateChiTietHoaDon(
        int hoaDonId,
        UpdateChiTietHoaDonDto updateChiTietHoaDonDto
    )
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        ResponseDto<GetHoaDonDto> responseDto = new ChiTietHoaDonService(
            _mapper,
            _context
        ).UpdateChiTietHoaDon(hoaDonId, updateChiTietHoaDonDto);

        return Ok(responseDto);
    }

    [HttpDelete]
    [Route("{hoaDonId}")]
    public IActionResult DeleteHoaDon(int hoaDonId)
    {
        ResponseDto<GetHoaDonDto> responseDto = new HoaDonService(
            _mapper,
            _context
        ).DeleteHoaDon(hoaDonId);

        return Ok(responseDto);
    }
}
