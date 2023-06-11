using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VP_V2.Migrations
{
    /// <inheritdoc />
    public partial class VP1002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalidadIdLoc",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Prod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Precio_Costo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Precio_Venta = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Fecha_Baja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProd);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    IdProv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Prov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.IdProv);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    IdLoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_Postal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nom_Ciudad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProvinciaIdProv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.IdLoc);
                    table.ForeignKey(
                        name: "FK_Localidades_Provincias_ProvinciaIdProv",
                        column: x => x.ProvinciaIdProv,
                        principalTable: "Provincias",
                        principalColumn: "IdProv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LocalidadIdLoc",
                table: "Clientes",
                column: "LocalidadIdLoc");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_ProvinciaIdProv",
                table: "Localidades",
                column: "ProvinciaIdProv");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Localidades_LocalidadIdLoc",
                table: "Clientes",
                column: "LocalidadIdLoc",
                principalTable: "Localidades",
                principalColumn: "IdLoc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Localidades_LocalidadIdLoc",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_LocalidadIdLoc",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "LocalidadIdLoc",
                table: "Clientes");
        }
    }
}
