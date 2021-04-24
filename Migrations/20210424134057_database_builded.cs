using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class database_builded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idClientes = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cedula = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    nombre = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    apellido = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    correo = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    licencia = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    nacionalidad = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    tipodesangre = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fotopersona = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fotolicencia = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    status = table.Column<sbyte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idClientes);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculos",
                columns: table => new
                {
                    idTipoVehiculos = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idTipoVehiculos);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    idVehiculos = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoVehiculos_idTipoVehiculos = table.Column<int>(nullable: false),
                    marca = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    modelo = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    año = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    color = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    precio = table.Column<float>(nullable: false),
                    capacidadcarga = table.Column<float>(nullable: false),
                    pasajeros = table.Column<int>(nullable: false),
                    nroseguro = table.Column<int>(nullable: false),
                    foto = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    disponible = table.Column<sbyte>(nullable: false, defaultValueSql: "'1'"),
                    status = table.Column<sbyte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idVehiculos);
                    table.ForeignKey(
                        name: "fk_Vehiculos_TipoVehiculos1",
                        column: x => x.TipoVehiculos_idTipoVehiculos,
                        principalTable: "TipoVehiculos",
                        principalColumn: "idTipoVehiculos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alquileres",
                columns: table => new
                {
                    idAlquileres = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Clientes_idClientes = table.Column<int>(nullable: false),
                    Vehiculos_idVehiculos = table.Column<int>(nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "date", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "date", nullable: false),
                    monto = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.idAlquileres, x.Clientes_idClientes })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_Alquileres_Clientes1",
                        column: x => x.Clientes_idClientes,
                        principalTable: "Clientes",
                        principalColumn: "idClientes",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Alquileres_Vehiculos1",
                        column: x => x.Vehiculos_idVehiculos,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_Alquileres_Clientes1_idx",
                table: "Alquileres",
                column: "Clientes_idClientes");

            migrationBuilder.CreateIndex(
                name: "fk_Alquileres_Vehiculos1_idx",
                table: "Alquileres",
                column: "Vehiculos_idVehiculos");

            migrationBuilder.CreateIndex(
                name: "fk_Vehiculos_TipoVehiculos1_idx",
                table: "Vehiculos",
                column: "TipoVehiculos_idTipoVehiculos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquileres");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "TipoVehiculos");
        }
    }
}
