using Microsoft.EntityFrameworkCore;
using Proyecto.Entidades.Facturacion;
using Proyecto.Entidades.Reservacion;
using Proyecto.Entidades.Servicios;
using Proyecto.Entidades.Unidades;
using Proyecto.Entidades.Usuarios;

namespace Presentacion.Persistencia;

public class HotelDBContext : DbContext
{
    public HotelDBContext(DbContextOptions<HotelDBContext> opciones)
        : base(opciones)
    {

    }

    public DbSet<Factura> Facturas { get; set; }
    public DbSet<ItemFactura> ItemFacturas { get; set; }
    public DbSet<RoomCharge> RoomCharges { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Amenity> Amenities { get; set; }
    public DbSet<KitchenService> KitchenServices { get; set; }
    public DbSet<RoomService> RoomServices { get; set; }
    public DbSet<ServicioLimpieza> ServicioLimpiezas { get; set; }
    public DbSet<Habitacion> Habitaciones { get; set; }
    public DbSet<Hotel> Hoteles { get; set; }
    public DbSet<Llave> Llaves { get; set; }
    public DbSet<Sede> Sedes { get; set; }
    public DbSet<Camarero> Camareros { get; set; }
    public DbSet<Huesped> Huespedes { get; set; }
    public DbSet<Mucama> Mucamas { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Recepcionista> Recepcionistas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}
