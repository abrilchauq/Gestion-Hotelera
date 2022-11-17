using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Unidades;

namespace Presentacion.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class SedeController : ControllerBase
    {
        private readonly HotelDBContext context;

        public SedeController(HotelDBContext context)
        {
            this.context = context;
        }

    [HttpGet]
    public ActionResult Get()
    {
        var sedes = context.Sedes.ToList();
        return Ok(sedes);
    }

    [HttpPost]
    public ActionResult Post(SedeViewModel nuevaSede)
    {
        var unaSede = new Sede(nuevaSede.Nombre, nuevaSede.Ubicacion);
        context.Sedes.Add(unaSede);
        context.SaveChanges();
        return StatusCode(202, unaSede);
    }
    }
