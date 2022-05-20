using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppCRUD.Data.Migrations
{
    public partial class AggiuntaColonnadescrizone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descrizione",
                table: "Prodotti",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrizione",
                table: "Prodotti");
        }
    }
}
