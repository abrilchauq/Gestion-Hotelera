using Proyecto.Entidades.Usuarios;

namespace Proyecto.Entidades.Servicios;

public class ServicioLimpieza
{
    public List<RegistroServicio> Registros { get; private set; }
    public List<Mucama> Mucamas { get; private set; }
    public Guid idServicioLimpieza { get; private set; }
    public ServicioLimpieza()
    {
        this.Registros = new List<RegistroServicio>();
        this.Mucamas = new List<Mucama>();
        this.idServicioLimpieza = Guid.NewGuid();
    }

    public void agregarRegistro(RegistroServicio unRegistro) =>
         this.Registros.Add(unRegistro);
}


