using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class mockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Dest_ip", "Message", "Proto", "Severity", "Src_ip", "Timestamp" },
                values: new object[,]
                {
                    { 1, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 3, "192.168.40.11", new DateTime(2020, 10, 10, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 2, "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "192.168.40.11", new DateTime(2020, 10, 11, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 3, "192.168.40.183", "Possible TCP SYN DoS", "TCP", 3, "192.168.40.11", new DateTime(2020, 10, 12, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 4, "192.168.40.183", "Possible UDP DoS", "TCP", 4, "192.168.40.11", new DateTime(2020, 10, 13, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 5, "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "192.168.40.11", new DateTime(2020, 10, 14, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 6, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 5, "192.168.40.11", new DateTime(2020, 10, 15, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 7, "192.168.40.183", "Possible TCP SYN DoS", "TCP", 5, "192.168.40.11", new DateTime(2020, 10, 16, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 8, "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "192.168.40.11", new DateTime(2020, 10, 17, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 9, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 4, "192.168.40.11", new DateTime(2020, 10, 18, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 10, "192.168.40.183", "Error Based SQL Injection Detected", "TCP", 2, "192.168.40.11", new DateTime(2020, 10, 19, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 11, "192.168.40.183", "Possible TCP SYN DoS", "TCP", 2, "192.168.40.11", new DateTime(2020, 10, 20, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 12, "192.168.40.183", "Possible ICMP flood PING DoS", "TCP", 7, "192.168.40.11", new DateTime(2020, 10, 21, 13, 17, 49, 0, DateTimeKind.Utc) },
                    { 13, "192.168.40.183", "Possible UDP DoS", "TCP", 2, "192.168.40.11", new DateTime(2020, 10, 22, 13, 17, 49, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attacks");
        }
    }
}
