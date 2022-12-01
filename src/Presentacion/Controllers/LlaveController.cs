using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Unidades;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LlaveController : ControllerBase
{
    private readonly HotelDBContext context;

    public LlaveController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var llaves = context.Llaves.ToList();
        return Ok(llaves);
    }

    [HttpPost]
    public ActionResult Post(LlaveViewModel nuevaLlave)
    {
        var unaLlave = new Llave(nuevaLlave.numero, nuevaLlave.codigo);
        context.Llaves.Add(unaLlave);
        context.SaveChanges();
        return StatusCode(201, unaLlave);
    }

    [HttpPut]
    public ActionResult Put([FromBody] LlaveViewModel llave, Guid IdLlave)
    {
        var llaveConCambios = context.Llaves.FirstOrDefault(x => x.IdLlave == IdLlave);

        llaveConCambios.Actualizar(llave.numero, llave.codigo);
        context.SaveChanges();
        return Ok(llaveConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid IdLlave)
    {
        var llaveABorrar = context.Llaves.FirstOrDefault(l => l.IdLlave == IdLlave);
        context.Llaves.Remove(llaveABorrar);
        context.SaveChanges();
        return Ok();
    }
}