using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Usuarios;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecepcionistaController : ControllerBase
{
    private readonly HotelDBContext context;

    public RecepcionistaController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]

    public ActionResult Get()
    {
        var recepcionistas = context.Recepcionistas.ToList();
        return Ok(recepcionistas);
    }

    [HttpPost]

    public ActionResult Post(RecepcionistaViewModel nuevoRecepcionista)
    {
        var unRecepcionista = new Recepcionista(nuevoRecepcionista.Email, nuevoRecepcionista.Nombre, nuevoRecepcionista.apellido, nuevoRecepcionista.Telefono, nuevoRecepcionista.Domicilio);
        context.Recepcionistas.Add(unRecepcionista);
        return StatusCode(StatusCodes.Status201Created, unRecepcionista);
    }

    [HttpPut]

    public ActionResult Put([FromBody] RecepcionistaViewModel recepcionista, Guid idRecepcionista)
    {
        var RecepcionistaConCambios = context.Recepcionistas.FirstOrDefault(r => r.id == idRecepcionista);

        RecepcionistaConCambios.Actualizar(recepcionista.Email, recepcionista.Nombre, recepcionista.apellido, recepcionista.Telefono, recepcionista.Domicilio);
        context.SaveChanges();
        return Ok(RecepcionistaConCambios);
    }

    [HttpDelete]

    public ActionResult Delete(Guid id)
    {
        var RecepcionistaBorrar = context.Recepcionistas.FirstOrDefault(r => r.id == id);
        context.Recepcionistas.Remove(RecepcionistaBorrar);
        context.SaveChanges();
        return Ok();
    }
}
