namespace Proyecto.Entidades;
public class Notificacion
{
    public Guid IdNotificacion { get; private set; }
    public string Mensaje { get; private set; }
    public Notificacion(string mensaje)
    {
        this.IdNotificacion = Guid.NewGuid();
        this.Mensaje = mensaje;
    }
}
