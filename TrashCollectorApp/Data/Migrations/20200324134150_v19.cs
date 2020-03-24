using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "PickupCharge",
                table: "Account",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PickupCharge",
                table: "Account");

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
    }
}
