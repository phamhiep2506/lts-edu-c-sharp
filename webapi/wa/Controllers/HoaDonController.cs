using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using wa.Models;
using wa.Models.Dtos;
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
    public IActionResult CreateHoaDon(AddHoaDonDto addHoaDonDto)
    {
        ResponseDto<HoaDon> responseDto = new HoaDonService(_mapper, _context).CreateHoaDon(
            addHoaDonDto
        );

        return Ok(responseDto);
    }
}
