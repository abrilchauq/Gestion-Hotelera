using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Usuarios;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CamareroController : ControllerBase
{
    private readonly HotelDBContext context;

    public CamareroController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]

    public ActionResult Get()
    {
        var camareros = context.Camareros.ToList();
        return Ok(camareros);
    }

    [HttpPost]

    public ActionResult Post(CamareroViewModel nuevoCamarero)
    {
        var unCamarero = new Camarero(nuevoCamarero.Email, nuevoCamarero.Nombre, nuevoCamarero.apellido, nuevoCamarero.Telefono, nuevoCamarero.Domicilio);
        context.Camareros.Add(unCamarero);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unCamarero);
    }

    [HttpPut]

    public ActionResult Put([FromBody] CamareroViewModel camarero, Guid idCamarero)
    {
        var camareroConCambios = context.Camareros.FirstOrDefault(x => x.id == idCamarero);
        camareroConCambios.Actualizar(camarero.Email, camarero.Nombre, camarero.apellido, camarero.Telefono, camarero.Domicilio);
        context.SaveChanges();
        return Ok(camareroConCambios);
    }

    [HttpDelete]

    public ActionResult Delete(Guid idCamarero)
    {
        var camareroBorrar = context.Camareros.FirstOrDefault(c => c.id == idCamarero);
        context.Camareros.Remove(camareroBorrar);
        context.SaveChanges();
        return Ok();
    }

}