using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class mockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Src_ip",
                table: "Attacks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dest_ip",
                table: "Attacks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Dest_ip", "Message", "Proto", "Severity", "Src_ip", "Timestamp" },
                values: new object[] { 1, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 3, "192.168.40.11", new DateTime(2020, 10, 21, 15, 17, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Dest_ip", "Message", "Proto", "Severity", "Src_ip", "Timestamp" },
                values: new object[] { 2, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 3, "192.168.40.11", new DateTime(2020, 10, 22, 15, 17, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Dest_ip", "Message", "Proto", "Severity", "Src_ip", "Timestamp" },
                values: new object[] { 3, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 3, "192.168.40.11", new DateTime(2020, 10, 23, 15, 17, 49, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Src_ip",
                table: "Attacks",
                type: "nvarchar(45)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dest_ip",
                table: "Attacks",
                type: "nvarchar(45)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
