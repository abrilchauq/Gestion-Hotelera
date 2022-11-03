using Proyecto.Entidades.Unidades;

namespace Proyecto.Entidades.Servicios;

public class RegistroServicio
{
    public Guid IdRegistro { get; private set; }
    public DateTime FechaHora { get; private set; }
    public Habitacion Habitacion { get; private set; }
    public RegistroServicio(DateTime FechaHora, Habitacion Habitacion)
    {
        this.IdRegistro = Guid.NewGuid();
        this.FechaHora = FechaHora;
        this.Habitacion = Habitacion;
    }
}