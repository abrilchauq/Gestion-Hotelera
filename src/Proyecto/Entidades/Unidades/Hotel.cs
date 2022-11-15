using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Entidades.Unidades;
[Table("Hotel")]
public class Hotel
{
    [Key]
    [Required]
    public Guid IdHotel { get; private set; }
    [StringLength(50)]
    public string Nombre { get; private set; }
    [Required]
    public string Ubicacion { get; private set; }
    [Required]
    public List<Sede> Sedes { get; private set; }

    public Hotel(string nombre, string ubicacion)
    {
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
        this.Sedes = new List<Sede>();
        this.IdHotel = Guid.NewGuid();
    }

    public void AgregarSede(Sede sede)
    {
        this.Sedes.Add(sede);
    }
}
