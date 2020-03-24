using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b07fa0c-6f79-4221-a58b-9530723004fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0715f36-2d2e-498a-8876-b4e866ecf70f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fed0d30b-1d0e-4cd9-8e28-942ddc35ac56");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b0715f36-2d2e-498a-8876-b4e866ecf70f", "243e0a2d-7b93-4abd-85f8-c821c79750cb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fed0d30b-1d0e-4cd9-8e28-942ddc35ac56", "9a603bd4-f10d-47cd-9cbf-2f92d1e18b78", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b07fa0c-6f79-4221-a58b-9530723004fc", "be75758c-e6a2-4202-831c-013770812525", "Employee", "EMPLOYEE" });
        }
    }
}
