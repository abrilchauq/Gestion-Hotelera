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
        var unServicioLimpieza = new ServicioLimpieza(nuevoServicioLimpieza.descripcion, nuevoServicioLimpieza.comienzo, nuevoServicioLimpieza.duracion);
        context.ServicioLimpiezas.Add(unServicioLimpieza);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unServicioLimpieza);
    }

    [HttpPut]

    public ActionResult Put([FromBody] ServicioLimpiezaViewModel servicioLimpieza, Guid IdServicioLimpieza)
    {
        var servicioLimpiezaConCambios = context.ServicioLimpiezas.FirstOrDefault(s => s.IdServicioLimpieza == IdServicioLimpieza);

        servicioLimpiezaConCambios.Actualizar(servicioLimpieza.descripcion, servicioLimpieza.comienzo, servicioLimpieza.duracion);
        context.SaveChanges();
        return Ok(servicioLimpiezaConCambios);
    }

    [HttpDelete]

    public ActionResult Delete(Guid IdServicioLimpieza)
    {
        var servicioLimpiezaBorrar = context.ServicioLimpiezas.FirstOrDefault(s => s.IdServicioLimpieza == IdServicioLimpieza);
        context.ServicioLimpiezas.Remove(servicioLimpiezaBorrar);
        context.SaveChanges();
        return Ok();
    }
}
