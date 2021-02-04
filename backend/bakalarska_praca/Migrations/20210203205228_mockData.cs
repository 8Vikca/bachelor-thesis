using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class mockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2020, 10, 10, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2020, 10, 11, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2020, 10, 12, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2020, 10, 13, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2020, 10, 14, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2020, 10, 15, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2020, 10, 16, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2020, 10, 17, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2020, 10, 18, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTime(2020, 10, 19, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTime(2020, 10, 20, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Timestamp",
                value: new DateTime(2020, 10, 22, 15, 17, 49, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2020, 10, 22, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2020, 10, 23, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Timestamp",
                value: new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified));
        }
    }
}
