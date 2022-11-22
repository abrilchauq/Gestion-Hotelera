using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Unidades;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : ControllerBase
{
    private readonly HotelDBContext context;

    public HotelController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var hoteles = context.Hoteles.ToList();
        return Ok(hoteles);
    }

    [HttpPost]
    public ActionResult Post(HotelViewModel nuevoHotel)
    {
        var unHotel = new Hotel(nuevoHotel.Nombre, nuevoHotel.Ubicacion);
        context.Hoteles.Add(unHotel);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unHotel);
    }
}
