using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "33bc7037-36d2-40ed-8dc2-6add27416a16", "a5d46e85-fa2b-4fd5-a1af-d9b201791025", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7770fcb-4bb7-479d-b96d-fac3f1ffbd32", "06078519-0eda-45de-9814-8eb07595c697", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20cc27e6-14d0-4ba4-bb1e-2d4f81deeb41", "63321737-9027-46c0-a5fc-2bf9e692a131", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20cc27e6-14d0-4ba4-bb1e-2d4f81deeb41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33bc7037-36d2-40ed-8dc2-6add27416a16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7770fcb-4bb7-479d-b96d-fac3f1ffbd32");

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
    }
}
