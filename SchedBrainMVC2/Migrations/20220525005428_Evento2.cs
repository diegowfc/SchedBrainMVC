using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedBrainMVC2.Migrations
{
    public partial class Evento2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contato",
                table: "Eventos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contato",
                table: "Eventos");
        }
    }
}
