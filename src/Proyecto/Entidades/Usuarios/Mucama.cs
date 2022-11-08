using Proyecto.Entidades.Servicios;

namespace Proyecto.Entidades.Usuarios;

public class Mucama : Persona
{
    public Guid IdMucama { get; private set; }
    public Mucama(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.IdMucama = Guid.NewGuid();
    }

    public void agregarRegistro(ServicioLimpieza servicio, RegistroServicio registroLimpieza)
    {
        servicio.agregarRegistro(registroLimpieza);
    }
}
