﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presentacion.Persistencia;

#nullable disable

namespace Presentacion.Persistencia.Migraciones
{
    [DbContext(typeof(HotelDBContext))]
    partial class HotelDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Proyecto.Entidades.Facturacion.Factura", b =>
                {
                    b.Property<Guid>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("fechaHora")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("monto")
                        .HasColumnType("double");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.HasKey("IdFactura");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("Proyecto.Entidades.Facturacion.ItemFactura", b =>
                {
                    b.Property<Guid>("IdItemFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("FacturaIdFactura")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Monto")
                        .HasColumnType("double");

                    b.HasKey("IdItemFactura");

                    b.HasIndex("FacturaIdFactura");

                    b.ToTable("ItemaFactura");
                });

            modelBuilder.Entity("Proyecto.Entidades.Facturacion.RoomCharge", b =>
                {
                    b.Property<Guid>("IdRoomCharge")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("HabitacionIdHabitacion")
                        .HasColumnType("char(36)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("monto")
                        .HasColumnType("double");

                    b.HasKey("IdRoomCharge");

                    b.HasIndex("HabitacionIdHabitacion");

                    b.ToTable("RoomCharge");
                });

            modelBuilder.Entity("Proyecto.Entidades.Reservacion.Reserva", b =>
                {
                    b.Property<Guid>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHospedaje")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaReserva")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("Huespedid")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("Recepcionistaid")
                        .HasColumnType("char(36)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("IdReserva");

                    b.HasIndex("Huespedid");

                    b.HasIndex("Recepcionistaid");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Proyecto.Entidades.Servicios.ServicioLimpieza", b =>
                {
                    b.Property<Guid>("IdServicioLimpieza")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("comienzo")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<Guid>("habitacionIdHabitacion")
                        .HasColumnType("char(36)");

                    b.HasKey("IdServicioLimpieza");

                    b.HasIndex("habitacionIdHabitacion");

                    b.ToTable("ServicioLimpieza");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Habitacion", b =>
                {
                    b.Property<Guid>("IdHabitacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<Guid>("LlaveIdLlave")
                        .HasColumnType("char(36)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<double>("PrecioReserva")
                        .HasColumnType("double");

                    b.Property<Guid?>("Recepcionistaid")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SedeidSede")
                        .HasColumnType("char(36)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("IdHabitacion");

                    b.HasIndex("LlaveIdLlave");

                    b.HasIndex("Recepcionistaid");

                    b.HasIndex("SedeidSede");

                    b.ToTable("Habitacion");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Hotel", b =>
                {
                    b.Property<Guid>("IdHotel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdHotel");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Llave", b =>
                {
                    b.Property<Guid>("IdLlave")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("Recepcionistaid")
                        .HasColumnType("char(36)");

                    b.Property<bool>("activo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.HasKey("IdLlave");

                    b.HasIndex("Recepcionistaid");

                    b.ToTable("Llave");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Sede", b =>
                {
                    b.Property<Guid>("idSede")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("HotelIdHotel")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idSede");

                    b.HasIndex("HotelIdHotel");

                    b.ToTable("Sede");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Persona", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<Guid?>("UsuarioIdUsuario")
                        .HasColumnType("char(36)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Proyecto.Entidades.Servicios.Amenity", b =>
                {
                    b.HasBaseType("Proyecto.Entidades.Facturacion.RoomCharge");

                    b.Property<string>("nombre")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.ToTable("Amenity");
                });

            modelBuilder.Entity("Proyecto.Entidades.Servicios.KitchenService", b =>
                {
                    b.HasBaseType("Proyecto.Entidades.Facturacion.RoomCharge");

                    b.ToTable("KitchenService");
                });

            modelBuilder.Entity("Proyecto.Entidades.Servicios.RoomService", b =>
                {
                    b.HasBaseType("Proyecto.Entidades.Facturacion.RoomCharge");

                    b.Property<bool>("SeCobra")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Solicitud")
                        .HasColumnType("datetime(6)");

                    b.ToTable("RoomService");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Camarero", b =>
                {
                    b.HasBaseType("Proyecto.Entidades.Usuarios.Persona");

                    b.ToTable("Camarero");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Huesped", b =>
                {
                    b.HasBaseType("Proyecto.Entidades.Usuarios.Persona");

                    b.Property<Guid>("HabitacionIdHabitacion")
                        .HasColumnType("char(36)");

                    b.HasIndex("HabitacionIdHabitacion");

                    b.ToTable("Huesped");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Mucama", b =>
                {
                    b.HasBaseType("Proyecto.Entidades.Usuarios.Persona");

                    b.ToTable("Mucama");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Recepcionista", b =>
                {
                    b.HasBaseType("Proyecto.Entidades.Usuarios.Persona");

                    b.ToTable("Recepcionista");
                });

            modelBuilder.Entity("Proyecto.Entidades.Facturacion.ItemFactura", b =>
                {
                    b.HasOne("Proyecto.Entidades.Facturacion.Factura", null)
                        .WithMany("Items")
                        .HasForeignKey("FacturaIdFactura");
                });

            modelBuilder.Entity("Proyecto.Entidades.Facturacion.RoomCharge", b =>
                {
                    b.HasOne("Proyecto.Entidades.Unidades.Habitacion", null)
                        .WithMany("RoomCharges")
                        .HasForeignKey("HabitacionIdHabitacion");
                });

            modelBuilder.Entity("Proyecto.Entidades.Reservacion.Reserva", b =>
                {
                    b.HasOne("Proyecto.Entidades.Usuarios.Huesped", "Huesped")
                        .WithMany()
                        .HasForeignKey("Huespedid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Entidades.Usuarios.Recepcionista", null)
                        .WithMany("Reservas")
                        .HasForeignKey("Recepcionistaid");

                    b.Navigation("Huesped");
                });

            modelBuilder.Entity("Proyecto.Entidades.Servicios.ServicioLimpieza", b =>
                {
                    b.HasOne("Proyecto.Entidades.Unidades.Habitacion", "habitacion")
                        .WithMany("ServicioLimpiezas")
                        .HasForeignKey("habitacionIdHabitacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("habitacion");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Habitacion", b =>
                {
                    b.HasOne("Proyecto.Entidades.Unidades.Llave", "Llave")
                        .WithMany()
                        .HasForeignKey("LlaveIdLlave")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Entidades.Usuarios.Recepcionista", null)
                        .WithMany("Habitaciones")
                        .HasForeignKey("Recepcionistaid");

                    b.HasOne("Proyecto.Entidades.Unidades.Sede", null)
                        .WithMany("Habitaciones")
                        .HasForeignKey("SedeidSede");

                    b.Navigation("Llave");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Llave", b =>
                {
                    b.HasOne("Proyecto.Entidades.Usuarios.Recepcionista", null)
                        .WithMany("Llaves")
                        .HasForeignKey("Recepcionistaid");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Sede", b =>
                {
                    b.HasOne("Proyecto.Entidades.Unidades.Hotel", null)
                        .WithMany("Sedes")
                        .HasForeignKey("HotelIdHotel");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Persona", b =>
                {
                    b.HasOne("Proyecto.Entidades.Usuarios.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Proyecto.Entidades.Servicios.Amenity", b =>
                {
                    b.HasOne("Proyecto.Entidades.Facturacion.RoomCharge", null)
                        .WithOne()
                        .HasForeignKey("Proyecto.Entidades.Servicios.Amenity", "IdRoomCharge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Entidades.Servicios.KitchenService", b =>
                {
                    b.HasOne("Proyecto.Entidades.Facturacion.RoomCharge", null)
                        .WithOne()
                        .HasForeignKey("Proyecto.Entidades.Servicios.KitchenService", "IdRoomCharge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Entidades.Servicios.RoomService", b =>
                {
                    b.HasOne("Proyecto.Entidades.Facturacion.RoomCharge", null)
                        .WithOne()
                        .HasForeignKey("Proyecto.Entidades.Servicios.RoomService", "IdRoomCharge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Camarero", b =>
                {
                    b.HasOne("Proyecto.Entidades.Usuarios.Persona", null)
                        .WithOne()
                        .HasForeignKey("Proyecto.Entidades.Usuarios.Camarero", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Huesped", b =>
                {
                    b.HasOne("Proyecto.Entidades.Unidades.Habitacion", "Habitacion")
                        .WithMany()
                        .HasForeignKey("HabitacionIdHabitacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Entidades.Usuarios.Persona", null)
                        .WithOne()
                        .HasForeignKey("Proyecto.Entidades.Usuarios.Huesped", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habitacion");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Mucama", b =>
                {
                    b.HasOne("Proyecto.Entidades.Usuarios.Persona", null)
                        .WithOne()
                        .HasForeignKey("Proyecto.Entidades.Usuarios.Mucama", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Recepcionista", b =>
                {
                    b.HasOne("Proyecto.Entidades.Usuarios.Persona", null)
                        .WithOne()
                        .HasForeignKey("Proyecto.Entidades.Usuarios.Recepcionista", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Entidades.Facturacion.Factura", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Habitacion", b =>
                {
                    b.Navigation("RoomCharges");

                    b.Navigation("ServicioLimpiezas");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Hotel", b =>
                {
                    b.Navigation("Sedes");
                });

            modelBuilder.Entity("Proyecto.Entidades.Unidades.Sede", b =>
                {
                    b.Navigation("Habitaciones");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuarios.Recepcionista", b =>
                {
                    b.Navigation("Habitaciones");

                    b.Navigation("Llaves");

                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
