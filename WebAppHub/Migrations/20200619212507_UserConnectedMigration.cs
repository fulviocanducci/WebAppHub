using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppHub.Migrations
{
    public partial class UserConnectedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user_connected",
                columns: table => new
                {
                    ConnectedId = table.Column<string>(nullable: false),
                    ConnectedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_connected", x => x.ConnectedId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_connected");
        }
    }
}
