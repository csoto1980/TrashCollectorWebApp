using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "010f1cda-db66-4b14-be71-000cdec2ebeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c1ec732-6fe5-495d-8404-8298b3260625");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c64951b4-9974-480b-a669-5b1ecd7e9cd0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b391e898-37e0-4ee8-ae62-dd282d4af4a0", "21cd02c7-a758-4943-a490-ecb80a4b92e4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd017496-7666-4733-aa25-85113a2cdf2f", "80d1ed8d-22ef-4808-ad00-62c8be8b7fae", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99f72e04-343e-493c-93a9-455a6e97dda2", "13c1b85c-5739-451f-94c6-18ba3511c15f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99f72e04-343e-493c-93a9-455a6e97dda2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b391e898-37e0-4ee8-ae62-dd282d4af4a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd017496-7666-4733-aa25-85113a2cdf2f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "010f1cda-db66-4b14-be71-000cdec2ebeb", "e2ed29d4-d13c-4f85-9753-d89c902e43d6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c1ec732-6fe5-495d-8404-8298b3260625", "dbba43d0-6589-4a40-8960-d5097f00819e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c64951b4-9974-480b-a669-5b1ecd7e9cd0", "5fed15bc-2bf1-48bf-81b6-b50434265bf4", "Employee", "EMPLOYEE" });
        }
    }
}
