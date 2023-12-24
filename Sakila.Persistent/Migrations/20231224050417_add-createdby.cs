using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserMap.Persistent.Migrations
{
    public partial class addcreatedby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Ads",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Ads",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Ads",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Ads",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Ads",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Ads");
        }
    }
}
