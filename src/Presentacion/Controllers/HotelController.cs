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

    [HttpPut]
    public ActionResult Put([FromBody] HotelViewModel hotel, Guid IdHotel)
    {
        var hotelConCambios = context.Hoteles.FirstOrDefault(h => h.IdHotel == IdHotel);

        hotelConCambios.Actualizar(hotel.Nombre, hotel.Ubicacion);
        context.SaveChanges();
        return Ok(hotelConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid IdHotel)
    {
        var hotelABrorrar = context.Hoteles.FirstOrDefault(h => h.IdHotel == IdHotel);
        context.Hoteles.Remove(hotelABrorrar);
        context.SaveChanges();
        return Ok();
    }
}
