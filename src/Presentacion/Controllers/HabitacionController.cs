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
        var unaHabitacion = new Habitacion(nuevaHabitacion.Numero, (eTipoEstilo)nuevaHabitacion.Tipo, nuevaHabitacion.PrecioReserva);
        context.Habitaciones.Add(unaHabitacion);
        context.SaveChanges();
        return StatusCode(204, unaHabitacion);
    }
}
