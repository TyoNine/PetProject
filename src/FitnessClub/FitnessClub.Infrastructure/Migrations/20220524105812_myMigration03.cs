using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessClub.Infrastructure.Migrations
{
    public partial class myMigration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Booking");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Booking",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
