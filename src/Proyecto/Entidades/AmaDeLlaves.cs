namespace Proyecto.Entidades;

public class AmaDeLlaves : Usuario
{
    public Guid idAmaDeLlaves { get; private set; }
    public AmaDeLlaves(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.idAmaDeLlaves = Guid.NewGuid();
    }

    public void agregarRegistro(ServicioLimpieza servicio, Registro registro)
    {
        servicio.agregarRegistro(registro);
    }
}
