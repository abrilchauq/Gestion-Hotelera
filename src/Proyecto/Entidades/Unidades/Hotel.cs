namespace Proyecto.Entidades.Unidades;

public class Hotel
{
    public Guid IdHotel { get; private set; }
    public string Nombre { get; private set; }
    public string Ubicacion { get; private set; }
    public List<Sede> Sedes { get; private set; }

    public Hotel(string nombre, string ubicacion)
    {
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
        this.Sedes = new List<Sede>();
        this.IdHotel = Guid.NewGuid();
    }
}
