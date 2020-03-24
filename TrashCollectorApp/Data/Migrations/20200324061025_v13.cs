using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18a43227-54f8-4dfa-a2b0-b48eed47a1c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b58956e-4177-4a2a-a7d3-d57193910d0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d485f6fc-bcad-4fbd-9259-f4a6256d0998");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26425362-8db2-4587-ba6c-e13cf2e6be4b", "e7a9984a-5ce2-4704-a500-fd1d31615a14", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4216679-95e3-46d7-b01d-aa6b6726fc24", "b18a2a74-f0a1-40b5-a5c7-7ffcd2bc9840", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc6d1d17-cff3-4d59-a113-30e6d1f7d8e6", "88fb23e4-74f0-47f8-b501-478b5869b1d6", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26425362-8db2-4587-ba6c-e13cf2e6be4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4216679-95e3-46d7-b01d-aa6b6726fc24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc6d1d17-cff3-4d59-a113-30e6d1f7d8e6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b58956e-4177-4a2a-a7d3-d57193910d0f", "c160f437-1aa4-4709-ae7e-64c2b35aecf5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d485f6fc-bcad-4fbd-9259-f4a6256d0998", "b15bf912-3bc2-4b5f-a2f8-c971db90f620", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18a43227-54f8-4dfa-a2b0-b48eed47a1c8", "078dd83f-7254-4896-a410-3f9003a12e71", "Employee", "EMPLOYEE" });
        }
    }
}
