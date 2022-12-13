using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Facturacion;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomChargeController : ControllerBase
{
    private readonly HotelDBContext context;

    public RoomChargeController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]

    public ActionResult Get()
    {
        var roomCharges = context.RoomCharges.ToList();
        return Ok(roomCharges);
    }

    [HttpPost]

    public ActionResult Post(RoomChargeViewModel nuevoRoomCharge)
    {
        var unRoomCharge = new RoomCharge(nuevoRoomCharge.fecha, nuevoRoomCharge.duracion, nuevoRoomCharge.descripcion);
        context.RoomCharges.Add(unRoomCharge);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unRoomCharge);
    }

    [HttpPut]
    public ActionResult Put([FromBody] RoomChargeViewModel roomCharge, Guid IdRoomCharge)
    {
        var roomChargeConCambios = context.RoomCharges.FirstOrDefault(r => r.Id == IdRoomCharge);

        roomChargeConCambios.Actualizar(roomCharge.fecha, roomCharge.duracion, roomCharge.descripcion, roomCharge.monto);
        context.SaveChanges();
        return Ok(roomChargeConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid IdRoomCharge)
    {
        var roomChargeABorrar = context.RoomCharges.FirstOrDefault(r => r.Id == IdRoomCharge);
        context.RoomCharges.Remove(roomChargeABorrar);
        context.SaveChanges();
        return Ok();
    }
}
