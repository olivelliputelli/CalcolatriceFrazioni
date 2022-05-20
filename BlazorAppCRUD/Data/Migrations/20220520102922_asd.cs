using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppCRUD.Data.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImmagineSrc",
                table: "Categorie");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Prodotti",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Prodotti");

            migrationBuilder.AddColumn<string>(
                name: "ImmagineSrc",
                table: "Categorie",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
