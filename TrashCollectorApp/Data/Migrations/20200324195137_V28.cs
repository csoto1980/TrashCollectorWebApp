using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "063d377c-7253-4842-848d-07b64356b4fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "127e32f9-6a2f-4bda-a26a-b4ee05ba3878");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e56a1cd-643d-4596-af1e-efe5efda1b86");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartPickupDate",
                table: "Accounts",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndPickupDate",
                table: "Accounts",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3fc2131c-43eb-4e95-8741-62db8b9af917", "9bafc2d5-189a-4985-abfa-312db7276cfa", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e25b9f41-0375-496a-bc4b-00a3961e6158", "7118b3c9-ba43-4ba6-9c54-ec3fb3bd6fe8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2e04a38-62c4-4949-92c7-b2ae1a486d6c", "b69e8c6a-9dbc-4b98-b444-56de4212ad16", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fc2131c-43eb-4e95-8741-62db8b9af917");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e25b9f41-0375-496a-bc4b-00a3961e6158");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2e04a38-62c4-4949-92c7-b2ae1a486d6c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartPickupDate",
                table: "Accounts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndPickupDate",
                table: "Accounts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e56a1cd-643d-4596-af1e-efe5efda1b86", "37023b20-4ec3-4ddd-8e94-7b9072d768e9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "127e32f9-6a2f-4bda-a26a-b4ee05ba3878", "b96619a7-792e-4fbf-8246-bfae3e02c749", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "063d377c-7253-4842-848d-07b64356b4fc", "6424ac25-d05f-4ed9-b9c1-50b725aa4700", "Employee", "EMPLOYEE" });
        }
    }
}
