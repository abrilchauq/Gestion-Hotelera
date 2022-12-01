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
}
