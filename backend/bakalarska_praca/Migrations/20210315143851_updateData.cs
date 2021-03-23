using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 23,
                column: "Timestamp",
                value: new DateTime(2021, 3, 14, 0, 17, 49, 0, DateTimeKind.Utc));

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Category", "Dest_ip", "Message", "Proto", "Severity", "SeverityCategory", "Src_ip", "Timestamp" },
                values: new object[,]
                {
                    { 24, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 8, "high", "192.168.40.11", new DateTime(2021, 3, 14, 4, 17, 49, 0, DateTimeKind.Utc) },
                    { 25, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "high", "192.168.40.11", new DateTime(2021, 3, 14, 9, 17, 49, 0, DateTimeKind.Utc) },
                    { 26, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "UDP", 1, "low", "192.168.60.11", new DateTime(2021, 3, 14, 9, 45, 49, 0, DateTimeKind.Utc) },
                    { 27, "SYN", "192.168.40.183", "Possible TCP SYN DoS", "TCP", 9, "critical", "192.168.70.11", new DateTime(2021, 3, 14, 20, 17, 49, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 23,
                column: "Timestamp",
                value: new DateTime(2021, 3, 14, 20, 17, 49, 0, DateTimeKind.Utc));
        }
    }
}
