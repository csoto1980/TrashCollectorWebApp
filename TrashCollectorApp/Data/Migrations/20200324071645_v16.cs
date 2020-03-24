using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4be630fd-1612-406d-89b3-6bc4c003de52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c3a52eb-251a-4b88-8049-8e05068380d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa2d7eb2-a1a7-409b-9352-b91378b40ee7");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4be630fd-1612-406d-89b3-6bc4c003de52", "42bda812-4e4c-44ce-993e-257f7e2a713e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa2d7eb2-a1a7-409b-9352-b91378b40ee7", "c9fb9f62-4d19-4270-8ee6-805609b70a3d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c3a52eb-251a-4b88-8049-8e05068380d9", "8fe0226b-59fb-43c6-a819-762ecb45d4c0", "Employee", "EMPLOYEE" });
        }
    }
}
