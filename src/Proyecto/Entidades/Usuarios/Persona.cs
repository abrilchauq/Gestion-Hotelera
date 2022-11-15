using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Persona")]
public abstract class Persona
{
    [StringLength(50)]
    public string Email { get; private set; }
    [StringLength(50)]
    public string Nombre { get; private set; }
    [StringLength(50)]
    public string Telefono { get; private set; }
    [StringLength(50)]
    public string Domicilio { get; private set; }
    [StringLength(50)]
    public eTipoUsuario Tipo { get; set; }
    public Usuario? Usuario { get; set; }

    public Persona(string email, string nombre, string telefono, string domicilio, eTipoUsuario tipo)
    {
        this.Email = email;
        this.Nombre = nombre;
        this.Telefono = telefono;
        this.Domicilio = domicilio;
        this.Tipo = tipo;
    }

    public void AsignarUsuario(Usuario usuario) => this.Usuario = usuario;
}
