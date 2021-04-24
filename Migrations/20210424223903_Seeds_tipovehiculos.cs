using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Seeds_tipovehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TipoVehiculos",
                columns: new[] { "idTipoVehiculos", "tipo" },
                values: new object[,]
                {
                    { 1, "Carro" },
                    { 2, "Camioneta" },
                    { 3, "Jeep" },
                    { 4, "De lujo" },
                    { 5, "Nave espacial" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoVehiculos",
                keyColumn: "idTipoVehiculos",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoVehiculos",
                keyColumn: "idTipoVehiculos",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoVehiculos",
                keyColumn: "idTipoVehiculos",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoVehiculos",
                keyColumn: "idTipoVehiculos",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoVehiculos",
                keyColumn: "idTipoVehiculos",
                keyValue: 5);
        }
    }
}
