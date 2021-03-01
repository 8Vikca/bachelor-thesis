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
                    Proto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeverityCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Category", "Dest_ip", "Message", "Proto", "Severity", "SeverityCategory", "Src_ip", "Timestamp" },
                values: new object[,]
                {
                    { 1, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 3, "low", "192.168.40.11", new DateTime(2021, 2, 10, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 21, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "high", "192.168.40.11", new DateTime(2021, 2, 8, 9, 17, 49, 0, DateTimeKind.Utc) },
                    { 20, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 8, "high", "192.168.40.11", new DateTime(2021, 2, 9, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 19, "UDP", "192.168.50.183", "Possible UDP DoS", "TCP", 2, "low", "192.168.40.11", new DateTime(2021, 2, 28, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 18, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 9, "critical", "192.168.40.11", new DateTime(2021, 2, 27, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 17, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "UDP", 4, "medium", "192.168.40.11", new DateTime(2021, 2, 26, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 16, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 1, "low", "192.168.30.11", new DateTime(2021, 2, 25, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 15, "SYN", "192.168.40.183", "Possible TCP SYN DoS", "TCP", 2, "low", "192.168.40.11", new DateTime(2021, 2, 24, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 14, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "UDP", 7, "high", "192.168.40.11", new DateTime(2021, 2, 23, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 13, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 5, "medium", "192.168.20.11", new DateTime(2021, 2, 22, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 22, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "UDP", 1, "low", "192.168.60.11", new DateTime(2021, 3, 1, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 12, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "low", "192.168.40.11", new DateTime(2021, 2, 21, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 10, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 2, "low", "192.168.20.11", new DateTime(2021, 2, 19, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 9, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "low", "192.168.30.11", new DateTime(2021, 2, 18, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 8, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "UDP", 4, "medium", "192.168.20.11", new DateTime(2021, 2, 17, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 7, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 5, "low", "192.168.60.11", new DateTime(2021, 2, 16, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 6, "SYN", "192.168.60.183", "Possible TCP SYN DoS", "TCP", 5, "low", "192.168.40.11", new DateTime(2021, 2, 15, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 5, "SQL", "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "medium", "192.168.60.11", new DateTime(2021, 2, 14, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 4, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 4, "medium", "192.168.60.11", new DateTime(2021, 2, 13, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 3, "SQL", "192.168.40.183", "Error Based SQL Injectio n Detected", "UDP", 3, "low", "192.168.50.11", new DateTime(2021, 2, 12, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 2, "ICMP", "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 10, "critical", "192.168.50.11", new DateTime(2021, 2, 11, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 11, "UDP", "192.168.40.183", "Possible UDP DoS", "TCP", 6, "medium", "192.168.40.11", new DateTime(2021, 2, 20, 14, 17, 49, 0, DateTimeKind.Utc) },
                    { 23, "SYN", "192.168.40.183", "Possible TCP SYN DoS", "TCP", 9, "critical", "192.168.70.11", new DateTime(2021, 3, 1, 20, 17, 49, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attacks");
        }
    }
}
