using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893fc66f-7a70-4a12-8707-3a63884e223a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0d79cab-ceb6-46af-beee-33c051665813");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddcf2394-98c0-42bd-a716-2f5983382f7d");

            migrationBuilder.AlterColumn<decimal>(
                name: "PickupCharge",
                table: "Account",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Account",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d61ebbe1-e68e-4ec4-bc6d-428c61127f88", "3193bd39-bfbb-4905-a76b-23d3b1c11f47", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "334fb6f1-d0f5-4844-b2f5-804b89d11c6e", "f2eb2ab3-d397-4b66-a719-224bafe021cb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a75ba41-9633-4abd-adce-baf25baf1d30", "e03bdcb4-e5a4-4fa1-92ff-a3f0001e2c29", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "334fb6f1-d0f5-4844-b2f5-804b89d11c6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a75ba41-9633-4abd-adce-baf25baf1d30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d61ebbe1-e68e-4ec4-bc6d-428c61127f88");

            migrationBuilder.AlterColumn<decimal>(
                name: "PickupCharge",
                table: "Account",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Balance",
                table: "Account",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0d79cab-ceb6-46af-beee-33c051665813", "081075ad-b23a-4e13-b0cf-acd69d770f3a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ddcf2394-98c0-42bd-a716-2f5983382f7d", "eb55452f-0c4d-4ff9-aebd-1a8a1ce5ac09", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "893fc66f-7a70-4a12-8707-3a63884e223a", "a57cc906-8253-425e-8a95-e55ad12972a3", "Employee", "EMPLOYEE" });
        }
    }
}
