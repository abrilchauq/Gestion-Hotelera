
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Facturacion;

namespace Proyecto.Entidades.Servicios;
[Table("Amenity")]
public class Amenity : RoomCharge
{
    [StringLength(30)]
    public string? nombre { get; private set; }

    public Amenity(string nombre, string descripcion, DateTime fecha, int duracion) : base(fecha, duracion, descripcion)
    {
        this.nombre = nombre;
        this.monto = 0;
    }

    public void Actualizar(string Nombre, string descripcion, DateTime fecha, int duracion)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.fecha = fecha;
        this.duracion = duracion;

    }
}
