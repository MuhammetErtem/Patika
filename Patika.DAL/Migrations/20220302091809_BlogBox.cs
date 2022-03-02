using Microsoft.EntityFrameworkCore.Migrations;

namespace Patika.DAL.Migrations
{
    public partial class BlogBox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Blog");

            migrationBuilder.CreateTable(
                name: "BlogPicture",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Path = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    BlogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPicture", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BlogPicture_Blog_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPicture_BlogID",
                table: "BlogPicture",
                column: "BlogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPicture");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Blog",
                type: "varchar(150)",
                maxLength: 150,
                nullable: true);
        }
    }
}
