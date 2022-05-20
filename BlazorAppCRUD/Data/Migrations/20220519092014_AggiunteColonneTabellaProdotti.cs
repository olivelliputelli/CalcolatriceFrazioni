using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppCRUD.Data.Migrations
{
    public partial class AggiunteColonneTabellaProdotti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNuovo",
                table: "Prodotti",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Iva",
                table: "Prodotti",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNuovo",
                table: "Prodotti");

            migrationBuilder.DropColumn(
                name: "Iva",
                table: "Prodotti");
        }
    }
}
