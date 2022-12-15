using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Unidades;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SedeController : ControllerBase
{
    private readonly HotelDBContext context;

    public SedeController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var sedes = context.Sedes.ToList();
        return Ok(sedes);
    }

    [HttpPost]
    public ActionResult Post(SedeViewModel nuevaSede)
    {
        var unaSede = new Sede(nuevaSede.Nombre, nuevaSede.Ubicacion);
        context.Sedes.Add(unaSede);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unaSede);
    }

    [HttpPost("/api/Sede/{IdSede:Guid}/Habitacion/{IdHabitacion:Guid}")]
    public ActionResult AgregarHabitacion(Guid IdSede, Guid IdHabitacion)
    {
        var sede = context.Sedes.FirstOrDefault(s => s.idSede == IdSede);
        var habitacion = context.Habitaciones.FirstOrDefault(s => s.IdHabitacion == IdHabitacion);
        sede.AgregarHabitacion(habitacion);
        context.SaveChanges();
        return Ok("SE ASOCIO UNA SEDE");
    }

    [HttpPut]
    public ActionResult Put([FromBody] SedeViewModel sede, Guid idSede)
    {
        var sedeConCambios = context.Sedes.FirstOrDefault(s => s.idSede == idSede);

        sedeConCambios.Actualizar(sede.Nombre, sede.Ubicacion);
        context.SaveChanges();
        return Ok(sedeConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid idSede)
    {
        var sedeABorrar = context.Sedes.FirstOrDefault(h => h.idSede == idSede);
        context.Sedes.Remove(sedeABorrar);
        context.SaveChanges();
        return Ok();
    }
}
