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

    private RecepcionistaController(HotelDBContext context)
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
}
