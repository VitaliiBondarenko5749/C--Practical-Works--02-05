using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P01_BookShopSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Copies = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EditionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeRestriction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BookCategory_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("10164bef-3e37-447f-9f47-850fc004c3ac"), "Effie", "Huels" },
                    { new Guid("2428cd72-2f73-454b-a9a5-80eac882d8e0"), "Jacquelyn", "Connelly" },
                    { new Guid("4e0287dc-f475-4d5a-8719-9790b932f29a"), "Elroy", "Brakus" },
                    { new Guid("5e6c8582-ca0b-4912-a67d-8c8379065e3a"), "Lydia", "Wisoky" },
                    { new Guid("5f85877d-aa9f-4a82-863c-99ceec21ef6a"), "Ocie", "Schroeder" },
                    { new Guid("9fd811a2-1205-49be-855b-ae5870a35ab0"), "Cordelia", "Keebler" },
                    { new Guid("d0faa616-0eae-4009-8c84-65602894e98e"), "Elian", "Stoltenberg" },
                    { new Guid("d6bb3603-8740-478a-b489-0d806456da32"), "Garth", "Effertz" },
                    { new Guid("db301584-8072-4526-abef-edceaa0130b9"), "Armand", "Rice" },
                    { new Guid("ff7601bc-2d78-42d4-82da-b581f7300ce3"), "Bessie", "Jacobi" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("061019fa-6d4e-4413-a52b-a83316ac2eb3"), "Baby & Baby" },
                    { new Guid("36350a71-d729-4e1e-86e6-beb9fa28cdfa"), "Grocery, Outdoors & Computers" },
                    { new Guid("4588d245-7010-4897-a005-5fc75e7b1eea"), "Home & Tools" },
                    { new Guid("63ac623b-5de0-4655-824f-191928d321ce"), "Computers & Home" },
                    { new Guid("70fb7131-61e0-42bd-9131-2e2b3bd12243"), "Sports, Grocery & Clothing" },
                    { new Guid("76ecbc80-84e4-4452-a7b3-9b458ea89fc1"), "Games" },
                    { new Guid("952b2273-ba70-4466-a713-976fc7057c0e"), "Electronics, Sports & Computers" },
                    { new Guid("daa5565b-beec-414f-8c11-aee307c54948"), "Books" },
                    { new Guid("f581664e-0b5a-4b5f-80d2-af727b9bc25b"), "Computers" },
                    { new Guid("fbcf061c-d7e8-4736-a668-3fefdf27c13f"), "Shoes & Movies" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AgeRestriction", "AuthorId", "Copies", "Description", "EditionType", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("3d02d709-0c74-469a-a4ed-f585ddc53682"), "Adult", new Guid("d0faa616-0eae-4009-8c84-65602894e98e"), 34, "Quos necessitatibus magni voluptatem aut in iste. Amet rem iure commodi aliquam corporis ut tempore ducimus id. Deleniti fuga non voluptatem sint pariatur occaecati voluptatem. Consequatur doloremque iusto nisi eius. Aut possimus inventore quaerat voluptas et dignissimos id exercitationem alias. Et et placeat hic ducimus corrupti rem asperiores.", "Normal", 777.000494680686361m, new DateTime(2018, 8, 16, 22, 25, 36, 810, DateTimeKind.Local).AddTicks(4559), "sint" },
                    { new Guid("5838fa98-310c-4ad7-bad8-df0fb43e2125"), "Adult", new Guid("2428cd72-2f73-454b-a9a5-80eac882d8e0"), 905, "Et neque consequatur minus beatae sint tempore dolor. Iusto et doloribus in ut et eaque vitae suscipit. Voluptatem consequatur maxime ipsam. Occaecati explicabo aut id sint natus ut voluptas.", "Normal", 540.558009471115306m, new DateTime(2023, 2, 1, 2, 16, 47, 658, DateTimeKind.Local).AddTicks(4544), "vitae" },
                    { new Guid("853c774d-de1f-42c3-b30a-43baba5125d0"), "Minor", new Guid("5e6c8582-ca0b-4912-a67d-8c8379065e3a"), 823, "Adipisci repudiandae inventore hic necessitatibus sed. Illum corrupti in sint sed et quia. Similique nihil ut dicta fugit. Iusto velit corrupti dolorem sed voluptate. Odit reprehenderit et. Amet ex quae repellendus quia nam est vel.", "Normal", 268.719754137017104m, new DateTime(2017, 6, 18, 4, 30, 57, 49, DateTimeKind.Local).AddTicks(8848), "ut" },
                    { new Guid("8dc3408d-0c18-40e6-a88c-dce271171c8d"), "Teen", new Guid("9fd811a2-1205-49be-855b-ae5870a35ab0"), 579, "Et voluptas distinctio explicabo velit quam. Veniam excepturi occaecati et impedit omnis voluptates aut quia inventore. Consequatur in in et libero enim labore voluptas sed.", "Promo", 354.655867036279807m, new DateTime(2014, 12, 30, 20, 34, 53, 151, DateTimeKind.Local).AddTicks(5360), "et" },
                    { new Guid("b4d39db9-925e-4200-a787-0525e9f6b556"), "Teen", new Guid("4e0287dc-f475-4d5a-8719-9790b932f29a"), 819, "Aperiam labore corrupti. Et dolor veritatis accusamus iusto molestias ullam repellat nemo ullam. Doloribus quo est est. Expedita quia adipisci. Quae quia consequuntur reprehenderit nihil.", "Normal", 340.744257810638209m, new DateTime(2014, 8, 10, 17, 51, 54, 635, DateTimeKind.Local).AddTicks(4390), "hic" },
                    { new Guid("b7fc3d74-ec43-412c-a59c-3916ece021b7"), "Adult", new Guid("d0faa616-0eae-4009-8c84-65602894e98e"), 437, "Reiciendis omnis neque debitis sint sed. Vel eos molestiae autem perspiciatis. Necessitatibus assumenda eum officia fuga. Exercitationem iste et odio asperiores. Praesentium esse expedita dicta et est iste est molestias. Quae saepe ducimus.", "Promo", 936.442379991154096m, new DateTime(2008, 7, 26, 13, 27, 5, 690, DateTimeKind.Local).AddTicks(6423), "et" },
                    { new Guid("ba562694-2437-4798-b2da-061da03cedca"), "Teen", new Guid("4e0287dc-f475-4d5a-8719-9790b932f29a"), 581, "Sunt at quis distinctio enim et molestiae qui eos sint. Dolor inventore dolorem qui ex vel provident occaecati nesciunt. Dolorum ab molestiae dolorem magnam. Cupiditate nesciunt sed quia nam quis eos. Animi voluptatem omnis aliquam ad iure ut.", "Normal", 41.5588173676316839m, new DateTime(2018, 11, 8, 15, 24, 21, 868, DateTimeKind.Local).AddTicks(8691), "enim" },
                    { new Guid("d738305d-79f6-4239-828c-1fe80ba48eb1"), "Adult", new Guid("2428cd72-2f73-454b-a9a5-80eac882d8e0"), 555, "Explicabo rerum nulla accusantium accusantium ea nam aut ipsam sint. Consequatur cupiditate at odio ratione eaque sunt. Quia dicta sint quo recusandae. Culpa a error ut quibusdam dignissimos et voluptatum sequi. Possimus et perspiciatis non non. Commodi quia modi et nesciunt iure aut est omnis aut.", "Gold", 499.832963792217694m, new DateTime(2010, 9, 23, 1, 52, 32, 500, DateTimeKind.Local).AddTicks(9199), "modi" },
                    { new Guid("d7a1bff5-b2bd-491e-a2e3-d746e09e67b0"), "Minor", new Guid("9fd811a2-1205-49be-855b-ae5870a35ab0"), 718, "Natus aut ut quas cum quia qui neque id aut. Ullam vel aut sed sequi pariatur. Architecto ex illum ullam corporis eos. Dolorum quis qui dignissimos debitis aut dolore deserunt adipisci magni.", "Promo", 928.961308723369708m, new DateTime(2017, 12, 5, 8, 51, 54, 518, DateTimeKind.Local).AddTicks(6506), "deleniti" },
                    { new Guid("e58136b9-063c-42ee-bcb7-3da05a04fef5"), "Teen", new Guid("10164bef-3e37-447f-9f47-850fc004c3ac"), 960, "Aut tempora nulla accusamus ut ut ullam accusantium. Voluptate et quia. Optio ab non beatae ipsa doloribus alias. Nulla nam beatae debitis quo. Ut quidem et ab consequatur. Culpa earum voluptatem esse.", "Promo", 826.656071492158795m, new DateTime(2014, 7, 24, 18, 27, 22, 150, DateTimeKind.Local).AddTicks(2864), "dolores" }
                });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("3d02d709-0c74-469a-a4ed-f585ddc53682"), new Guid("76ecbc80-84e4-4452-a7b3-9b458ea89fc1") },
                    { new Guid("5838fa98-310c-4ad7-bad8-df0fb43e2125"), new Guid("daa5565b-beec-414f-8c11-aee307c54948") },
                    { new Guid("5838fa98-310c-4ad7-bad8-df0fb43e2125"), new Guid("fbcf061c-d7e8-4736-a668-3fefdf27c13f") },
                    { new Guid("b7fc3d74-ec43-412c-a59c-3916ece021b7"), new Guid("daa5565b-beec-414f-8c11-aee307c54948") },
                    { new Guid("b7fc3d74-ec43-412c-a59c-3916ece021b7"), new Guid("f581664e-0b5a-4b5f-80d2-af727b9bc25b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_CategoryId",
                table: "BookCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategory");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
