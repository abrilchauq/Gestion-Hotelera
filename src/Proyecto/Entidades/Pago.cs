using Proyecto.Enums;

namespace Proyecto.Entidades;
public class Pago
{
    public Guid IdPago { get; private set; }
    public eTipoPago Tipo { get; private set; }

    public Pago(eTipoPago tipo)
    {
        this.Tipo = tipo;
        this.IdPago = Guid.NewGuid();
    }
}