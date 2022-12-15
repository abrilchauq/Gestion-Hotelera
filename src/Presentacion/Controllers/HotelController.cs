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

    [HttpPost("/api/Hotel/{IdHotel:Guid}/Sede/{IdSede:Guid}")]
    public ActionResult AgregarSede(Guid IdHotel, Guid IdSede)
    {
        var hotel = context.Hoteles.FirstOrDefault(x => x.IdHotel == IdHotel);
        var sede = context.Sedes.FirstOrDefault(x => x.idSede == IdSede);
        hotel.AgregarSede(sede);
        context.SaveChanges();
        return Ok("SE ASOCIO UNA SEDE");
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
