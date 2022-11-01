namespace Proyecto;

public class Registro
{
    public Guid idRegistro { get; private set; }
    public DateTime FechaHora { get; private set; }
    public Habitacion Habitacion { get; private set; }
    public Registro(DateTime FechaHora, Habitacion Habitacion)
    {
        this.idRegistro = Guid.NewGuid();
        this.FechaHora = FechaHora;
        this.Habitacion = Habitacion;

    }
}