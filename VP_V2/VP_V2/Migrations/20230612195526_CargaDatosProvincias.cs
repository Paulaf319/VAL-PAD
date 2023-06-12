using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VP_V2.Migrations
{
    /// <inheritdoc />
    public partial class CargaDatosProvincias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "IdProv", "Nom_Prov" },
                values: new object[,]
                {
                    { 55, "Buenos Aires" },
                    { 56, "Catamarca" },
                    { 57, "Chaco" },
                    { 58, "Chubut" },
                    { 59, "Cordoba" },
                    { 60, "Corrientes" },
                    { 61, "Entre Rios" },
                    { 62, "Formosa" },
                    { 63, "Jujuy" },
                    { 64, "La Pampa" },
                    { 65, "La Rioja" },
                    { 66, "Mendoza" },
                    { 67, "Misiones" },
                    { 68, "Neuquen" },
                    { 69, "Rio Negro" },
                    { 70, "Salta" },
                    { 71, "San Juan" },
                    { 72, "San Luis" },
                    { 73, "Santa Cruz" },
                    { 74, "Santa Fe" },
                    { 75, "Santiago del Estero" },
                    { 76, "Tierra del Fuego" },
                    { 77, "Tucuman" },
                    { 78, "Capital Federal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProv",
                keyValue: 78);
        }
    }
}
