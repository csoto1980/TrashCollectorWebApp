using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c6cbd81-f064-4b88-b99e-dad9d071713c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4758af0-bac5-425a-af37-0f540f559862");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca0992b6-0a83-41bc-aae0-159ce7b0fbc9");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7c6cbd81-f064-4b88-b99e-dad9d071713c", "92476bad-14cd-422e-acbd-06333131dd17", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4758af0-bac5-425a-af37-0f540f559862", "6250f8b7-f4e7-4288-a6d2-2d99b41b2c9d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca0992b6-0a83-41bc-aae0-159ce7b0fbc9", "9e8db402-bdd0-4eed-b883-f8b598d481e6", "Employee", "EMPLOYEE" });
        }
    }
}
