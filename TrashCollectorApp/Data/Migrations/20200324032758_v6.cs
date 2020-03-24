using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "517e82d4-6848-4418-872b-2e38ffd05aea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b102e21-4e80-4ebb-9510-65685137e68f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd764e9e-3289-43b7-b8b8-972b2947e0e6");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9b102e21-4e80-4ebb-9510-65685137e68f", "9b7d1918-5269-48e6-8543-d6bc679dd8b1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd764e9e-3289-43b7-b8b8-972b2947e0e6", "a10a6259-d625-4d3d-ba0a-f59e35dad4da", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "517e82d4-6848-4418-872b-2e38ffd05aea", "46d6d808-e5c5-41ec-b27b-b3ac0c2a1e61", "Employee", "EMPLOYEE" });
        }
    }
}
