using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2476dd0d-b76c-4179-a271-ecb0fc074144");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b816ee8-8816-4ae4-b1a3-8f27cd95bbc5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49676a80-618b-4b2f-8064-0280f19d1d21");

            migrationBuilder.AlterColumn<decimal>(
                name: "PickupCharge",
                table: "Accounts",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Accounts",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2a02681-ad58-45b8-bd1e-af6d4113a772", "ea2586f4-77eb-4125-85ba-7139dbfa4b70", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec4fccab-447c-48da-8958-289599ef2dbb", "d44a8a8a-2b28-414f-8cd4-e7c059bea10c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "07a8cf05-6949-4530-a1fc-bd1a33e6bb99", "6e2a4512-4c13-4705-9220-d141f8790344", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07a8cf05-6949-4530-a1fc-bd1a33e6bb99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2a02681-ad58-45b8-bd1e-af6d4113a772");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec4fccab-447c-48da-8958-289599ef2dbb");

            migrationBuilder.AlterColumn<double>(
                name: "PickupCharge",
                table: "Accounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Balance",
                table: "Accounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2476dd0d-b76c-4179-a271-ecb0fc074144", "4b927455-adeb-4773-afd9-3ce07bff23d8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b816ee8-8816-4ae4-b1a3-8f27cd95bbc5", "884564d3-186b-4936-ab7b-786166513e3e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49676a80-618b-4b2f-8064-0280f19d1d21", "68b9fa40-eab9-402d-8790-23db680f44e8", "Employee", "EMPLOYEE" });
        }
    }
}
