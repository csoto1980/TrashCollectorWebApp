using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorApp.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00cbd578-0d8b-4439-815d-43bc10f9f5b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccfc181-bcbd-4017-9e37-ea3e35ac8129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97059715-7859-4d94-b288-3c861257b6a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a293bd9c-9727-4b04-a11f-6c2ca4522861");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f920958c-bc84-4cea-8181-eafdf938deab");

            migrationBuilder.AlterColumn<double>(
                name: "Balance",
                table: "Account",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "EndPickupDate",
                table: "Account",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OneDayPickup",
                table: "Account",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickupDay",
                table: "Account",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartPickupDate",
                table: "Account",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SuspendPickup",
                table: "Account",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "EndPickupDate",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "OneDayPickup",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "PickupDay",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "StartPickupDate",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "SuspendPickup",
                table: "Account");

            migrationBuilder.AlterColumn<int>(
                name: "Balance",
                table: "Account",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a293bd9c-9727-4b04-a11f-6c2ca4522861", "54ac95c1-8d37-46b6-ab15-61786dc97e32", "Admin", "ADMIN" },
                    { "f920958c-bc84-4cea-8181-eafdf938deab", "7a1291fa-71f6-49a2-b8d7-7c34a8c864d9", "Customer", "CUSTOMER" },
                    { "8ccfc181-bcbd-4017-9e37-ea3e35ac8129", "3f53cbe9-16f4-484f-a99f-31b1909f427c", "Employee", "EMPLOYEE" },
                    { "00cbd578-0d8b-4439-815d-43bc10f9f5b1", "fcc38710-c8a5-43c3-af0c-6e8c9c488a42", "CustomerView", "CUSTOMERVIEW" },
                    { "97059715-7859-4d94-b288-3c861257b6a5", "763b7984-10dc-4b05-816a-7776a2313a4a", "EmployeeView", "EMPLOYEEVIEW" }
                });
        }
    }
}
