using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37e92bc6-95c8-49d3-a09b-0d90f658b62c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b8dd648-8a98-426c-82b2-d5288e61a5df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74368f69-58dd-4c89-bd75-b051161388ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ab402d-a1e3-4afb-91d4-e42c126e751d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e647e926-97d8-46f6-bbcd-933764d92343");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "96ab402d-a1e3-4afb-91d4-e42c126e751d", "d3ac1da1-3f86-4081-8681-f0d86ce09f8e", "Admin", "ADMIN" },
                    { "74368f69-58dd-4c89-bd75-b051161388ba", "d3bb731e-ca1a-4f2e-812d-44845042d467", "Customer", "CUSTOMER" },
                    { "e647e926-97d8-46f6-bbcd-933764d92343", "25f8916a-d52a-45bb-b4c1-e77800f1caa2", "Employee", "EMPLOYEE" },
                    { "37e92bc6-95c8-49d3-a09b-0d90f658b62c", "4f1cad49-9681-4c3f-9111-bfced8bf2076", "CustomerView", "CUSTOMERVIEW" },
                    { "3b8dd648-8a98-426c-82b2-d5288e61a5df", "986dde0c-504f-4667-916f-a5eed0a56e14", "EmployeeView", "EMPLOYEEVIEW" }
                });
        }
    }
}
