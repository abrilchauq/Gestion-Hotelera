using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Usuarios;
using Proyecto.Enums;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly HotelDBContext context;

    public UsuarioController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var usuarios = context.Usuarios.ToList();
        return Ok(usuarios);
    }

    [HttpPost]
    public ActionResult Post(UsuarioViewModel nuevoUsuario)
    {
        var unUsuario = new Usuario(nuevoUsuario.Nombre, nuevoUsuario.Contraseña,(eEstadoUsuario)nuevoUsuario.estado);
        context.Usuarios.Add(unUsuario);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unUsuario); 
    }
}
