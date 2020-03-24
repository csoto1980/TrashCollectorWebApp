using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b359c6e-8e16-450f-86a9-d09b02d0e565", "a44e5221-33d9-44f3-8e4b-ae363a20c667", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "071ef1eb-43b8-4b10-a9b4-acdaeb668c1b", "c784865c-815f-45df-ba7b-eb93853b3188", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2e8e32e-bb1a-4349-a650-d2c23bf179eb", "2ba1538f-6d17-4123-9ad2-7cd6db52550c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "071ef1eb-43b8-4b10-a9b4-acdaeb668c1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b359c6e-8e16-450f-86a9-d09b02d0e565");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2e8e32e-bb1a-4349-a650-d2c23bf179eb");

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
    }
}
