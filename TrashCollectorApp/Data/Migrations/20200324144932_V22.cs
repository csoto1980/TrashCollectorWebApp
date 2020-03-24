using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21c94d8f-0b15-4f51-9ff1-0f649a624948");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39ba61b3-a7f7-49b0-a9c4-444912b668f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca359656-6bef-4cc3-b986-5499cf4c151d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "804b703c-a0ac-473e-9965-6479c6adea09", "0f8fd3f6-6498-4062-89d7-3974b191dcd0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9af9bbf6-2a13-4515-8656-f0a12717fd3b", "272e6ccd-f7f2-4851-aabb-e0294b9f1960", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "165c810c-14ce-465a-87a4-8defb505d6f3", "5976b8df-09a0-40c6-8011-ee0c58fa6e65", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "165c810c-14ce-465a-87a4-8defb505d6f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "804b703c-a0ac-473e-9965-6479c6adea09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9af9bbf6-2a13-4515-8656-f0a12717fd3b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca359656-6bef-4cc3-b986-5499cf4c151d", "63876b04-84e7-40a8-8bb1-cfd0178b3994", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "21c94d8f-0b15-4f51-9ff1-0f649a624948", "93efff9e-5bb0-47b8-8434-8a20bd85ed79", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39ba61b3-a7f7-49b0-a9c4-444912b668f1", "2af0b5f1-2483-4a96-a9ee-557f62d656ca", "Employee", "EMPLOYEE" });
        }
    }
}
