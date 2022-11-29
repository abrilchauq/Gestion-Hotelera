using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Usuarios;

namespace Presentacion.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class HuespedController : ControllerBase
    {
        private readonly HotelDBContext context;

        public HuespedController(HotelDBContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public ActionResult Get()
        {
            var huespedes = context.Huespedes.ToList();
            return Ok(huespedes);
        }

        [HttpPost]

        public ActionResult Post(HuespedViewModel nuevoHuesped)
        {
            var habitacion = context.Habitaciones.FirstOrDefault(x => x.IdHabitacion == nuevoHuesped.idHabitacion);
            if (habitacion is null) return BadRequest("Habitacion no encontrada");
            var unHuesped = new Huesped(nuevoHuesped.Email, nuevoHuesped.Nombre, nuevoHuesped.apellido, nuevoHuesped.Telefono, nuevoHuesped.Domicilio, habitacion!);
            context.Huespedes.Add(unHuesped);
            context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, unHuesped);
        }
}
