using Proyecto.Entidades.Servicios;

namespace Proyecto.Entidades.Usuarios;

public class AmaDeLlaves : Usuario
{
    public Guid IdAmaDeLlaves { get; private set; }
    public AmaDeLlaves(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.IdAmaDeLlaves = Guid.NewGuid();
    }

    public void agregarRegistro(ServicioLimpieza servicio, RegistroServicio registroLimpieza)
    {
        servicio.agregarRegistro(registroLimpieza);
    }
}
