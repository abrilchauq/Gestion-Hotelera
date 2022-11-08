
namespace Proyecto.Entidades.Servicios;

    public class Amenity
    {
        public string? nombre { get; private set; }
        public string? descripcion { get; private set; }

        public Amenity(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
