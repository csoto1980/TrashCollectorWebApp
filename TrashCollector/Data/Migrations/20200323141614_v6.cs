using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0661a8a0-b756-4051-8b5a-27d9d560c1d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c821132-5591-46a2-a165-2842e7068966");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce661384-2696-4575-a0f9-5a5deb08bfc3");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PickupDay",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeViewId",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PickupId",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeView",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeView", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeView_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pickup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickupDay = table.Column<string>(nullable: true),
                    OneDayPickup = table.Column<string>(nullable: true),
                    TempSuspend = table.Column<bool>(nullable: false),
                    StartSuspend = table.Column<string>(nullable: true),
                    EndSuspend = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pickup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerView",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: true),
                    PickupId = table.Column<int>(nullable: true),
                    AccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerView", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerView_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerView_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerView_Pickup_PickupId",
                        column: x => x.PickupId,
                        principalTable: "Pickup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dd2325d0-4fd2-42c0-bca9-45a3c8dc756b", "bbb56318-a6b0-46c6-8bef-e6bb144de514", "Admin", "ADMIN" },
                    { "a3c56afe-e09f-4120-9188-f6b7d8d2f63a", "fc8c72aa-b939-42c3-afdf-ac0546554898", "Customer", "CUSTOMER" },
                    { "288150c1-f8bc-4b65-bfad-8352515b387b", "4a633ccf-6552-4b05-9b1f-5796337201a7", "Employee", "EMPLOYEE" },
                    { "d471cfcd-8664-4a59-ae95-ccd4fcba209b", "884243b0-21e0-477e-b99d-191382eb5c31", "CustomerView", "CUSTOMERVIEW" },
                    { "b5ca3e2d-eb8c-43bf-85d6-822ccd43636b", "7d329dac-42c2-46d0-a136-8359e6e0f8df", "EmployeeView", "EMPLOYEEVIEW" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_IdentityUserId",
                table: "Employee",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AccountId",
                table: "Customer",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_EmployeeViewId",
                table: "Customer",
                column: "EmployeeViewId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PickupId",
                table: "Customer",
                column: "PickupId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerView_AccountId",
                table: "CustomerView",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerView_CustomerId",
                table: "CustomerView",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerView_PickupId",
                table: "CustomerView",
                column: "PickupId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeView_EmployeeId",
                table: "EmployeeView",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Account_AccountId",
                table: "Customer",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_EmployeeView_EmployeeViewId",
                table: "Customer",
                column: "EmployeeViewId",
                principalTable: "EmployeeView",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Pickup_PickupId",
                table: "Customer",
                column: "PickupId",
                principalTable: "Pickup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AspNetUsers_IdentityUserId",
                table: "Employee",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Account_AccountId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_EmployeeView_EmployeeViewId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Pickup_PickupId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_AspNetUsers_IdentityUserId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "CustomerView");

            migrationBuilder.DropTable(
                name: "EmployeeView");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Pickup");

            migrationBuilder.DropIndex(
                name: "IX_Employee_IdentityUserId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AccountId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_EmployeeViewId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_PickupId",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "288150c1-f8bc-4b65-bfad-8352515b387b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3c56afe-e09f-4120-9188-f6b7d8d2f63a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5ca3e2d-eb8c-43bf-85d6-822ccd43636b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d471cfcd-8664-4a59-ae95-ccd4fcba209b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd2325d0-4fd2-42c0-bca9-45a3c8dc756b");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "EmployeeViewId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PickupId",
                table: "Customer");

            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Customer",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PickupDay",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c821132-5591-46a2-a165-2842e7068966", "6a689fa0-3975-45e9-9a16-6e001e9e2cca", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0661a8a0-b756-4051-8b5a-27d9d560c1d6", "d4267b61-2e11-4692-9ec4-17a52f11262d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce661384-2696-4575-a0f9-5a5deb08bfc3", "7ad90f9d-22be-46c5-b124-cdb123f76afe", "Employee", "EMPLOYEE" });
        }
    }
}
