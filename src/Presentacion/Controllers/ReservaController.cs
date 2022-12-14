using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Reservacion;
using Proyecto.Enums;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservaController : ControllerBase
{
    private readonly HotelDBContext context;

    public ReservaController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var reservas = context.Reservas.ToList();
        return Ok(reservas);
    }

    [HttpPost]
    public ActionResult Post(ReservaViewModel nuevaReserva)
    {
        var huesped = context.Huespedes.FirstOrDefault(r => r.id == nuevaReserva.IdHuesped);
        if (huesped is null) return BadRequest("Reserva no existe");
        var unaReserva = new Reserva((eTipoEstilo)nuevaReserva.Tipo, nuevaReserva.FechaHospedaje, huesped);
        context.Reservas.Add(unaReserva);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unaReserva);
    }

    [HttpPut]
    public ActionResult Put([FromBody] ReservaViewModel reserva, Guid IdReserva)
    {
        var reservaConCambios = context.Reservas.FirstOrDefault(r => r.IdReserva == IdReserva);

        reservaConCambios.Actualizar(reserva.FechaReserva, reserva.FechaHospedaje, reserva.Tipo);
        context.SaveChanges();
        return Ok(reservaConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid IdReserva)
    {
        var reservaABorrar = context.Reservas.FirstOrDefault(r => r.IdReserva == IdReserva);
        context.Reservas.Remove(reservaABorrar);
        context.SaveChanges();
        return Ok();
    }

}