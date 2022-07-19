using Microsoft.EntityFrameworkCore.Migrations;

namespace IMDBAPI.Migrations
{
    public partial class IMDBMigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProducerName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActorName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProducerName",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "ActorName",
                table: "Actors");
        }
    }
}
