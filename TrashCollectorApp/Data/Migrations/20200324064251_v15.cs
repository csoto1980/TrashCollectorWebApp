using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
