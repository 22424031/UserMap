using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserMap.Persistent.Migrations
{
    public partial class addisDeletedtoDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Ads",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Ads");
        }
    }
}
