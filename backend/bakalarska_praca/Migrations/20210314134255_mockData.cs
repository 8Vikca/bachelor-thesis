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
                value: new DateTime(2021, 2, 20, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2021, 2, 21, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2021, 2, 22, 14, 17, 49, 0, DateTimeKind.Utc));

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
                columns: new[] { "Severity", "Timestamp" },
                values: new object[] { 2, new DateTime(2021, 2, 25, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Severity", "Timestamp" },
                values: new object[] { 1, new DateTime(2021, 2, 26, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2021, 2, 27, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Severity", "Timestamp" },
                values: new object[] { 3, new DateTime(2021, 2, 28, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTime(2021, 3, 1, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTime(2021, 3, 2, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SeverityCategory", "Timestamp" },
                values: new object[] { "high", new DateTime(2021, 3, 3, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Timestamp",
                value: new DateTime(2021, 3, 4, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Timestamp",
                value: new DateTime(2021, 3, 5, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Timestamp",
                value: new DateTime(2021, 3, 6, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Timestamp",
                value: new DateTime(2021, 3, 7, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Timestamp",
                value: new DateTime(2021, 3, 8, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "Timestamp",
                value: new DateTime(2021, 3, 9, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "Timestamp",
                value: new DateTime(2021, 3, 10, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "Timestamp",
                value: new DateTime(2021, 3, 11, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 21,
                column: "Timestamp",
                value: new DateTime(2021, 3, 12, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 22,
                column: "Timestamp",
                value: new DateTime(2021, 3, 13, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 23,
                column: "Timestamp",
                value: new DateTime(2021, 3, 14, 20, 17, 49, 0, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2021, 2, 10, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2021, 2, 11, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTime(2021, 2, 12, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTime(2021, 2, 13, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTime(2021, 2, 14, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Severity", "Timestamp" },
                values: new object[] { 5, new DateTime(2021, 2, 15, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Severity", "Timestamp" },
                values: new object[] { 5, new DateTime(2021, 2, 16, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTime(2021, 2, 17, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Severity", "Timestamp" },
                values: new object[] { 4, new DateTime(2021, 2, 18, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTime(2021, 2, 19, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTime(2021, 2, 20, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SeverityCategory", "Timestamp" },
                values: new object[] { "low", new DateTime(2021, 2, 21, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Timestamp",
                value: new DateTime(2021, 2, 22, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Timestamp",
                value: new DateTime(2021, 2, 23, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Timestamp",
                value: new DateTime(2021, 2, 24, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Timestamp",
                value: new DateTime(2021, 2, 25, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Timestamp",
                value: new DateTime(2021, 2, 26, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "Timestamp",
                value: new DateTime(2021, 2, 27, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "Timestamp",
                value: new DateTime(2021, 2, 28, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "Timestamp",
                value: new DateTime(2021, 2, 9, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 21,
                column: "Timestamp",
                value: new DateTime(2021, 2, 8, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 22,
                column: "Timestamp",
                value: new DateTime(2021, 3, 1, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 23,
                column: "Timestamp",
                value: new DateTime(2021, 3, 1, 20, 17, 49, 0, DateTimeKind.Utc));
        }
    }
}
