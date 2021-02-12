using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreExample.Migrations
{
    public partial class Seedinitialdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "", "Foundation" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "", "LOTR" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "", "Hyperion" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "FirstName", "Gender", "LastName", "StoryId" },
                values: new object[] { 1, 35, "Harry", true, "Seldon", 1 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "FirstName", "Gender", "LastName", "StoryId" },
                values: new object[] { 2, 2700, "Arven", false, "Undomiel", 2 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "FirstName", "Gender", "LastName", "StoryId" },
                values: new object[] { 3, 14, "Finn", true, "Mertens", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
