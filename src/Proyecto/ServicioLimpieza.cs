namespace Proyecto;

public class ServicioLimpieza
{
    public List<Registro> Registros { get; private set; }
    public List<AmaDeLlaves> AmaDeLlaves { get; private set; }
    public Guid idServicioLimpieza { get; private set; }
    public ServicioLimpieza()
    {
        this.Registros = new List<Registro>();
        this.AmaDeLlaves = new List<AmaDeLlaves>();
        this.idServicioLimpieza = Guid.NewGuid();
    }

    public void agregarRegistro(Registro unRegistro) =>
         this.Registros.Add(unRegistro);
}


