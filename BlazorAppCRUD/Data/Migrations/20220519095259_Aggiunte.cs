using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppCRUD.Data.Migrations
{
    public partial class Aggiunte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsNuovo",
                table: "Prodotti",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImmagineSrc",
                table: "Categorie",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImmagineSrc",
                table: "Categorie");

            migrationBuilder.AlterColumn<bool>(
                name: "IsNuovo",
                table: "Prodotti",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
