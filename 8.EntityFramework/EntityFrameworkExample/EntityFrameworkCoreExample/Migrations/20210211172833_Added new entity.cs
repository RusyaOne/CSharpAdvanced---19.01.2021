using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreExample.Migrations
{
    public partial class Addednewentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoryId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_StoryId",
                table: "Characters",
                column: "StoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Stories_StoryId",
                table: "Characters",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Stories_StoryId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Characters_StoryId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StoryId",
                table: "Characters");
        }
    }
}
