using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Servicios;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KitchenServiceController : ControllerBase
{
    private readonly HotelDBContext context;
    public KitchenServiceController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var kitchenServices = context.KitchenServices.ToList();
        return Ok(kitchenServices);
    }

    [HttpPost]
    public ActionResult Post(KitchenServiceViewModel nuevoKitechenService)
    {
        var unkitchenService = new KitchenService(nuevoKitechenService.descripcion, nuevoKitechenService.fecha, nuevoKitechenService.duracion);
        context.KitchenServices.Add(unkitchenService);
        context.SaveChanges();
        return Created($"/api/kitchenService/{unkitchenService.Id}", unkitchenService);
    }

    [HttpPut]
    public ActionResult Put([FromBody] KitchenServiceViewModel kitchenService, Guid IdRoomCharge)
    {
        var kitchenServiceConCambios = context.KitchenServices.FirstOrDefault(k => k.Id == IdRoomCharge);

        kitchenServiceConCambios.Actualizar(kitchenService.descripcion, kitchenService.fecha, kitchenService.duracion);
        context.SaveChanges();
        return Ok(kitchenServiceConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid IdRoomCharge)
    {
        var kitchenServiceABorrar = context.KitchenServices.FirstOrDefault(k => k.Id == IdRoomCharge);
        context.KitchenServices.Remove(kitchenServiceABorrar);
        context.SaveChanges();
        return Ok();
    }
}
