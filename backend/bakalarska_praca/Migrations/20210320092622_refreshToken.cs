using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    /// <summary>Migration <c>refreshToken</c> adds refresh Token in database</summary>
    public partial class refreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Logins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "Logins");
        }
    }
}
