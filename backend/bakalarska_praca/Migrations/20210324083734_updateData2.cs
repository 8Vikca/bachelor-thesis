using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class updateData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Category", "Dest_ip", "Message", "Proto", "Severity", "SeverityCategory", "Src_ip", "Timestamp" },
                values: new object[,]
                {
                    { 35, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "UDP", 1, "low", "192.168.60.11", new DateTime(2021, 3, 29, 17, 45, 49, 0, DateTimeKind.Utc) },
                    { 34, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "high", "192.168.40.11", new DateTime(2021, 3, 29, 8, 17, 49, 0, DateTimeKind.Utc) },
                    { 33, "SYN", "192.168.40.183", "Possible TCP SYN DoS", "TCP", 9, "critical", "192.168.70.11", new DateTime(2021, 3, 28, 23, 17, 49, 0, DateTimeKind.Utc) },
                    { 32, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "UDP", 1, "low", "192.168.60.11", new DateTime(2021, 3, 26, 9, 45, 49, 0, DateTimeKind.Utc) },
                    { 31, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "high", "192.168.40.11", new DateTime(2021, 3, 25, 9, 17, 49, 0, DateTimeKind.Utc) },
                    { 30, "SYN", "192.168.40.183", "Possible TCP SYN DoS", "TCP", 9, "critical", "192.168.70.11", new DateTime(2021, 3, 24, 20, 17, 49, 0, DateTimeKind.Utc) },
                    { 29, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "UDP", 1, "low", "192.168.60.11", new DateTime(2021, 3, 23, 9, 45, 49, 0, DateTimeKind.Utc) },
                    { 36, "SYN", "192.168.40.183", "Possible TCP SYN DoS", "TCP", 9, "critical", "192.168.70.11", new DateTime(2021, 3, 30, 19, 17, 49, 0, DateTimeKind.Utc) },
                    { 28, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "high", "192.168.40.11", new DateTime(2021, 3, 22, 9, 17, 49, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 36);

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
                keyValue: 6,
                column: "Timestamp",
                value: new DateTime(2021, 2, 25, 14, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTime(2021, 2, 26, 14, 17, 49, 0, DateTimeKind.Utc));

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
                column: "Timestamp",
                value: new DateTime(2021, 2, 28, 14, 17, 49, 0, DateTimeKind.Utc));

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
                column: "Timestamp",
                value: new DateTime(2021, 3, 3, 14, 17, 49, 0, DateTimeKind.Utc));

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
                value: new DateTime(2021, 3, 14, 0, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 24,
                column: "Timestamp",
                value: new DateTime(2021, 3, 14, 4, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 25,
                column: "Timestamp",
                value: new DateTime(2021, 3, 14, 9, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 26,
                column: "Timestamp",
                value: new DateTime(2021, 3, 14, 9, 45, 49, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 27,
                column: "Timestamp",
                value: new DateTime(2021, 3, 14, 20, 17, 49, 0, DateTimeKind.Utc));
        }
    }
}
