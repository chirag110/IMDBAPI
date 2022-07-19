using Microsoft.EntityFrameworkCore.Migrations;

namespace IMDBAPI.Migrations
{
    public partial class IMDBMigrationsAddedProducerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProducerName",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProducerName",
                table: "Movies");
        }
    }
}
