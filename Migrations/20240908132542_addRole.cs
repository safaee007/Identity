using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity_SampleProject.Migrations
{
    public partial class addRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73273232-17d6-48c8-b0cd-d926ce31772c", "11", "Admin", "Admin" });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5ed6b19-be15-4299-b26a-20c6d9f09a19", "10", "SuperAdmin", "SuperAdmin" });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db911b7f-3d7c-4889-866b-ff9f589b6599", "12", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73273232-17d6-48c8-b0cd-d926ce31772c");

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5ed6b19-be15-4299-b26a-20c6d9f09a19");

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db911b7f-3d7c-4889-866b-ff9f589b6599");
        }
    }
}
