using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentacion.Persistencia.Migraciones
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    IdFactura = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    numero = table.Column<int>(type: "int", nullable: false),
                    fechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    monto = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.IdFactura);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    IdHotel = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ubicacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.IdHotel);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contraseña = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemaFactura",
                columns: table => new
                {
                    IdItemFactura = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Monto = table.Column<double>(type: "double", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FacturaIdFactura = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemaFactura", x => x.IdItemFactura);
                    table.ForeignKey(
                        name: "FK_ItemaFactura_Factura_FacturaIdFactura",
                        column: x => x.FacturaIdFactura,
                        principalTable: "Factura",
                        principalColumn: "IdFactura");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    idSede = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ubicacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HotelIdHotel = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.idSede);
                    table.ForeignKey(
                        name: "FK_Sede_Hotel_HotelIdHotel",
                        column: x => x.HotelIdHotel,
                        principalTable: "Hotel",
                        principalColumn: "IdHotel");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Domicilio = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUsuario = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id);
                    table.ForeignKey(
                        name: "FK_Persona_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Camarero",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camarero", x => x.id);
                    table.ForeignKey(
                        name: "FK_Camarero_Persona_id",
                        column: x => x.id,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mucama",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mucama", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mucama_Persona_id",
                        column: x => x.id,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Recepcionista",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepcionista", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recepcionista_Persona_id",
                        column: x => x.id,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Llave",
                columns: table => new
                {
                    IdLlave = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    numero = table.Column<int>(type: "int", nullable: false),
                    codigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Recepcionistaid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llave", x => x.IdLlave);
                    table.ForeignKey(
                        name: "FK_Llave_Recepcionista_Recepcionistaid",
                        column: x => x.Recepcionistaid,
                        principalTable: "Recepcionista",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Habitacion",
                columns: table => new
                {
                    IdHabitacion = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    PrecioReserva = table.Column<double>(type: "double", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    LlaveIdLlave = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Recepcionistaid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SedeidSede = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitacion", x => x.IdHabitacion);
                    table.ForeignKey(
                        name: "FK_Habitacion_Llave_LlaveIdLlave",
                        column: x => x.LlaveIdLlave,
                        principalTable: "Llave",
                        principalColumn: "IdLlave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Habitacion_Recepcionista_Recepcionistaid",
                        column: x => x.Recepcionistaid,
                        principalTable: "Recepcionista",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Habitacion_Sede_SedeidSede",
                        column: x => x.SedeidSede,
                        principalTable: "Sede",
                        principalColumn: "idSede");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Huesped",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    HabitacionIdHabitacion = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huesped", x => x.id);
                    table.ForeignKey(
                        name: "FK_Huesped_Habitacion_HabitacionIdHabitacion",
                        column: x => x.HabitacionIdHabitacion,
                        principalTable: "Habitacion",
                        principalColumn: "IdHabitacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Huesped_Persona_id",
                        column: x => x.id,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomCharge",
                columns: table => new
                {
                    IdRoomCharge = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    monto = table.Column<double>(type: "double", nullable: false),
                    HabitacionIdHabitacion = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCharge", x => x.IdRoomCharge);
                    table.ForeignKey(
                        name: "FK_RoomCharge_Habitacion_HabitacionIdHabitacion",
                        column: x => x.HabitacionIdHabitacion,
                        principalTable: "Habitacion",
                        principalColumn: "IdHabitacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServicioLimpieza",
                columns: table => new
                {
                    IdServicioLimpieza = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comienzo = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    habitacionIdHabitacion = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioLimpieza", x => x.IdServicioLimpieza);
                    table.ForeignKey(
                        name: "FK_ServicioLimpieza_Habitacion_habitacionIdHabitacion",
                        column: x => x.habitacionIdHabitacion,
                        principalTable: "Habitacion",
                        principalColumn: "IdHabitacion",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    IdReserva = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaReserva = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaHospedaje = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Huespedid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Recepcionistaid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Huesped_Huespedid",
                        column: x => x.Huespedid,
                        principalTable: "Huesped",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Recepcionista_Recepcionistaid",
                        column: x => x.Recepcionistaid,
                        principalTable: "Recepcionista",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Amenity",
                columns: table => new
                {
                    IdRoomCharge = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenity", x => x.IdRoomCharge);
                    table.ForeignKey(
                        name: "FK_Amenity_RoomCharge_IdRoomCharge",
                        column: x => x.IdRoomCharge,
                        principalTable: "RoomCharge",
                        principalColumn: "IdRoomCharge",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KitchenService",
                columns: table => new
                {
                    IdRoomCharge = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitchenService", x => x.IdRoomCharge);
                    table.ForeignKey(
                        name: "FK_KitchenService_RoomCharge_IdRoomCharge",
                        column: x => x.IdRoomCharge,
                        principalTable: "RoomCharge",
                        principalColumn: "IdRoomCharge",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomService",
                columns: table => new
                {
                    IdRoomCharge = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Solicitud = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SeCobra = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomService", x => x.IdRoomCharge);
                    table.ForeignKey(
                        name: "FK_RoomService_RoomCharge_IdRoomCharge",
                        column: x => x.IdRoomCharge,
                        principalTable: "RoomCharge",
                        principalColumn: "IdRoomCharge",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Habitacion_LlaveIdLlave",
                table: "Habitacion",
                column: "LlaveIdLlave");

            migrationBuilder.CreateIndex(
                name: "IX_Habitacion_Recepcionistaid",
                table: "Habitacion",
                column: "Recepcionistaid");

            migrationBuilder.CreateIndex(
                name: "IX_Habitacion_SedeidSede",
                table: "Habitacion",
                column: "SedeidSede");

            migrationBuilder.CreateIndex(
                name: "IX_Huesped_HabitacionIdHabitacion",
                table: "Huesped",
                column: "HabitacionIdHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_ItemaFactura_FacturaIdFactura",
                table: "ItemaFactura",
                column: "FacturaIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_Llave_Recepcionistaid",
                table: "Llave",
                column: "Recepcionistaid");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_UsuarioIdUsuario",
                table: "Persona",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_Huespedid",
                table: "Reserva",
                column: "Huespedid");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_Recepcionistaid",
                table: "Reserva",
                column: "Recepcionistaid");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharge_HabitacionIdHabitacion",
                table: "RoomCharge",
                column: "HabitacionIdHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_HotelIdHotel",
                table: "Sede",
                column: "HotelIdHotel");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioLimpieza_habitacionIdHabitacion",
                table: "ServicioLimpieza",
                column: "habitacionIdHabitacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenity");

            migrationBuilder.DropTable(
                name: "Camarero");

            migrationBuilder.DropTable(
                name: "ItemaFactura");

            migrationBuilder.DropTable(
                name: "KitchenService");

            migrationBuilder.DropTable(
                name: "Mucama");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "RoomService");

            migrationBuilder.DropTable(
                name: "ServicioLimpieza");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Huesped");

            migrationBuilder.DropTable(
                name: "RoomCharge");

            migrationBuilder.DropTable(
                name: "Habitacion");

            migrationBuilder.DropTable(
                name: "Llave");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "Recepcionista");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
