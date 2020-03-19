using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject1.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32a4ed0c-dcb5-4521-84fc-68c002f01449");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ed39333-fbeb-47da-8e34-5cd7a47a67db", "e02ddb53-a04a-4c10-a76a-66f406a1dd10", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e641830-d1bf-488f-863d-e25fea1a7204", "b25064a0-7f1c-47d1-8445-c9252c4e110e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc1f9658-cb5b-4eb2-b5e6-2ab63fa4b3a6", "2aa29268-408f-43a3-bd4c-04176308b91c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e641830-d1bf-488f-863d-e25fea1a7204");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ed39333-fbeb-47da-8e34-5cd7a47a67db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc1f9658-cb5b-4eb2-b5e6-2ab63fa4b3a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32a4ed0c-dcb5-4521-84fc-68c002f01449", "cfbef6f1-db48-446e-8125-14a8a8d7187d", "Admin", "ADMIN" });
        }
    }
}
