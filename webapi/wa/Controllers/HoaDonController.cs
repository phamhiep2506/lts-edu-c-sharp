using Microsoft.AspNetCore.Mvc;

namespace wa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HoaDonController : ControllerBase
{
    private readonly HoaDonController _context;

    public HoaDonController()
    {
        _context = new HoaDonController();
    }

    [HttpGet]
    public IActionResult GetHoaDon()
    {
        return NotFound();
    }
}
