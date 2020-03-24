using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c03928-59fa-40b3-9998-9d1da722884d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "757c152d-b4d3-4c1f-95a4-15f3628ff3d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bee30bea-7b79-42c9-8915-9e17331daa3d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "bee30bea-7b79-42c9-8915-9e17331daa3d", "51f25ae0-de5d-44e8-945e-aa1ad677ce22", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46c03928-59fa-40b3-9998-9d1da722884d", "3446c76d-8f9b-408c-9045-cdc34ba9890a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "757c152d-b4d3-4c1f-95a4-15f3628ff3d9", "974a9233-8395-4ab1-8b84-debe30a5701c", "Employee", "EMPLOYEE" });
        }
    }
}
