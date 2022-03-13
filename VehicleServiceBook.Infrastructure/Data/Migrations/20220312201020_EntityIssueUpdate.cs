using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleServiceBook.Infrastructure.Data.Migrations
{
    public partial class EntityIssueUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarOdometer",
                table: "Issues",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarOdometer",
                table: "Issues");
        }
    }
}
