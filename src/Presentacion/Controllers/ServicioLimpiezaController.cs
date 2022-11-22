using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Servicios;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicioLimpiezaController : ControllerBase
{
    private readonly HotelDBContext context;

    public ServicioLimpiezaController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var servicioLimpiezas = context.ServicioLimpiezas.ToList();
        return Ok(servicioLimpiezas);
    }

    [HttpPost]
    public ActionResult Post(ServicioLimpiezaViewModel nuevoServicioLimpieza)
    {
        var habitacion = context.Habitaciones.FirstOrDefault(h => h.IdHabitacion);
        var unServicioLimpieza = new ServicioLimpieza(nuevoServicioLimpieza.descripcion, nuevoServicioLimpieza.comienzo, nuevoServicioLimpieza.duracion);
        context.ServicioLimpiezas.Add(unServicioLimpieza);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unServicioLimpieza);
    }
}
