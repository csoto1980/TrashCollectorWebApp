using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class V25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b8db805-0cc6-4931-835e-3272a51e2d7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88c32f7a-e416-4193-8772-b7dfaf53bf1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef4c600b-9929-4a5b-a9e0-888a8bd771e6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d0024ac-a8ac-4abe-848f-10351b3f0bbd", "cb7526dd-41c3-4094-acc7-57bcf4322324", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b5a6928-764a-4500-a93b-6360defd60c0", "9011deca-3f80-4fcc-9139-51c7eadde46f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c2b43b0-f947-4fee-a5db-6071a1b9798b", "80f1a130-c62a-4249-86fe-a9caa461564e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b5a6928-764a-4500-a93b-6360defd60c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d0024ac-a8ac-4abe-848f-10351b3f0bbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c2b43b0-f947-4fee-a5db-6071a1b9798b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef4c600b-9929-4a5b-a9e0-888a8bd771e6", "e10b0ab3-3467-404f-8386-a17deafdbb32", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88c32f7a-e416-4193-8772-b7dfaf53bf1e", "4031ecab-4583-42f9-990a-a9703255dc40", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b8db805-0cc6-4931-835e-3272a51e2d7d", "76123aa9-ed59-4550-93b8-bc983fe9f5f7", "Employee", "EMPLOYEE" });
        }
    }
}
