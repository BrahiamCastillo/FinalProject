using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Seeds_Sangre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sangre",
                columns: new[] { "idSangre", "Sangre" },
                values: new object[,]
                {
                    { 1, "O+" },
                    { 2, "O-" },
                    { 3, "A+" },
                    { 4, "A-" },
                    { 5, "B+" },
                    { 6, "B-" },
                    { 7, "AB+" },
                    { 8, "AB-" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "idSangre",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "idSangre",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "idSangre",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "idSangre",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "idSangre",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "idSangre",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "idSangre",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "idSangre",
                keyValue: 8);
        }
    }
}
