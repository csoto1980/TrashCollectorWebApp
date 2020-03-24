using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
