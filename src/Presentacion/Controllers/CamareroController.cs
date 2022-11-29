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

}