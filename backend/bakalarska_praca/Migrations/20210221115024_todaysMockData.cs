using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class todaysMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Dest_ip", "Message", "Proto", "Severity", "Src_ip", "Timestamp" },
                values: new object[] { 21, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 6, "192.168.40.11", new DateTime(2021, 2, 21, 9, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Dest_ip", "Message", "Proto", "Severity", "Src_ip", "Timestamp" },
                values: new object[] { 22, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 6, "192.168.40.11", new DateTime(2021, 2, 21, 14, 17, 49, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Dest_ip", "Message", "Proto", "Severity", "Src_ip", "Timestamp" },
                values: new object[] { 23, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 6, "192.168.40.11", new DateTime(2021, 2, 21, 20, 17, 49, 0, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
