using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using wa.Models;

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
}
