using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84e9f4d5-ffa1-41d2-b489-42c0a0b55128");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e115e88a-b535-40ec-a473-f36a1175d1f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb71c714-127c-4042-8ac9-a729322755ed");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "84e9f4d5-ffa1-41d2-b489-42c0a0b55128", "1641352f-bea5-485e-bfa7-e43063cfe89d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e115e88a-b535-40ec-a473-f36a1175d1f1", "d0016b06-021f-4327-ad96-e68d4f7b0d26", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb71c714-127c-4042-8ac9-a729322755ed", "fe6b58f2-c5c2-4511-9786-fe179c8319b9", "Employee", "EMPLOYEE" });
        }
    }
}
