using Microsoft.EntityFrameworkCore.Migrations;

namespace Patika.DAL.Migrations
{
    public partial class Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Country",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Country");
        }
    }
}
