using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b65ea4-8dd7-4c12-aa84-16a0be7c8caf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5756b4ca-a00e-4482-a39a-9ba1e9d1a462");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbd9934e-9059-4a4b-8d9d-68ac3f2c523f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "079104cf-9058-4c47-b566-319f87678d1f", "bc9cc7c2-2b0e-45f8-95ae-e3cc2ca921ee", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4df5d4d-3b01-4e71-ab0a-738e50d4503d", "e7061625-5fb5-4fcc-8d45-25fd645a2e46", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08e32d78-33c7-419c-bd28-8cb942c31a7a", "55a36bfe-f3f9-4309-868f-60650a9c65f7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "079104cf-9058-4c47-b566-319f87678d1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e32d78-33c7-419c-bd28-8cb942c31a7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4df5d4d-3b01-4e71-ab0a-738e50d4503d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5756b4ca-a00e-4482-a39a-9ba1e9d1a462", "c6ae3de6-84b5-40e4-9a60-e793bce008c8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47b65ea4-8dd7-4c12-aa84-16a0be7c8caf", "5ce935e1-e182-41ee-a651-3329055cb55a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbd9934e-9059-4a4b-8d9d-68ac3f2c523f", "76bb7b51-35a8-4d6d-9708-f34980ccc5cd", "Employee", "EMPLOYEE" });
        }
    }
}
