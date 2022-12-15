using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HabitacionController : ControllerBase
{
    private readonly HotelDBContext context;

    public HabitacionController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]

    public ActionResult Get()
    {
        var habitaciones = context.Habitaciones.ToList();
        return Ok(habitaciones);
    }

    [HttpPost]

    public ActionResult Post(HabitacionViewModel nuevaHabitacion)
    {
        var llave = context.Llaves.FirstOrDefault(x => x.codigo == nuevaHabitacion.CodigoLlave);
        if (llave is null) return BadRequest("CODIGO LLAVE INCORRECTA");
        var unaHabitacion = new Habitacion(nuevaHabitacion.numero, (eTipoEstilo)nuevaHabitacion.tipo, nuevaHabitacion.precioReserva, llave);
        context.Habitaciones.Add(unaHabitacion);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unaHabitacion);
    }

    [HttpPost("/api/Habitacion/{IdHabitacion:Guid}/ServicioLimpieza/{IdServicioLimpieza:Guid}")]
    public ActionResult AgregarServicioLimpieza(Guid IdHabitacion, Guid IdServicioLimpieza)
    {
        var habitacion = context.Habitaciones.FirstOrDefault(h => h.IdHabitacion == IdHabitacion);
        var servicioLimpieza = context.ServicioLimpiezas.FirstOrDefault(s => s.IdServicioLimpieza == IdServicioLimpieza);
        habitacion.AgregarServicioLimpieza(servicioLimpieza);
        context.SaveChanges();
        return Ok("SE ASOCIO SERVIO LIMPIEZA");
    }

    [HttpPut]
    public ActionResult Put([FromBody] HabitacionModificarViewModel habitacion, Guid IdHabitacion)
    {
        var habitacionConCambios = context.Habitaciones.FirstOrDefault(h => h.IdHabitacion == IdHabitacion);

        habitacionConCambios.Actualizar(habitacion.numero, habitacion.tipo, habitacion.precioReserva);
        context.SaveChanges();
        return Ok(habitacionConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid IdHabitacion)
    {
        var habitacionABorrar = context.Habitaciones.FirstOrDefault(h => h.IdHabitacion == IdHabitacion);
        context.Habitaciones.Remove(habitacionABorrar);
        context.SaveChanges();
        return Ok();
    }
}
