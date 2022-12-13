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
        return Created($"/api/amenity/{unAmenity.Id}", unAmenity);
    }

    [HttpPut]

    public ActionResult Put([FromBody] AmenityViewModel amenity, Guid IdRoomCharge)
    {
        var amenityConCambios = context.Amenities.FirstOrDefault(x => x.Id == IdRoomCharge);
        amenityConCambios.Actualizar(amenity.nombre, amenity.descripcion, amenity.fecha, amenity.duracion);
        context.SaveChanges();
        return Ok(amenityConCambios);

    }

    [HttpDelete]

    public ActionResult Delete(Guid IdRoomCharge)
    {
        var amenityBorrar = context.Amenities.FirstOrDefault(a => a.Id == IdRoomCharge);
        context.Amenities.Remove(amenityBorrar);
        context.SaveChanges();
        return Ok();
    }
}
