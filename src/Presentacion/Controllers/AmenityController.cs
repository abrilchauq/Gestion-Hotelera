using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Servicios;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AmenityController : ControllerBase
{
    private readonly HotelDBContext context;

    public AmenityController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]

    public ActionResult Get()
    {
        var amenities = context.Amenities.ToList();
        return Ok(amenities);
    }

    [HttpPost]

    public ActionResult Post(AmenityViewModel nuevoAmenity)
    {
        var unAmenity = new Amenity(nuevoAmenity.nombre, nuevoAmenity.descripcion, nuevoAmenity.fecha, nuevoAmenity.duracion);
        context.Amenities.Add(unAmenity);
        context.SaveChanges();
        return Created($"/api/amenity/{unAmenity.IdRoomCharge}", unAmenity);
    }
}
