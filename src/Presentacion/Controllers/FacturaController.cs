using Microsoft.AspNetCore.Mvc;
using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Proyecto.Entidades.Facturacion;

namespace Presentacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FacturaController : ControllerBase
{
    private readonly HotelDBContext context;

    public FacturaController(HotelDBContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var facturas = context.Facturas.ToList();
        return Ok(facturas);
    }

    [HttpPost]
    public ActionResult Post(FacturaViewModel nuevaFactura)
    {
        var unaFactura = new Factura(nuevaFactura.numero, nuevaFactura.fechaHora, nuevaFactura.monto);
        context.Facturas.Add(unaFactura);
        context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created, unaFactura);
    }
}
