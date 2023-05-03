using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P01_BillsPaymentSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SwiftCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.BankAccountId);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    CreditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Limit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MoneyOwed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LimitLeft = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.CreditCardId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    Password = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                    table.CheckConstraint("CK_PaymentMethodAccountOrCard", "((BankAccountId IS NOT NULL AND CreditCardId IS NULL) OR (BankAccountId IS NULL AND CreditCardId IS NOT NULL))");
                    table.ForeignKey(
                        name: "FK_PaymentMethods_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "BankAccountId");
                    table.ForeignKey(
                        name: "FK_PaymentMethods_CreditCards_CreditCardId",
                        column: x => x.CreditCardId,
                        principalTable: "CreditCards",
                        principalColumn: "CreditCardId");
                    table.ForeignKey(
                        name: "FK_PaymentMethods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "Balance", "BankName", "SwiftCode" },
                values: new object[,]
                {
                    { new Guid("25cc3843-0ada-49a6-93eb-2da2dfaa35c3"), 2124.750118457212300m, "mindshare wireless capacitor", "148" },
                    { new Guid("61ad22f1-ca4f-452d-a082-a45f1a75ddb7"), 1624.857765420345400m, "Flat upward-trending Glens", "306" },
                    { new Guid("8838c1cd-6452-4c6f-a1a6-15f86dcb55d7"), 7495.277549756971600m, "Intelligent Concrete Shoes Unbranded", "981" },
                    { new Guid("c71e410f-8dd7-4702-8eb8-f83db34583a5"), 1789.231731598516600m, "Central National", "342" },
                    { new Guid("dbe78099-039d-4e37-9cef-f63f2bf36c32"), 335.6913905349661900m, "Unions Fresh Intelligent Fresh Chips", "684" }
                });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "CreditCardId", "ExpirationDate", "Limit", "LimitLeft", "MoneyOwed" },
                values: new object[,]
                {
                    { new Guid("0db5c1a3-043e-4378-b374-1e048207db07"), new DateTime(2026, 1, 31, 3, 4, 14, 979, DateTimeKind.Local).AddTicks(8312), 6196.176091410571000m, 0m, 2396.328236055940000m },
                    { new Guid("52d9b383-c43b-4f0d-a287-85616e023377"), new DateTime(2027, 6, 29, 10, 17, 29, 982, DateTimeKind.Local).AddTicks(5738), 8249.278998590992000m, 0m, 968.785015479360000m },
                    { new Guid("a8a1cbb5-1a7a-4f93-b28f-e5b94cbc4460"), new DateTime(2023, 9, 3, 11, 16, 16, 683, DateTimeKind.Local).AddTicks(5746), 2027.513564242651000m, 0m, 4858.208290647285000m },
                    { new Guid("cb44d1e5-beb6-49f5-8cf0-fe9a6948921a"), new DateTime(2024, 9, 22, 23, 23, 2, 234, DateTimeKind.Local).AddTicks(1128), 8022.258885596527000m, 0m, 4579.600297635315000m },
                    { new Guid("fefe0d0d-34b5-4dcb-a25d-fcd21995ba9c"), new DateTime(2023, 9, 17, 3, 33, 38, 504, DateTimeKind.Local).AddTicks(1672), 7014.94551968005000m, 0m, 2903.120998503345000m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { new Guid("6823ca12-b6ea-417f-a159-640444c34733"), "Ricky_McClure95@hotmail.com", "Ricky", "McClure", "ZovoCu2lQo" },
                    { new Guid("b4594aac-8dc5-428d-b8a0-7ff7900849cc"), "Dana47@yahoo.com", "Dana", "Keeling", "RGghd4uMAz" },
                    { new Guid("c9a62ef1-aa0a-48b9-baa9-3de3e3ead56f"), "Jean_Boyle@yahoo.com", "Jean", "Boyle", "7_s6DxaeUV" },
                    { new Guid("cd97b8d9-afbb-4cf8-9143-6a473c54c46e"), "Lori.Schowalter@yahoo.com", "Lori", "Schowalter", "mHzr_HV3ww" },
                    { new Guid("f3474a41-bdf3-40b9-ace0-d8f44619b8c4"), "Sheryl36@gmail.com", "Sheryl", "Rogahn", "4dTTgPEz8B" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "BankAccountId", "CreditCardId", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("457cfa51-9866-4004-9590-f1535577e268"), new Guid("61ad22f1-ca4f-452d-a082-a45f1a75ddb7"), null, "BankAccount", new Guid("6823ca12-b6ea-417f-a159-640444c34733") },
                    { new Guid("60fde458-def6-4c2d-a8de-4e7f17036ae7"), new Guid("c71e410f-8dd7-4702-8eb8-f83db34583a5"), null, "BankAccount", new Guid("f3474a41-bdf3-40b9-ace0-d8f44619b8c4") },
                    { new Guid("838176cd-ecfd-42da-9781-fc29a218ed3a"), null, new Guid("52d9b383-c43b-4f0d-a287-85616e023377"), "CreditCard", new Guid("c9a62ef1-aa0a-48b9-baa9-3de3e3ead56f") },
                    { new Guid("a3f35e91-82da-42df-854a-363682aee0c8"), new Guid("25cc3843-0ada-49a6-93eb-2da2dfaa35c3"), null, "BankAccount", new Guid("f3474a41-bdf3-40b9-ace0-d8f44619b8c4") },
                    { new Guid("acf24fee-4403-40ed-9b3d-80119e00dd7e"), null, new Guid("fefe0d0d-34b5-4dcb-a25d-fcd21995ba9c"), "CreditCard", new Guid("cd97b8d9-afbb-4cf8-9143-6a473c54c46e") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_BankAccountId",
                table: "PaymentMethods",
                column: "BankAccountId",
                unique: true,
                filter: "[BankAccountId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_CreditCardId",
                table: "PaymentMethods",
                column: "CreditCardId",
                unique: true,
                filter: "[CreditCardId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_UserId",
                table: "PaymentMethods",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
