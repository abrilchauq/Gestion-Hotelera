namespace Proyecto.Entidades.Unidades;
public class Sede
{
    public string Nombre { get; set; }
    public string Ubicacion { get; set; }
    public List<Habitacion> Habitaciones { get; set; }
    public Sede(string nombre, string ubicacion)
    {
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
        this.Habitaciones = new List<Habitacion>();
    }

    
}