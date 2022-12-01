using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Servicios;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomServiceController : ControllerBase
{
    private readonly HotelDBContext context;
    public RoomServiceController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]

    public ActionResult Get()
    {
        var roomServices = context.RoomServices.ToList();
        return Ok(roomServices);
    }

    [HttpPost]

    public ActionResult Post(RoomServiceViewModel nuevoRoomService)
    {
        var unRoomService = new RoomService(nuevoRoomService.Solicitud, nuevoRoomService.SeCobra, nuevoRoomService.fecha, nuevoRoomService.duracion, nuevoRoomService.descripcion);
        context.RoomServices.Add(unRoomService);
        context.SaveChanges();
        return Created($"/api/roomService/{unRoomService.IdRoomCharge}", unRoomService);
    }
}
