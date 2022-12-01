using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Usuario")]

public class Usuario
{
    [Key]
    [Required]
    public Guid IdUsuario { get; private set; }
    [StringLength(50)]
    public string Nombre { get; private set; }
    [StringLength(50)]
    public string Contraseña { get; private set; }
    public eEstadoUsuario Estado { get; private set; }

    public Usuario(string nombre, string contraseña, eEstadoUsuario estado)
    {
        this.Nombre = nombre;
        this.Contraseña = contraseña;
        this.Estado = estado;
        this.IdUsuario = Guid.NewGuid();
    }

    public void Actualizar(string Nombre, string Contraseña)
    {
        this.Nombre = Nombre;
        this.Contraseña = Contraseña;
    }
}
