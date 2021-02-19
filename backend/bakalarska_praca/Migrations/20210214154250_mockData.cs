using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class mockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Severity = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dest_ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Src_ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Dest_ip", "Message", "Proto", "Severity", "Src_ip", "Timestamp" },
                values: new object[,]
                {
                    { 1, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 3, "192.168.40.11", new DateTime(2020, 10, 10, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 18, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "192.168.40.11", new DateTime(2020, 10, 27, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 17, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 1, "192.168.40.11", new DateTime(2020, 10, 26, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 16, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 2, "192.168.40.11", new DateTime(2020, 10, 25, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 15, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 2, "192.168.40.11", new DateTime(2020, 10, 24, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 14, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "192.168.40.11", new DateTime(2020, 10, 23, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 13, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 5, "192.168.40.11", new DateTime(2020, 10, 22, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 12, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 7, "192.168.40.11", new DateTime(2020, 10, 21, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 11, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 6, "192.168.40.11", new DateTime(2020, 10, 20, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 10, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 2, "192.168.40.11", new DateTime(2020, 10, 19, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 9, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "192.168.40.11", new DateTime(2020, 10, 18, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 8, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "192.168.40.11", new DateTime(2020, 10, 17, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 7, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 5, "192.168.40.11", new DateTime(2020, 10, 16, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 6, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 5, "192.168.40.11", new DateTime(2020, 10, 15, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 5, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "192.168.40.11", new DateTime(2020, 10, 14, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 4, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "192.168.40.11", new DateTime(2020, 10, 13, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 3, "192.168.40.183", "Error Based SQL Injectio n Detected", "TCP", 3, "192.168.40.11", new DateTime(2020, 10, 12, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 2, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 3, "192.168.40.11", new DateTime(2020, 10, 11, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 19, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 5, "192.168.40.11", new DateTime(2020, 10, 28, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 20, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 6, "192.168.40.11", new DateTime(2020, 10, 29, 14, 17, 49, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attacks");
        }
    }
}
