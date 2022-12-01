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

    [HttpPut]
    public ActionResult Put([FromBody] FacturaViewModel factura, Guid IdFactura)
    {
        var facturaConCambios = context.Facturas.FirstOrDefault(f => f.IdFactura == IdFactura);

        facturaConCambios.Actualizar(factura.numero, factura.fechaHora, factura.monto);
        context.SaveChanges();
        return Ok(facturaConCambios);
    }

    [HttpDelete]
    public ActionResult Delete(Guid IdFactura)
    {
        var facturaABorrar = context.Facturas.FirstOrDefault(r => r.IdFactura == IdFactura);
        context.Facturas.Remove(facturaABorrar);
        context.SaveChanges();
        return Ok();
    }
}
