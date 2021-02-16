using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreExample.Migrations
{
    public partial class Addedconfigurationwithfluentapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Creators");

            migrationBuilder.RenameColumn(
                name: "AuthorIdentifier",
                table: "Creators",
                newName: "CreatorId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Creators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Creators",
                table: "Creators",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Creators",
                table: "Creators");

            migrationBuilder.RenameTable(
                name: "Creators",
                newName: "Authors");

            migrationBuilder.RenameColumn(
                name: "CreatorId",
                table: "Authors",
                newName: "AuthorIdentifier");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "AuthorIdentifier");
        }
    }
}
