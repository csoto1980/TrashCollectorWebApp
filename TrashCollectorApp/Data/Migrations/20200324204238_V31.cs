using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2690463c-04b0-428a-9c3e-42e65f1935a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "312c6f03-48d6-41df-9fe6-baa7120dae7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45192b00-7e13-4b1c-b316-7f168da128b2");

            migrationBuilder.AlterColumn<double>(
                name: "PickupCharge",
                table: "Accounts",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Balance",
                table: "Accounts",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63203a9a-2a0e-4497-81e1-2b34fc627718", "403c1a19-eb9a-4e10-b5a0-72b134bac31a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8695f0f9-3a29-4482-97df-56031371e494", "69621dbf-4d3b-4da3-bb88-d0f5619c58b3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e026a622-c802-468a-a910-69ca57082710", "289dbfad-017b-424b-85e7-75a3aa9202ea", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63203a9a-2a0e-4497-81e1-2b34fc627718");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8695f0f9-3a29-4482-97df-56031371e494");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e026a622-c802-468a-a910-69ca57082710");

            migrationBuilder.AlterColumn<decimal>(
                name: "PickupCharge",
                table: "Accounts",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Accounts",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2690463c-04b0-428a-9c3e-42e65f1935a9", "1520b0b6-2747-4916-a119-a8241ef00b08", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "312c6f03-48d6-41df-9fe6-baa7120dae7c", "abc59321-f51b-4d52-b96e-703ed47f730a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45192b00-7e13-4b1c-b316-7f168da128b2", "8764c8cd-69ca-4dd5-90d8-e956441d29ed", "Employee", "EMPLOYEE" });
        }
    }
}
