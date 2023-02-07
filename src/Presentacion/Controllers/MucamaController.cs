using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Usuarios;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MucamaController : ControllerBase
{
    private readonly HotelDBContext context;

    public MucamaController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]

    public ActionResult Get()
    {
        var mucamas = context.Mucamas.ToList();
        return Ok(mucamas);
    }

    [HttpPost]
    public ActionResult Post(MucamaViewModel nuevaMucama)
    {
        var unaMucama = new Mucama(nuevaMucama.Email, nuevaMucama.Nombre, nuevaMucama.apellido, nuevaMucama.Telefono, nuevaMucama.Domicilio);
        context.Mucamas.Add(unaMucama);
        context.SaveChanges();
        return Created($"/api/mucama/{unaMucama.id}", unaMucama);
    }

    [HttpPost("/api/Mucama/{id:Guid}/Usuario/{idUsuario:Guid}")]
    public ActionResult AsignarUsuario(Guid id, Guid idUsuario)
    {
        var mucama = context.Mucamas.FirstOrDefault(u => u.id == id);
        var usuario = context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
        mucama.AsignarUsuario(usuario);
        context.SaveChanges();
        return Ok("Se asignó usuario");
    }

    [HttpPut]
    public ActionResult Put([FromBody] MucamaViewModel mucama, Guid id)
    {
        var mucamaConCambios = context.Mucamas.FirstOrDefault(m => m.id == id);

        mucamaConCambios.Actualizar(mucama.Email, mucama.Nombre, mucama.apellido, mucama.Telefono, mucama.Domicilio);
        context.SaveChanges();
        return Ok(mucamaConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var mucamaABorrar = context.Mucamas.FirstOrDefault(m => m.id == id);
        context.Mucamas.Remove(mucamaABorrar);
        context.SaveChanges();
        return Ok();
    }


}
