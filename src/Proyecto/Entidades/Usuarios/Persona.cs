using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Persona")]
public abstract class Persona
{
    [Key]
    [Required]
    public Guid id { get; protected set; }

    [StringLength(50)]
    public string Email { get; protected set; }
    [StringLength(50)]
    public string Nombre { get; protected set; }
    [StringLength(50)]
    public string Telefono { get; protected set; }
    [StringLength(50)]
    public string Domicilio { get; protected set; }
    [StringLength(50)]
    public string apellido { get; protected set; }
    public eTipoUsuario Tipo { get; set; }
    public Usuario? Usuario { get; set; }

    public Persona(Guid id, string email, string nombre, string apellido, string telefono, string domicilio, eTipoUsuario tipo)
    {
        this.id = Guid.NewGuid();
        this.Email = email;
        this.Nombre = nombre;
        this.apellido = apellido;
        this.Telefono = telefono;
        this.Domicilio = domicilio;
        this.Tipo = tipo;
    }

    public void AsignarUsuario(Usuario usuario) => this.Usuario = usuario;
}
