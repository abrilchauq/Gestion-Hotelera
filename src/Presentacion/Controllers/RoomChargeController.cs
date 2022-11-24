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
}
