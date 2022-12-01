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

    [HttpPut]

    public ActionResult Put([FromBody] UsuarioViewModel usuario, Guid IdUsuario)
    {
        var usuarioConCambios = context.Usuarios.FirstOrDefault(u => u.IdUsuario == IdUsuario);
        
        usuarioConCambios.Actualizar(usuario.Nombre, usuario.Contraseña);
        context.SaveChanges();
        return Ok(usuarioConCambios);
    }

    [HttpDelete]

    public ActionResult Delete(Guid IdUsuario)
    {
        var usuarioABorrar = context.Usuarios.FirstOrDefault(u => u.IdUsuario == IdUsuario);
        context.Usuarios.Remove(usuarioABorrar);
        context.SaveChanges();
        return Ok();
    }
}
