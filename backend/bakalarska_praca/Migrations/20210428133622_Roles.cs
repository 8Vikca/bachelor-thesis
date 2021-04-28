using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2021, 3, 20, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2021, 3, 20, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2021, 3, 20, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2021, 3, 23, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2021, 3, 24, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2021, 3, 25, 7, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2021, 3, 25, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2021, 4, 5, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2021, 4, 5, 17, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTime(2021, 4, 5, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTime(2021, 4, 9, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Timestamp",
                value: new DateTime(2021, 4, 10, 12, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Timestamp",
                value: new DateTime(2021, 4, 10, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Timestamp",
                value: new DateTime(2021, 4, 11, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Timestamp",
                value: new DateTime(2021, 4, 11, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Timestamp",
                value: new DateTime(2021, 4, 12, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Timestamp",
                value: new DateTime(2021, 4, 13, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "Timestamp",
                value: new DateTime(2021, 4, 14, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "Timestamp",
                value: new DateTime(2021, 4, 15, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "Timestamp",
                value: new DateTime(2021, 4, 15, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 21,
                column: "Timestamp",
                value: new DateTime(2021, 4, 16, 8, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 22,
                column: "Timestamp",
                value: new DateTime(2021, 4, 17, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 23,
                column: "Timestamp",
                value: new DateTime(2021, 4, 17, 23, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 24,
                column: "Timestamp",
                value: new DateTime(2021, 4, 19, 3, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 25,
                column: "Timestamp",
                value: new DateTime(2021, 4, 19, 8, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 26,
                column: "Timestamp",
                value: new DateTime(2021, 4, 20, 8, 45, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 27,
                column: "Timestamp",
                value: new DateTime(2021, 4, 21, 19, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 28,
                column: "Timestamp",
                value: new DateTime(2021, 4, 22, 8, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 29,
                column: "Timestamp",
                value: new DateTime(2021, 4, 23, 8, 45, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 30,
                column: "Timestamp",
                value: new DateTime(2021, 4, 24, 19, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 31,
                column: "Timestamp",
                value: new DateTime(2021, 4, 25, 8, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 32,
                column: "Timestamp",
                value: new DateTime(2021, 4, 26, 8, 45, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 33,
                column: "Timestamp",
                value: new DateTime(2021, 4, 28, 23, 17, 49, 0, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Logins");

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2021, 2, 20, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2021, 2, 20, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2021, 2, 20, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2021, 2, 23, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2021, 2, 24, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2021, 2, 25, 7, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2021, 2, 25, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2021, 3, 5, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2021, 3, 5, 18, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTime(2021, 3, 5, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTime(2021, 3, 9, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Timestamp",
                value: new DateTime(2021, 3, 10, 13, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Timestamp",
                value: new DateTime(2021, 3, 10, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Timestamp",
                value: new DateTime(2021, 3, 11, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Timestamp",
                value: new DateTime(2021, 3, 11, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Timestamp",
                value: new DateTime(2021, 3, 12, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Timestamp",
                value: new DateTime(2021, 3, 13, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "Timestamp",
                value: new DateTime(2021, 3, 14, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "Timestamp",
                value: new DateTime(2021, 3, 15, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "Timestamp",
                value: new DateTime(2021, 3, 15, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 21,
                column: "Timestamp",
                value: new DateTime(2021, 3, 16, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 22,
                column: "Timestamp",
                value: new DateTime(2021, 3, 17, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 23,
                column: "Timestamp",
                value: new DateTime(2021, 3, 18, 0, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 24,
                column: "Timestamp",
                value: new DateTime(2021, 3, 19, 4, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 25,
                column: "Timestamp",
                value: new DateTime(2021, 3, 19, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 26,
                column: "Timestamp",
                value: new DateTime(2021, 3, 20, 9, 45, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 27,
                column: "Timestamp",
                value: new DateTime(2021, 3, 21, 20, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 28,
                column: "Timestamp",
                value: new DateTime(2021, 3, 22, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 29,
                column: "Timestamp",
                value: new DateTime(2021, 3, 23, 9, 45, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 30,
                column: "Timestamp",
                value: new DateTime(2021, 3, 24, 20, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 31,
                column: "Timestamp",
                value: new DateTime(2021, 3, 25, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 32,
                column: "Timestamp",
                value: new DateTime(2021, 3, 26, 9, 45, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 33,
                column: "Timestamp",
                value: new DateTime(2021, 3, 28, 23, 17, 49, 0, DateTimeKind.Utc));
        }
    }
}
