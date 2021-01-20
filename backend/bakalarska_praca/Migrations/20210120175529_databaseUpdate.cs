using Microsoft.EntityFrameworkCore.Migrations;

namespace bakalarska_praca.Migrations
{
    public partial class databaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Attacks",
                newName: "Proto");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Attacks",
                newName: "Timestamp");

            migrationBuilder.AddColumn<string>(
                name: "Dest_ip",
                table: "Attacks",
                type: "nvarchar(45)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Severity",
                table: "Attacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Src_ip",
                table: "Attacks",
                type: "nvarchar(45)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dest_ip",
                table: "Attacks");

            migrationBuilder.DropColumn(
                name: "Severity",
                table: "Attacks");

            migrationBuilder.DropColumn(
                name: "Src_ip",
                table: "Attacks");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Attacks",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "Proto",
                table: "Attacks",
                newName: "Name");
        }
    }
}
