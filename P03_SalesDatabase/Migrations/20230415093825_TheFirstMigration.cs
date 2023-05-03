using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class TheFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Customer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Store = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_Customer",
                        column: x => x.Customer,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Products_Product",
                        column: x => x.Product,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Stores_Store",
                        column: x => x.Store,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("0d159983-aeab-4a6d-909a-9830f52e0ba1"), "6304057469486062", "Sheryl_Stroman@yahoo.com", "Sheryl Stroman" },
                    { new Guid("19abb28e-ece2-4d98-b182-24d8847c8d2c"), "6455-6211-4524-4228-9288", "Bethany_Goyette@gmail.com", "Bethany Goyette" },
                    { new Guid("23b3528a-0015-4c54-80d5-5b79afebd7f9"), "6767-5042-0434-9395-860", "Dwayne3@gmail.com", "Dwayne Little" },
                    { new Guid("27ac3e41-3531-429b-968f-0e0fab929589"), "6759-4060-1890-2436", "Antoinette_Howe@yahoo.com", "Antoinette Howe" },
                    { new Guid("2e668adb-e696-42ae-bdbe-2abd5e17de89"), "5277-9227-5267-0430", "Eula_Little36@yahoo.com", "Eula Little" },
                    { new Guid("3ef96646-77a3-4ef5-8dd0-de6f59d54ddc"), "6517-6268-8465-9818-1926", "Rosa55@yahoo.com", "Rosa Gottlieb" },
                    { new Guid("42dc7f53-50ee-4b48-9a5e-f96cea034bb5"), "6767-7689-6161-8837-56", "Bridget_OConnell@hotmail.com", "Bridget O'Connell" },
                    { new Guid("4894d93d-a65a-4b85-aeef-c7b292e3e4c6"), "5439-5107-9451-2028", "Kimberly.Jenkins69@gmail.com", "Kimberly Jenkins" },
                    { new Guid("4bf4ded3-5c39-43af-a1b1-f58f1479b3dd"), "6398-3249-9743-7711", "Stephen_Larson43@hotmail.com", "Stephen Larson" },
                    { new Guid("4d305524-3ef5-4ee0-ba66-d7774344987c"), "6759-2048-2945-9963-824", "Jennifer_Huels73@hotmail.com", "Jennifer Huels" },
                    { new Guid("58885961-cd1e-4c52-9f09-1c5df88b910b"), "5893493208973103", "Grace_Little21@yahoo.com", "Grace Little" },
                    { new Guid("65d6f084-0f0c-4ba8-9ea9-4f278a3e241d"), "3656-372990-9999", "Brandon_OKon@hotmail.com", "Brandon O'Kon" },
                    { new Guid("872021c0-cb0b-43fe-b172-727df7e21122"), "4687346877608", "Belinda_Christiansen@yahoo.com", "Belinda Christiansen" },
                    { new Guid("8dec2151-7ece-4225-9174-8daf51bae68e"), "6771-8922-4365-3254", "Gwen_Kulas@gmail.com", "Gwen Kulas" },
                    { new Guid("9614297a-5810-4d1f-a4ea-5bec1972368e"), "3529-1784-8625-9948", "Kayla31@gmail.com", "Kayla Keeling" },
                    { new Guid("ad51c5e7-3685-49fe-b1d4-5554d8dc4d94"), "6767-3340-1017-5647", "Pablo82@gmail.com", "Pablo Rice" },
                    { new Guid("c242ebe9-a273-497b-b3ed-dd7b094c6476"), "3616-423159-6737", "Cynthia77@yahoo.com", "Cynthia Hintz" },
                    { new Guid("d131eafd-86f1-4431-9048-4c6c396beb80"), "6759-9212-9379-1676", "Frankie9@yahoo.com", "Frankie Predovic" },
                    { new Guid("d4f2a0d5-1567-4c93-8b0e-284dec50dfe9"), "4552-0001-0511-5475", "Arthur90@hotmail.com", "Arthur Ullrich" },
                    { new Guid("d8fb64be-955b-4be2-8fb1-aedd495b77a9"), "6759-7852-7709-7271", "Gretchen_Wintheiser@yahoo.com", "Gretchen Wintheiser" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("029f71c6-2326-48d6-b347-2d86ef77e587"), "Rustic Wooden Chips", 1621.482410613320000m, 767.5265f },
                    { new Guid("06657346-12d2-4638-a023-e75e1f6b3354"), "Handmade Frozen Bike", 4913.852609162340000m, 72.91686f },
                    { new Guid("1095f0b1-cce8-423a-af19-c4cdf8c19158"), "Practical Cotton Ball", 4056.786719411570000m, 207.38115f },
                    { new Guid("1dc01f2c-b787-4ef7-85f5-b9f5ebd65873"), "Handcrafted Wooden Cheese", 7300.583579649210000m, 36.808407f },
                    { new Guid("2dd328a0-4b2f-409e-a824-c484574a3d97"), "Small Metal Keyboard", 9484.872626590220000m, 219.79092f },
                    { new Guid("31bbb11e-571d-4eca-a069-b7ceba8bcb97"), "Refined Granite Bacon", 3158.254351134870000m, 322.5808f },
                    { new Guid("37eafcab-a577-4426-8915-e176a860aead"), "Awesome Fresh Bacon", 2143.435636521510000m, 96.70534f },
                    { new Guid("3d343dd4-0007-4c8e-8d96-3d8be854c2e1"), "Handcrafted Soft Soap", 9526.72220896720000m, 217.20303f },
                    { new Guid("463940e4-d568-412f-8fbe-af0affab79a5"), "Gorgeous Plastic Chips", 9346.079260292050000m, 844.5623f },
                    { new Guid("46dfb232-6235-485c-8da9-b60e5e15ba32"), "Tasty Soft Cheese", 3908.856826725360000m, 706.5572f },
                    { new Guid("5fbdd46b-d0b5-4543-a301-559052b522ed"), "Ergonomic Rubber Table", 1648.552782453260000m, 796.50446f },
                    { new Guid("611c9e00-7d77-40e9-a355-2c3a45503183"), "Unbranded Metal Hat", 388.1598717012320000m, 210.35046f },
                    { new Guid("612f0ef7-656a-4897-8bce-ba738132c839"), "Licensed Steel Salad", 4825.05801923360000m, 90.76204f },
                    { new Guid("62768908-6ea3-40f6-83e7-e406a54de05a"), "Licensed Wooden Salad", 861.2870482604370000m, 480.02393f },
                    { new Guid("659015bb-49c5-4f54-967a-143d162b1d95"), "Incredible Granite Bike", 7786.876306506380000m, 488.67523f },
                    { new Guid("6d9f3674-2a4e-4b61-8ba2-2395482a8397"), "Sleek Granite Soap", 8558.768673436720000m, 831.1672f },
                    { new Guid("7e0afba3-6f83-48a3-a79a-f7b2e7122b49"), "Ergonomic Metal Sausages", 1577.903452402670000m, 516.7398f },
                    { new Guid("83742aae-610d-4f61-a5d5-7e2f66d2e73a"), "Tasty Cotton Salad", 6924.630668633160000m, 581.1025f },
                    { new Guid("8964f3c3-9a27-4daf-9334-dd44e40cb90f"), "Handcrafted Fresh Car", 5076.904433578580000m, 617.551f },
                    { new Guid("9102fead-d434-4f69-9eab-838178697967"), "Small Plastic Salad", 5700.399263022840000m, 742.5623f },
                    { new Guid("922b39a9-86f7-4d65-9321-8da357e3a1f0"), "Refined Granite Tuna", 8109.401960883150000m, 32.95414f },
                    { new Guid("9ad63002-9d2b-4f77-94a2-5a47c0ef689b"), "Tasty Fresh Pants", 5850.852265975140000m, 124.93374f },
                    { new Guid("a8364632-afe2-4d4f-b4d8-c9693df5efb9"), "Awesome Plastic Fish", 1394.485361085930000m, 406.9684f },
                    { new Guid("b0a5f1fb-5bcf-4426-b0e3-cc3e3faed721"), "Refined Concrete Ball", 3667.332299884210000m, 713.10504f },
                    { new Guid("b164503e-dcda-49e5-8042-7448af54e6e4"), "Refined Plastic Sausages", 2121.550174376840000m, 981.68463f },
                    { new Guid("b1ab6962-f308-48e8-8bca-d162b21ec013"), "Licensed Plastic Shirt", 3429.506784251510000m, 443.38495f },
                    { new Guid("b35364b5-955a-481f-927a-3934ebde2bea"), "Fantastic Metal Towels", 8849.414553623220000m, 239.26434f },
                    { new Guid("bcbaef2a-dd26-4ec7-92c1-0c52d66653de"), "Handmade Concrete Fish", 7216.693885902250000m, 79.336205f },
                    { new Guid("cb76051d-84e5-46f3-a230-2cd0d5f30d77"), "Incredible Rubber Table", 610.8750622197640000m, 587.98785f },
                    { new Guid("d9dc11b2-84c2-4ea1-8a14-5347075826c8"), "Small Cotton Sausages", 7400.263131107660000m, 372.72357f },
                    { new Guid("dae1a5a6-881f-48eb-a066-9a455b4ae7f3"), "Fantastic Plastic Ball", 6480.190793703990000m, 335.39667f },
                    { new Guid("dd084c63-b776-4cd2-b85e-e2cec6b5746a"), "Refined Granite Hat", 8032.861146316770000m, 803.93756f },
                    { new Guid("dd317f36-fba7-47bb-a907-7c2f8e5bc983"), "Rustic Wooden Shirt", 5111.537396702140000m, 133.55197f },
                    { new Guid("e41382ab-19a4-4cd0-8cde-621dde807841"), "Small Rubber Ball", 8577.198799551260000m, 54.459644f },
                    { new Guid("e548160d-fbc1-4bcf-a12c-c6336c278f26"), "Incredible Fresh Gloves", 5831.881117764180000m, 668.5122f },
                    { new Guid("ec99b2e6-bec1-4dbe-90f2-3e6828e4d93c"), "Ergonomic Plastic Gloves", 7899.0661737820000m, 8.763154f },
                    { new Guid("ed639751-bd69-4712-92f4-728b1b89c173"), "Sleek Fresh Soap", 2067.226209220540000m, 228.39719f },
                    { new Guid("f0df89a4-948f-4a2c-94ad-a098e1775dd7"), "Incredible Concrete Fish", 4506.259764260430000m, 905.6777f },
                    { new Guid("f8032cd1-85de-40eb-aa27-771f4deb4e81"), "Practical Rubber Ball", 3811.141164034160000m, 603.86896f },
                    { new Guid("fc6a8d35-83df-445e-9337-bbc706c2ed73"), "Intelligent Steel Table", 1152.746683051960000m, 838.27155f }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { new Guid("1737871e-8487-43f7-b676-d9dd13c53b9a"), "Grady Group" },
                    { new Guid("1b85455f-b827-42e6-855c-36cad3e88a3e"), "Cummerata - Marvin" },
                    { new Guid("3ce5bfde-5c84-45aa-b77b-ff8fd39c0976"), "Kreiger, Wehner and Leuschke" },
                    { new Guid("42245df4-d04c-46f0-8938-6af7b6ccdb38"), "Ferry Inc" },
                    { new Guid("521ba706-10a4-433c-9df2-a68f050afa00"), "Pacocha LLC" },
                    { new Guid("5746c411-8c51-412a-93d4-73a11f5dca93"), "Hamill - Quigley" },
                    { new Guid("6a4eeabf-c150-449f-8a1b-5c8c01e74837"), "Jaskolski and Sons" },
                    { new Guid("6db9ce7c-287d-474b-9ee4-58558a53e8b8"), "Simonis Inc" },
                    { new Guid("6f1a1738-e6ad-4d29-afdc-952edd10ac36"), "Cruickshank Inc" },
                    { new Guid("73353e38-62c4-4293-aeec-02eb2652b98c"), "Konopelski and Sons" },
                    { new Guid("8893c552-d404-45bc-8b56-7a50017cf5ac"), "Boyle, Balistreri and Collier" },
                    { new Guid("896163a6-2134-4104-9b48-6442254f18bc"), "Pfannerstill and Sons" },
                    { new Guid("90c782bd-902a-4764-a6ad-83f2581e9f32"), "Weber - Miller" },
                    { new Guid("9b752c22-78ec-4c3c-a013-bae2434ec147"), "Waters, Halvorson and McCullough" },
                    { new Guid("a3569e74-209c-4b28-83b4-2219cec7da22"), "Robel, Pollich and Legros" },
                    { new Guid("cf871379-e6bf-4c19-b100-d2dbffe4f28e"), "Gaylord - Kub" },
                    { new Guid("d77a3211-15ac-4f1f-be71-6323872f5954"), "Nitzsche - Lubowitz" },
                    { new Guid("eaeb01c4-9e06-492b-951b-b67f96d7e6f2"), "Hagenes Inc" },
                    { new Guid("f8954168-7941-488a-a641-d3eb704dbfe9"), "Smith - Koepp" },
                    { new Guid("fdda4973-d2aa-4df6-a686-594e85d36833"), "Donnelly, Lindgren and Grimes" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "Customer", "Date", "Product", "Store" },
                values: new object[,]
                {
                    { new Guid("009822ce-03c9-4bd6-9c52-29c714919020"), new Guid("d8fb64be-955b-4be2-8fb1-aedd495b77a9"), new DateTime(2023, 4, 15, 5, 1, 40, 377, DateTimeKind.Local).AddTicks(607), new Guid("31bbb11e-571d-4eca-a069-b7ceba8bcb97"), new Guid("6db9ce7c-287d-474b-9ee4-58558a53e8b8") },
                    { new Guid("13fd42b5-1ddb-4f14-9163-eda9aadc4638"), new Guid("58885961-cd1e-4c52-9f09-1c5df88b910b"), new DateTime(2023, 4, 15, 4, 28, 31, 284, DateTimeKind.Local).AddTicks(9444), new Guid("463940e4-d568-412f-8fbe-af0affab79a5"), new Guid("73353e38-62c4-4293-aeec-02eb2652b98c") },
                    { new Guid("15ca4e81-0b68-4820-aab6-1f752ad58344"), new Guid("27ac3e41-3531-429b-968f-0e0fab929589"), new DateTime(2023, 4, 15, 4, 24, 17, 591, DateTimeKind.Local).AddTicks(2580), new Guid("1dc01f2c-b787-4ef7-85f5-b9f5ebd65873"), new Guid("6f1a1738-e6ad-4d29-afdc-952edd10ac36") },
                    { new Guid("16ac77b5-a90a-4f59-a49c-81c9dd28b73f"), new Guid("d131eafd-86f1-4431-9048-4c6c396beb80"), new DateTime(2023, 4, 14, 13, 4, 56, 348, DateTimeKind.Local).AddTicks(3925), new Guid("6d9f3674-2a4e-4b61-8ba2-2395482a8397"), new Guid("fdda4973-d2aa-4df6-a686-594e85d36833") },
                    { new Guid("17482f29-a62c-4211-9587-8ae30efb4f20"), new Guid("65d6f084-0f0c-4ba8-9ea9-4f278a3e241d"), new DateTime(2023, 4, 14, 15, 21, 1, 392, DateTimeKind.Local).AddTicks(846), new Guid("cb76051d-84e5-46f3-a230-2cd0d5f30d77"), new Guid("5746c411-8c51-412a-93d4-73a11f5dca93") },
                    { new Guid("174f7cd0-da8e-43c7-b54f-f0b9892f500b"), new Guid("9614297a-5810-4d1f-a4ea-5bec1972368e"), new DateTime(2023, 4, 14, 15, 51, 35, 781, DateTimeKind.Local).AddTicks(5454), new Guid("a8364632-afe2-4d4f-b4d8-c9693df5efb9"), new Guid("d77a3211-15ac-4f1f-be71-6323872f5954") },
                    { new Guid("21098cb4-74ba-4b57-9cbe-3116849c59e1"), new Guid("27ac3e41-3531-429b-968f-0e0fab929589"), new DateTime(2023, 4, 14, 21, 1, 16, 121, DateTimeKind.Local).AddTicks(7332), new Guid("31bbb11e-571d-4eca-a069-b7ceba8bcb97"), new Guid("6db9ce7c-287d-474b-9ee4-58558a53e8b8") },
                    { new Guid("2318dc5d-59af-4756-85bf-9bc2ec8a288e"), new Guid("4894d93d-a65a-4b85-aeef-c7b292e3e4c6"), new DateTime(2023, 4, 15, 9, 12, 57, 261, DateTimeKind.Local).AddTicks(4245), new Guid("dd317f36-fba7-47bb-a907-7c2f8e5bc983"), new Guid("1b85455f-b827-42e6-855c-36cad3e88a3e") },
                    { new Guid("2b73fd6a-a64b-4539-9710-e8de5ce8d51c"), new Guid("d131eafd-86f1-4431-9048-4c6c396beb80"), new DateTime(2023, 4, 15, 10, 2, 14, 953, DateTimeKind.Local).AddTicks(7474), new Guid("ed639751-bd69-4712-92f4-728b1b89c173"), new Guid("eaeb01c4-9e06-492b-951b-b67f96d7e6f2") },
                    { new Guid("3fca3502-b9b8-4be2-a1f8-bcecde79ee6f"), new Guid("42dc7f53-50ee-4b48-9a5e-f96cea034bb5"), new DateTime(2023, 4, 15, 12, 3, 39, 749, DateTimeKind.Local).AddTicks(4914), new Guid("029f71c6-2326-48d6-b347-2d86ef77e587"), new Guid("896163a6-2134-4104-9b48-6442254f18bc") },
                    { new Guid("4f134c39-3efa-44b8-9609-e2f6fc772f32"), new Guid("23b3528a-0015-4c54-80d5-5b79afebd7f9"), new DateTime(2023, 4, 14, 17, 13, 9, 611, DateTimeKind.Local).AddTicks(552), new Guid("659015bb-49c5-4f54-967a-143d162b1d95"), new Guid("6f1a1738-e6ad-4d29-afdc-952edd10ac36") },
                    { new Guid("51874478-8544-4c97-b03a-599e0b75151d"), new Guid("872021c0-cb0b-43fe-b172-727df7e21122"), new DateTime(2023, 4, 15, 10, 47, 13, 365, DateTimeKind.Local).AddTicks(4935), new Guid("6d9f3674-2a4e-4b61-8ba2-2395482a8397"), new Guid("3ce5bfde-5c84-45aa-b77b-ff8fd39c0976") },
                    { new Guid("55e4f49e-d405-46c9-80c5-76c97ad64c8a"), new Guid("23b3528a-0015-4c54-80d5-5b79afebd7f9"), new DateTime(2023, 4, 14, 14, 44, 5, 394, DateTimeKind.Local).AddTicks(1113), new Guid("5fbdd46b-d0b5-4543-a301-559052b522ed"), new Guid("f8954168-7941-488a-a641-d3eb704dbfe9") },
                    { new Guid("561edde2-eacd-48a6-8aea-56ab31c2bbda"), new Guid("2e668adb-e696-42ae-bdbe-2abd5e17de89"), new DateTime(2023, 4, 15, 10, 4, 21, 377, DateTimeKind.Local).AddTicks(7709), new Guid("62768908-6ea3-40f6-83e7-e406a54de05a"), new Guid("eaeb01c4-9e06-492b-951b-b67f96d7e6f2") },
                    { new Guid("5dc62535-ac54-49d8-9689-3be0a71ae30f"), new Guid("23b3528a-0015-4c54-80d5-5b79afebd7f9"), new DateTime(2023, 4, 15, 10, 23, 9, 148, DateTimeKind.Local).AddTicks(7059), new Guid("3d343dd4-0007-4c8e-8d96-3d8be854c2e1"), new Guid("90c782bd-902a-4764-a6ad-83f2581e9f32") },
                    { new Guid("5f0213a0-2537-4d57-836d-974cbb2d6dcc"), new Guid("d8fb64be-955b-4be2-8fb1-aedd495b77a9"), new DateTime(2023, 4, 15, 8, 16, 27, 180, DateTimeKind.Local).AddTicks(841), new Guid("46dfb232-6235-485c-8da9-b60e5e15ba32"), new Guid("90c782bd-902a-4764-a6ad-83f2581e9f32") },
                    { new Guid("5f37e354-136e-4e15-93f1-7520233f6409"), new Guid("4894d93d-a65a-4b85-aeef-c7b292e3e4c6"), new DateTime(2023, 4, 15, 9, 41, 45, 302, DateTimeKind.Local).AddTicks(1706), new Guid("b35364b5-955a-481f-927a-3934ebde2bea"), new Guid("f8954168-7941-488a-a641-d3eb704dbfe9") },
                    { new Guid("6758f564-1645-48c7-880c-368815f2ff6d"), new Guid("d8fb64be-955b-4be2-8fb1-aedd495b77a9"), new DateTime(2023, 4, 14, 20, 29, 10, 96, DateTimeKind.Local).AddTicks(9644), new Guid("659015bb-49c5-4f54-967a-143d162b1d95"), new Guid("a3569e74-209c-4b28-83b4-2219cec7da22") },
                    { new Guid("84fecc35-db2d-4b51-afe8-8c0c327a9af1"), new Guid("58885961-cd1e-4c52-9f09-1c5df88b910b"), new DateTime(2023, 4, 15, 1, 16, 45, 848, DateTimeKind.Local).AddTicks(6153), new Guid("b1ab6962-f308-48e8-8bca-d162b21ec013"), new Guid("fdda4973-d2aa-4df6-a686-594e85d36833") },
                    { new Guid("9905131f-9f50-4e6b-a7e6-a921fd9ae242"), new Guid("4894d93d-a65a-4b85-aeef-c7b292e3e4c6"), new DateTime(2023, 4, 14, 19, 47, 12, 875, DateTimeKind.Local).AddTicks(2440), new Guid("b1ab6962-f308-48e8-8bca-d162b21ec013"), new Guid("6db9ce7c-287d-474b-9ee4-58558a53e8b8") },
                    { new Guid("9efcc970-8b93-4c5c-affd-def7d852d3bb"), new Guid("9614297a-5810-4d1f-a4ea-5bec1972368e"), new DateTime(2023, 4, 15, 3, 52, 29, 912, DateTimeKind.Local).AddTicks(2789), new Guid("463940e4-d568-412f-8fbe-af0affab79a5"), new Guid("521ba706-10a4-433c-9df2-a68f050afa00") },
                    { new Guid("b6a741e6-cd3c-4c84-b4c6-f3cd7946df7a"), new Guid("23b3528a-0015-4c54-80d5-5b79afebd7f9"), new DateTime(2023, 4, 15, 1, 20, 38, 807, DateTimeKind.Local).AddTicks(7328), new Guid("b164503e-dcda-49e5-8042-7448af54e6e4"), new Guid("eaeb01c4-9e06-492b-951b-b67f96d7e6f2") },
                    { new Guid("bcf7df0e-51d7-4498-963b-bdfa4f09c533"), new Guid("4894d93d-a65a-4b85-aeef-c7b292e3e4c6"), new DateTime(2023, 4, 15, 6, 56, 43, 19, DateTimeKind.Local).AddTicks(8605), new Guid("46dfb232-6235-485c-8da9-b60e5e15ba32"), new Guid("6db9ce7c-287d-474b-9ee4-58558a53e8b8") },
                    { new Guid("bf372875-ac7d-49a9-a5b7-2fa6455cc5fa"), new Guid("9614297a-5810-4d1f-a4ea-5bec1972368e"), new DateTime(2023, 4, 15, 5, 40, 41, 153, DateTimeKind.Local).AddTicks(996), new Guid("463940e4-d568-412f-8fbe-af0affab79a5"), new Guid("fdda4973-d2aa-4df6-a686-594e85d36833") },
                    { new Guid("c217d137-778b-49b9-bb13-88ad3b1f53f7"), new Guid("27ac3e41-3531-429b-968f-0e0fab929589"), new DateTime(2023, 4, 15, 10, 14, 30, 577, DateTimeKind.Local).AddTicks(2044), new Guid("ec99b2e6-bec1-4dbe-90f2-3e6828e4d93c"), new Guid("42245df4-d04c-46f0-8938-6af7b6ccdb38") },
                    { new Guid("d77b4ef1-e6a7-46f5-a268-27000f143a22"), new Guid("d131eafd-86f1-4431-9048-4c6c396beb80"), new DateTime(2023, 4, 14, 21, 45, 16, 854, DateTimeKind.Local).AddTicks(9256), new Guid("b1ab6962-f308-48e8-8bca-d162b21ec013"), new Guid("3ce5bfde-5c84-45aa-b77b-ff8fd39c0976") },
                    { new Guid("dec42efe-5f20-43b4-b480-34f113b70e8a"), new Guid("23b3528a-0015-4c54-80d5-5b79afebd7f9"), new DateTime(2023, 4, 14, 15, 47, 45, 138, DateTimeKind.Local).AddTicks(5340), new Guid("e41382ab-19a4-4cd0-8cde-621dde807841"), new Guid("f8954168-7941-488a-a641-d3eb704dbfe9") },
                    { new Guid("f2155623-e6ef-4648-bbbc-091c5cc43f8e"), new Guid("872021c0-cb0b-43fe-b172-727df7e21122"), new DateTime(2023, 4, 14, 14, 38, 46, 983, DateTimeKind.Local).AddTicks(5936), new Guid("37eafcab-a577-4426-8915-e176a860aead"), new Guid("6f1a1738-e6ad-4d29-afdc-952edd10ac36") },
                    { new Guid("f244e454-9461-41c2-b763-e5ad21d39bb3"), new Guid("42dc7f53-50ee-4b48-9a5e-f96cea034bb5"), new DateTime(2023, 4, 15, 1, 44, 42, 35, DateTimeKind.Local).AddTicks(880), new Guid("b164503e-dcda-49e5-8042-7448af54e6e4"), new Guid("8893c552-d404-45bc-8b56-7a50017cf5ac") },
                    { new Guid("f32a2c5a-542d-43d5-b4be-cc4203782d75"), new Guid("27ac3e41-3531-429b-968f-0e0fab929589"), new DateTime(2023, 4, 14, 15, 8, 35, 932, DateTimeKind.Local).AddTicks(1269), new Guid("bcbaef2a-dd26-4ec7-92c1-0c52d66653de"), new Guid("fdda4973-d2aa-4df6-a686-594e85d36833") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Customer",
                table: "Sales",
                column: "Customer");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Product",
                table: "Sales",
                column: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Store",
                table: "Sales",
                column: "Store");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
