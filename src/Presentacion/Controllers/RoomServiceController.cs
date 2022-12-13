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
        var unRoomService = new RoomService(nuevoRoomService.Solicitud, nuevoRoomService.fecha, nuevoRoomService.duracion, nuevoRoomService.descripcion);
        context.RoomServices.Add(unRoomService);
        context.SaveChanges();
        return Created($"/api/roomService/{unRoomService.Id}", unRoomService);
    }

    [HttpPut]

    public ActionResult Put([FromBody] RoomServiceViewModel roomService, Guid id)
    {
        var RoomServiceConCambios = context.RoomServices.FirstOrDefault(r => r.Id == id );

        RoomServiceConCambios.Actualizar(roomService.Solicitud,roomService.fecha,roomService.duracion,roomService.descripcion);
        context.SaveChanges();
        return Ok(RoomServiceConCambios);

    }

    [HttpDelete]

    public ActionResult Delete(Guid IdRoomService)
    {
        var roomServiceBorrar = context.RoomServices.FirstOrDefault(r => r.Id == IdRoomService);
        context.RoomServices.Remove(roomServiceBorrar);
        context.SaveChanges();
        return Ok();
    }
}
