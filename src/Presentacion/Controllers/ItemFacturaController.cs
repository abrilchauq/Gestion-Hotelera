using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Facturacion;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemFacturaController : ControllerBase
{
    private readonly HotelDBContext context;

    public ItemFacturaController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var itemFacturas = context.ItemFacturas.ToList();
        return Ok(itemFacturas);
    }

    [HttpPost]
    public ActionResult Post(ItemFacturaViewModel nuevoItemFactura)
    {
        var unItemFactura = new ItemFactura(nuevoItemFactura.Descripcion, nuevoItemFactura.Fecha, nuevoItemFactura.Monto);
        context.ItemFacturas.Add(unItemFactura);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unItemFactura);
    }

}
