using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserMap.Persistent.Migrations
{
    public partial class rename_lastupdate_toModifierDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "last_update",
                table: "Ads",
                newName: "ModifiedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Ads",
                newName: "last_update");
        }
    }
}
