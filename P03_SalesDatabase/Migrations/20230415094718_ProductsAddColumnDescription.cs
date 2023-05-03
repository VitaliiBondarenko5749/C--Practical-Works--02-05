using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAddColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0d159983-aeab-4a6d-909a-9830f52e0ba1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("19abb28e-ece2-4d98-b182-24d8847c8d2c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3ef96646-77a3-4ef5-8dd0-de6f59d54ddc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4bf4ded3-5c39-43af-a1b1-f58f1479b3dd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4d305524-3ef5-4ee0-ba66-d7774344987c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8dec2151-7ece-4225-9174-8daf51bae68e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ad51c5e7-3685-49fe-b1d4-5554d8dc4d94"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c242ebe9-a273-497b-b3ed-dd7b094c6476"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d4f2a0d5-1567-4c93-8b0e-284dec50dfe9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("06657346-12d2-4638-a023-e75e1f6b3354"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1095f0b1-cce8-423a-af19-c4cdf8c19158"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2dd328a0-4b2f-409e-a824-c484574a3d97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("611c9e00-7d77-40e9-a355-2c3a45503183"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("612f0ef7-656a-4897-8bce-ba738132c839"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7e0afba3-6f83-48a3-a79a-f7b2e7122b49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("83742aae-610d-4f61-a5d5-7e2f66d2e73a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8964f3c3-9a27-4daf-9334-dd44e40cb90f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9102fead-d434-4f69-9eab-838178697967"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("922b39a9-86f7-4d65-9321-8da357e3a1f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9ad63002-9d2b-4f77-94a2-5a47c0ef689b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b0a5f1fb-5bcf-4426-b0e3-cc3e3faed721"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d9dc11b2-84c2-4ea1-8a14-5347075826c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dae1a5a6-881f-48eb-a066-9a455b4ae7f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd084c63-b776-4cd2-b85e-e2cec6b5746a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e548160d-fbc1-4bcf-a12c-c6336c278f26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f0df89a4-948f-4a2c-94ad-a098e1775dd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f8032cd1-85de-40eb-aa27-771f4deb4e81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc6a8d35-83df-445e-9337-bbc706c2ed73"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("009822ce-03c9-4bd6-9c52-29c714919020"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("13fd42b5-1ddb-4f14-9163-eda9aadc4638"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("15ca4e81-0b68-4820-aab6-1f752ad58344"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("16ac77b5-a90a-4f59-a49c-81c9dd28b73f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("17482f29-a62c-4211-9587-8ae30efb4f20"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("174f7cd0-da8e-43c7-b54f-f0b9892f500b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("21098cb4-74ba-4b57-9cbe-3116849c59e1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2318dc5d-59af-4756-85bf-9bc2ec8a288e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2b73fd6a-a64b-4539-9710-e8de5ce8d51c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3fca3502-b9b8-4be2-a1f8-bcecde79ee6f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4f134c39-3efa-44b8-9609-e2f6fc772f32"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("51874478-8544-4c97-b03a-599e0b75151d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("55e4f49e-d405-46c9-80c5-76c97ad64c8a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("561edde2-eacd-48a6-8aea-56ab31c2bbda"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5dc62535-ac54-49d8-9689-3be0a71ae30f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5f0213a0-2537-4d57-836d-974cbb2d6dcc"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5f37e354-136e-4e15-93f1-7520233f6409"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("6758f564-1645-48c7-880c-368815f2ff6d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("84fecc35-db2d-4b51-afe8-8c0c327a9af1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9905131f-9f50-4e6b-a7e6-a921fd9ae242"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9efcc970-8b93-4c5c-affd-def7d852d3bb"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b6a741e6-cd3c-4c84-b4c6-f3cd7946df7a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("bcf7df0e-51d7-4498-963b-bdfa4f09c533"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("bf372875-ac7d-49a9-a5b7-2fa6455cc5fa"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c217d137-778b-49b9-bb13-88ad3b1f53f7"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d77b4ef1-e6a7-46f5-a268-27000f143a22"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("dec42efe-5f20-43b4-b480-34f113b70e8a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f2155623-e6ef-4648-bbbc-091c5cc43f8e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f244e454-9461-41c2-b763-e5ad21d39bb3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f32a2c5a-542d-43d5-b4be-cc4203782d75"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("1737871e-8487-43f7-b676-d9dd13c53b9a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("6a4eeabf-c150-449f-8a1b-5c8c01e74837"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("9b752c22-78ec-4c3c-a013-bae2434ec147"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("cf871379-e6bf-4c19-b100-d2dbffe4f28e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("23b3528a-0015-4c54-80d5-5b79afebd7f9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("27ac3e41-3531-429b-968f-0e0fab929589"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2e668adb-e696-42ae-bdbe-2abd5e17de89"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("42dc7f53-50ee-4b48-9a5e-f96cea034bb5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4894d93d-a65a-4b85-aeef-c7b292e3e4c6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("58885961-cd1e-4c52-9f09-1c5df88b910b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("65d6f084-0f0c-4ba8-9ea9-4f278a3e241d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("872021c0-cb0b-43fe-b172-727df7e21122"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9614297a-5810-4d1f-a4ea-5bec1972368e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d131eafd-86f1-4431-9048-4c6c396beb80"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d8fb64be-955b-4be2-8fb1-aedd495b77a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("029f71c6-2326-48d6-b347-2d86ef77e587"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1dc01f2c-b787-4ef7-85f5-b9f5ebd65873"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("31bbb11e-571d-4eca-a069-b7ceba8bcb97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("37eafcab-a577-4426-8915-e176a860aead"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3d343dd4-0007-4c8e-8d96-3d8be854c2e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("463940e4-d568-412f-8fbe-af0affab79a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("46dfb232-6235-485c-8da9-b60e5e15ba32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5fbdd46b-d0b5-4543-a301-559052b522ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("62768908-6ea3-40f6-83e7-e406a54de05a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("659015bb-49c5-4f54-967a-143d162b1d95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6d9f3674-2a4e-4b61-8ba2-2395482a8397"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a8364632-afe2-4d4f-b4d8-c9693df5efb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b164503e-dcda-49e5-8042-7448af54e6e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b1ab6962-f308-48e8-8bca-d162b21ec013"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b35364b5-955a-481f-927a-3934ebde2bea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bcbaef2a-dd26-4ec7-92c1-0c52d66653de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb76051d-84e5-46f3-a230-2cd0d5f30d77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd317f36-fba7-47bb-a907-7c2f8e5bc983"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e41382ab-19a4-4cd0-8cde-621dde807841"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ec99b2e6-bec1-4dbe-90f2-3e6828e4d93c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ed639751-bd69-4712-92f4-728b1b89c173"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("1b85455f-b827-42e6-855c-36cad3e88a3e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("3ce5bfde-5c84-45aa-b77b-ff8fd39c0976"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("42245df4-d04c-46f0-8938-6af7b6ccdb38"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("521ba706-10a4-433c-9df2-a68f050afa00"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("5746c411-8c51-412a-93d4-73a11f5dca93"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("6db9ce7c-287d-474b-9ee4-58558a53e8b8"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("6f1a1738-e6ad-4d29-afdc-952edd10ac36"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("73353e38-62c4-4293-aeec-02eb2652b98c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("8893c552-d404-45bc-8b56-7a50017cf5ac"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("896163a6-2134-4104-9b48-6442254f18bc"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("90c782bd-902a-4764-a6ad-83f2581e9f32"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("a3569e74-209c-4b28-83b4-2219cec7da22"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("d77a3211-15ac-4f1f-be71-6323872f5954"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("eaeb01c4-9e06-492b-951b-b67f96d7e6f2"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("f8954168-7941-488a-a641-d3eb704dbfe9"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("fdda4973-d2aa-4df6-a686-594e85d36833"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                defaultValue: "No description");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("0cb9f7a9-b855-4ed0-9ce3-b0ab6231490b"), "6767-1267-0538-9644", "Renee_Ledner@gmail.com", "Renee Ledner" },
                    { new Guid("0e63364d-0fbe-4709-9a1a-afe6ac7b7028"), "4149429032890", "Mark.Zulauf35@yahoo.com", "Mark Zulauf" },
                    { new Guid("143a6814-579e-4898-90dc-32459715675b"), "5110-8582-2841-5821", "Hugh56@gmail.com", "Hugh Littel" },
                    { new Guid("1d30cc86-7af1-4c30-b5c0-2a343d725a32"), "3551-0032-5902-2912", "Geoffrey3@yahoo.com", "Geoffrey Haag" },
                    { new Guid("4849cfd9-69fd-404c-91ab-bccf449730d2"), "5447-5427-3434-7090", "Jean_Hirthe@yahoo.com", "Jean Hirthe" },
                    { new Guid("5d71c306-bfbd-49f8-a771-c80f3df1abf2"), "3408-452303-94444", "Jane.Schmitt@hotmail.com", "Jane Schmitt" },
                    { new Guid("5fa32538-7d44-4f21-8068-c0464bdd2ef2"), "4809848351011", "Ernest.Zieme@hotmail.com", "Ernest Zieme" },
                    { new Guid("6707c0f2-2ea3-42a3-b90d-65d88e5942b4"), "5456-1508-7622-9452", "Shannon_Ryan@gmail.com", "Shannon Ryan" },
                    { new Guid("763e24cd-311a-4da7-8b77-fca2d90ac377"), "3403-862733-83077", "Hope_Fadel22@hotmail.com", "Hope Fadel" },
                    { new Guid("80c5a775-b966-4f47-a9e4-7032dea2b047"), "6759-9158-6976-8551-597", "Milton.West@yahoo.com", "Milton West" },
                    { new Guid("8c2b163a-2abc-49c6-a21a-325170f54185"), "6771-8991-7378-1484", "Dixie_Block26@hotmail.com", "Dixie Block" },
                    { new Guid("8e7c619f-a31f-43fb-8d29-630a2eb3b52b"), "3529-1331-6415-2634", "Garrett17@yahoo.com", "Garrett Rowe" },
                    { new Guid("8f9dc5e1-c2c6-42e7-a2fd-2b78dcd59ce2"), "3034-124371-9848", "Nancy.Lemke@hotmail.com", "Nancy Lemke" },
                    { new Guid("b72b4e86-e813-4149-ab8c-fa04a8b5c28c"), "6767-7633-2674-1275-07", "Rufus_Murray30@gmail.com", "Rufus Murray" },
                    { new Guid("ccfd8498-127a-4326-9c20-88a9624f4b41"), "3702-142429-42422", "Linda_Hartmann91@gmail.com", "Linda Hartmann" },
                    { new Guid("d0589296-b3fc-487d-9a08-62134543865b"), "6759-4999-8496-3227", "Naomi75@hotmail.com", "Naomi Shields" },
                    { new Guid("dbcdf2a8-3bf9-45df-8f4b-312236e6d0c3"), "6767-4951-0539-3823", "Dana49@yahoo.com", "Dana Sawayn" },
                    { new Guid("dc10c621-dd52-401d-b010-6b32572bc2ff"), "6379-7789-3401-3591", "Robyn_Skiles36@yahoo.com", "Robyn Skiles" },
                    { new Guid("e3eae361-cab6-4747-ac79-de946cd51640"), "4441925733463", "Leona.Gaylord@yahoo.com", "Leona Gaylord" },
                    { new Guid("fe4ccf93-bf41-4100-b448-97299028dd7a"), "3717-859936-58142", "Faith_Hettinger95@gmail.com", "Faith Hettinger" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("01078ea6-ccf2-4c9b-865b-67bb3007f120"), "Rustic Plastic Towels", 7438.654777242870000m, 178.8708f },
                    { new Guid("03cd2876-5266-45e5-9771-6678ac7cee48"), "Intelligent Fresh Towels", 1755.610423260230000m, 120.461655f },
                    { new Guid("17f78bb0-c2c3-4d7d-8bf9-9dc26861e122"), "Unbranded Steel Table", 2061.530558027270000m, 990.4327f },
                    { new Guid("1cef0c07-cd6d-4966-88bb-6b46835726a7"), "Sleek Steel Sausages", 9727.512116588920000m, 113.96786f },
                    { new Guid("2a66a3ca-99ca-4333-8845-383c753edbae"), "Practical Metal Shirt", 8650.798596386770000m, 661.45654f },
                    { new Guid("2c1a522f-454b-40f5-b1d4-92a0b7f0ab5e"), "Tasty Rubber Shoes", 4751.007084215170000m, 239.0847f },
                    { new Guid("390161b6-8098-486c-95ae-8fb18327acef"), "Small Rubber Towels", 6148.59587338330000m, 791.2883f },
                    { new Guid("471d1f14-1f6e-41b9-8441-793362d4b146"), "Small Metal Shoes", 8413.131585984080000m, 510.38568f },
                    { new Guid("50bc0b7a-0876-42c8-ad30-62b99780d158"), "Handcrafted Fresh Chips", 2598.87734306150000m, 11.997452f },
                    { new Guid("64064e0a-9ca4-4cca-bc25-d47217d6e357"), "Refined Wooden Hat", 1488.926560587660000m, 121.8415f },
                    { new Guid("66ca492f-b24a-4070-9bf2-ca195de0c570"), "Rustic Cotton Sausages", 2995.036135064540000m, 660.008f },
                    { new Guid("7201abd4-8a05-428f-a18e-979acc095e61"), "Licensed Granite Towels", 3101.742079616540000m, 287.0193f },
                    { new Guid("7435d83b-bd82-4d34-a3c3-396ee701db9e"), "Tasty Metal Chicken", 769.0837182970590000m, 971.50977f },
                    { new Guid("752bac75-d2e8-43f8-be4f-77d2d9967e9e"), "Gorgeous Frozen Mouse", 5935.677823315250000m, 106.81335f },
                    { new Guid("77e87ed2-93e2-49c7-ab2e-d6ded7c6cd24"), "Handmade Steel Cheese", 3662.058424883210000m, 923.27435f },
                    { new Guid("7eadc9eb-93b2-4f9c-afa9-6300de89220b"), "Incredible Cotton Shirt", 730.3509304580240000m, 959.0715f },
                    { new Guid("86ec2573-3aff-4602-88d5-27ec7ff15f28"), "Generic Cotton Chicken", 6478.547860343920000m, 618.7115f },
                    { new Guid("88ebdedc-c49c-4d84-a18d-c81c1e708e42"), "Fantastic Cotton Bike", 443.9219226908930000m, 689.8766f },
                    { new Guid("8c380f67-c27b-43a2-9b1b-51eac3f1c424"), "Handmade Soft Pants", 8368.725206375010000m, 552.0674f },
                    { new Guid("8cfb0875-4233-4dd5-911e-d6e596774447"), "Incredible Steel Shoes", 7700.150320721070000m, 694.65045f },
                    { new Guid("8de1c672-4eb6-41eb-987f-3ef13496ecee"), "Ergonomic Fresh Ball", 4167.361103159210000m, 976.0709f },
                    { new Guid("934b04d4-ee9d-4e3b-ac22-f109e9869581"), "Ergonomic Steel Mouse", 6556.19849189910000m, 108.339554f },
                    { new Guid("9b99ba87-57ec-4617-97c6-13e70e5bbdd6"), "Tasty Granite Mouse", 1090.988373584540000m, 775.49756f },
                    { new Guid("9d8188a5-012b-4023-b5e0-24873b1b6fc7"), "Gorgeous Granite Cheese", 7316.988455670620000m, 498.58157f },
                    { new Guid("9df986b4-e049-4092-a6de-ced84af9b186"), "Handmade Concrete Salad", 2219.506012757110000m, 203.96568f },
                    { new Guid("a12aaaae-24ae-4695-820d-5995174630f7"), "Handcrafted Soft Chair", 827.9090010094720000m, 943.22516f },
                    { new Guid("b225ef06-9127-4caf-83e8-0c79b6a9dd9c"), "Fantastic Soft Computer", 7508.107787716120000m, 721.56256f },
                    { new Guid("b5d507eb-c485-4120-90ca-3f29f3cbb419"), "Fantastic Rubber Hat", 5088.66550033090000m, 306.8201f },
                    { new Guid("b727fbcf-308c-4541-9e5f-a6a99c266137"), "Small Soft Car", 2425.155345856720000m, 594.31445f },
                    { new Guid("bedcd76f-e04e-4926-ac12-a7bd0846f88e"), "Tasty Granite Bike", 8300.200483069320000m, 815.382f },
                    { new Guid("c7f8d80e-1f17-45c2-b2bc-5119a6b008d5"), "Rustic Soft Salad", 7331.92354266660000m, 324.22873f },
                    { new Guid("cf07e578-f7ce-4879-b711-95939f88eac5"), "Refined Frozen Shirt", 5482.219231769770000m, 381.44608f },
                    { new Guid("d8d73bdf-f421-432d-9d9f-36eddbc92bd9"), "Gorgeous Plastic Pants", 1267.933249209990000m, 699.5111f },
                    { new Guid("dca87198-285e-44e4-b2fa-0e8b461e8d37"), "Small Concrete Ball", 3300.018266932810000m, 561.2882f },
                    { new Guid("dd926ac5-5d14-4fc7-8903-b1a9c282f08f"), "Tasty Plastic Shirt", 9826.683441549920000m, 98.916794f },
                    { new Guid("df263ef9-13c7-448a-8628-340a1ab0e514"), "Unbranded Frozen Towels", 4599.122926122960000m, 231.49318f },
                    { new Guid("e4c81bf7-89be-4508-b72b-95a695d44c20"), "Practical Fresh Shoes", 6336.967483331290000m, 75.160675f },
                    { new Guid("ebbef47c-2372-4fa5-b188-a5a769cd9b07"), "Small Fresh Fish", 1414.538107268790000m, 204.9221f },
                    { new Guid("f473358f-e55d-42a0-9bb4-402117c63e49"), "Incredible Fresh Keyboard", 1403.397532696120000m, 77.581635f },
                    { new Guid("fef634b4-dd46-4c1c-b4cb-6f5e84615608"), "Sleek Steel Bike", 799.5923398033030000m, 248.24646f }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { new Guid("10391290-75b1-456d-9c80-343945d0c18d"), "Nolan, Gutkowski and Morissette" },
                    { new Guid("13349fec-40ce-4b17-a2db-ce2a5c1bc705"), "Gislason, Macejkovic and Kreiger" },
                    { new Guid("134b2603-2272-47c5-8e30-77fdd2f3f7ef"), "Gottlieb and Sons" },
                    { new Guid("16553225-5a91-4eef-b6b1-2529991e9da6"), "Jacobs - Gibson" },
                    { new Guid("3578e5f8-5a0b-4c54-a63b-ab11e7d36fc8"), "McKenzie - Jones" },
                    { new Guid("35fd6ab9-961d-4937-9705-09579dc8be5e"), "Schultz - Walter" },
                    { new Guid("3939e1f9-94f3-48c3-96e5-4a284211eea1"), "Hudson - Hodkiewicz" },
                    { new Guid("425d8446-78e1-4db7-9dae-e822a16e6a78"), "Carroll, Schuppe and Beier" },
                    { new Guid("44239b99-dc63-4b87-b9ff-964bc43ad7f2"), "Conn - Bauch" },
                    { new Guid("5d74e877-71e6-443b-953b-50ab356f147d"), "Shanahan - Cole" },
                    { new Guid("72177cb4-d961-47fa-b784-f310658f1b21"), "Anderson Group" },
                    { new Guid("728c83bf-d917-48ba-9ed9-07beb6a52a67"), "Schiller and Sons" },
                    { new Guid("a4aca96b-8726-4b51-ab77-37befb65a38f"), "Murphy - Bartell" },
                    { new Guid("a615e8f2-b613-4d05-9ab9-93350af90cfa"), "Harris, Schmitt and Schuster" },
                    { new Guid("b4ce6892-363f-4608-93ec-87fb51d012be"), "Sporer Inc" },
                    { new Guid("beaac625-4e29-4163-9527-443a23bb742b"), "Maggio, Bode and Wunsch" },
                    { new Guid("c90d40c5-d280-4510-bebb-e924bee7bc71"), "Johnson Inc" },
                    { new Guid("e0059e34-ada5-4d08-a92a-58a0297e27fe"), "Terry LLC" },
                    { new Guid("fb103200-2d0d-4ba7-a95c-c0a110fa0340"), "Murazik Inc" },
                    { new Guid("fc8341df-7422-437f-9452-8b4671fc7878"), "Kiehn - Maggio" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "Customer", "Date", "Product", "Store" },
                values: new object[,]
                {
                    { new Guid("052db8a0-0bfa-4f21-a9df-b2853d4b8476"), new Guid("dc10c621-dd52-401d-b010-6b32572bc2ff"), new DateTime(2023, 4, 14, 15, 14, 57, 681, DateTimeKind.Local).AddTicks(8221), new Guid("8cfb0875-4233-4dd5-911e-d6e596774447"), new Guid("3939e1f9-94f3-48c3-96e5-4a284211eea1") },
                    { new Guid("14db4a0b-4bcc-4c78-a606-8f9231993ffe"), new Guid("4849cfd9-69fd-404c-91ab-bccf449730d2"), new DateTime(2023, 4, 15, 10, 5, 48, 766, DateTimeKind.Local).AddTicks(3087), new Guid("dd926ac5-5d14-4fc7-8903-b1a9c282f08f"), new Guid("35fd6ab9-961d-4937-9705-09579dc8be5e") },
                    { new Guid("1c033639-aa7c-449a-a63e-3c184f1b2c57"), new Guid("5d71c306-bfbd-49f8-a771-c80f3df1abf2"), new DateTime(2023, 4, 14, 16, 17, 50, 231, DateTimeKind.Local).AddTicks(3712), new Guid("1cef0c07-cd6d-4966-88bb-6b46835726a7"), new Guid("3939e1f9-94f3-48c3-96e5-4a284211eea1") },
                    { new Guid("1e31e1fc-a8f8-42c4-ada2-e40021c9191f"), new Guid("4849cfd9-69fd-404c-91ab-bccf449730d2"), new DateTime(2023, 4, 14, 18, 35, 4, 145, DateTimeKind.Local).AddTicks(4465), new Guid("b727fbcf-308c-4541-9e5f-a6a99c266137"), new Guid("e0059e34-ada5-4d08-a92a-58a0297e27fe") },
                    { new Guid("26bfe37e-2f12-4ac2-82e8-1a39a707ee2a"), new Guid("1d30cc86-7af1-4c30-b5c0-2a343d725a32"), new DateTime(2023, 4, 14, 16, 31, 4, 591, DateTimeKind.Local).AddTicks(2170), new Guid("b5d507eb-c485-4120-90ca-3f29f3cbb419"), new Guid("beaac625-4e29-4163-9527-443a23bb742b") },
                    { new Guid("39b0d991-49db-4325-8352-f7c19bb3ffb0"), new Guid("0e63364d-0fbe-4709-9a1a-afe6ac7b7028"), new DateTime(2023, 4, 14, 13, 8, 4, 860, DateTimeKind.Local).AddTicks(9280), new Guid("a12aaaae-24ae-4695-820d-5995174630f7"), new Guid("35fd6ab9-961d-4937-9705-09579dc8be5e") },
                    { new Guid("3ca6d2b5-cdf6-41d4-8585-cdedb65dc917"), new Guid("dbcdf2a8-3bf9-45df-8f4b-312236e6d0c3"), new DateTime(2023, 4, 14, 20, 58, 40, 178, DateTimeKind.Local).AddTicks(9168), new Guid("b225ef06-9127-4caf-83e8-0c79b6a9dd9c"), new Guid("fb103200-2d0d-4ba7-a95c-c0a110fa0340") },
                    { new Guid("3d1c49a8-c2e9-476b-a3b6-ff00c287a0fc"), new Guid("fe4ccf93-bf41-4100-b448-97299028dd7a"), new DateTime(2023, 4, 14, 16, 19, 24, 185, DateTimeKind.Local).AddTicks(9088), new Guid("7435d83b-bd82-4d34-a3c3-396ee701db9e"), new Guid("e0059e34-ada5-4d08-a92a-58a0297e27fe") },
                    { new Guid("46ead47a-a1e1-4a51-aa77-17e1c4d931c6"), new Guid("8e7c619f-a31f-43fb-8d29-630a2eb3b52b"), new DateTime(2023, 4, 14, 16, 17, 57, 801, DateTimeKind.Local).AddTicks(8321), new Guid("f473358f-e55d-42a0-9bb4-402117c63e49"), new Guid("3939e1f9-94f3-48c3-96e5-4a284211eea1") },
                    { new Guid("72fb70df-4782-4794-ae65-b4739d4d346d"), new Guid("dbcdf2a8-3bf9-45df-8f4b-312236e6d0c3"), new DateTime(2023, 4, 14, 21, 30, 47, 543, DateTimeKind.Local).AddTicks(4557), new Guid("c7f8d80e-1f17-45c2-b2bc-5119a6b008d5"), new Guid("44239b99-dc63-4b87-b9ff-964bc43ad7f2") },
                    { new Guid("79cc7737-4631-4924-b429-1b87afa1bc1c"), new Guid("4849cfd9-69fd-404c-91ab-bccf449730d2"), new DateTime(2023, 4, 15, 3, 36, 28, 571, DateTimeKind.Local).AddTicks(9181), new Guid("d8d73bdf-f421-432d-9d9f-36eddbc92bd9"), new Guid("10391290-75b1-456d-9c80-343945d0c18d") },
                    { new Guid("932eca28-0cc2-40f0-aaf7-c4fb33999182"), new Guid("8c2b163a-2abc-49c6-a21a-325170f54185"), new DateTime(2023, 4, 14, 18, 22, 0, 638, DateTimeKind.Local).AddTicks(8443), new Guid("7eadc9eb-93b2-4f9c-afa9-6300de89220b"), new Guid("beaac625-4e29-4163-9527-443a23bb742b") },
                    { new Guid("96b2fc81-ce29-46a6-be2b-77a8870aa3ee"), new Guid("e3eae361-cab6-4747-ac79-de946cd51640"), new DateTime(2023, 4, 15, 11, 0, 0, 836, DateTimeKind.Local).AddTicks(9033), new Guid("86ec2573-3aff-4602-88d5-27ec7ff15f28"), new Guid("a4aca96b-8726-4b51-ab77-37befb65a38f") },
                    { new Guid("9c780ab9-c03c-4850-8cde-7c9c965e7778"), new Guid("8e7c619f-a31f-43fb-8d29-630a2eb3b52b"), new DateTime(2023, 4, 15, 3, 20, 26, 818, DateTimeKind.Local).AddTicks(3807), new Guid("86ec2573-3aff-4602-88d5-27ec7ff15f28"), new Guid("e0059e34-ada5-4d08-a92a-58a0297e27fe") },
                    { new Guid("a180b693-213e-4938-9559-bf394c189eda"), new Guid("8e7c619f-a31f-43fb-8d29-630a2eb3b52b"), new DateTime(2023, 4, 14, 23, 14, 31, 572, DateTimeKind.Local).AddTicks(1717), new Guid("b225ef06-9127-4caf-83e8-0c79b6a9dd9c"), new Guid("13349fec-40ce-4b17-a2db-ce2a5c1bc705") },
                    { new Guid("b2655f95-7427-437a-99ed-e3c31cb3c33c"), new Guid("0cb9f7a9-b855-4ed0-9ce3-b0ab6231490b"), new DateTime(2023, 4, 14, 22, 9, 50, 757, DateTimeKind.Local).AddTicks(4348), new Guid("b225ef06-9127-4caf-83e8-0c79b6a9dd9c"), new Guid("13349fec-40ce-4b17-a2db-ce2a5c1bc705") },
                    { new Guid("beafee79-a47f-432b-a338-99e0491548cf"), new Guid("5d71c306-bfbd-49f8-a771-c80f3df1abf2"), new DateTime(2023, 4, 14, 22, 31, 27, 312, DateTimeKind.Local).AddTicks(2299), new Guid("390161b6-8098-486c-95ae-8fb18327acef"), new Guid("b4ce6892-363f-4608-93ec-87fb51d012be") },
                    { new Guid("c496d4fa-df32-49d8-9286-3d9943307294"), new Guid("80c5a775-b966-4f47-a9e4-7032dea2b047"), new DateTime(2023, 4, 14, 23, 34, 21, 276, DateTimeKind.Local).AddTicks(9634), new Guid("64064e0a-9ca4-4cca-bc25-d47217d6e357"), new Guid("3578e5f8-5a0b-4c54-a63b-ab11e7d36fc8") },
                    { new Guid("cc02ab10-9e19-4209-af19-c5613aa752a5"), new Guid("0e63364d-0fbe-4709-9a1a-afe6ac7b7028"), new DateTime(2023, 4, 14, 13, 57, 17, 467, DateTimeKind.Local).AddTicks(369), new Guid("b225ef06-9127-4caf-83e8-0c79b6a9dd9c"), new Guid("72177cb4-d961-47fa-b784-f310658f1b21") },
                    { new Guid("d0f095fa-dc68-4892-beb8-67765f880309"), new Guid("5fa32538-7d44-4f21-8068-c0464bdd2ef2"), new DateTime(2023, 4, 15, 12, 20, 37, 167, DateTimeKind.Local).AddTicks(1793), new Guid("ebbef47c-2372-4fa5-b188-a5a769cd9b07"), new Guid("beaac625-4e29-4163-9527-443a23bb742b") },
                    { new Guid("d29ac925-fe79-4143-a865-a86bce7bf3c4"), new Guid("8e7c619f-a31f-43fb-8d29-630a2eb3b52b"), new DateTime(2023, 4, 15, 5, 42, 36, 455, DateTimeKind.Local).AddTicks(3737), new Guid("c7f8d80e-1f17-45c2-b2bc-5119a6b008d5"), new Guid("e0059e34-ada5-4d08-a92a-58a0297e27fe") },
                    { new Guid("da763356-a8ba-4cc5-8a15-638404eeb512"), new Guid("4849cfd9-69fd-404c-91ab-bccf449730d2"), new DateTime(2023, 4, 14, 23, 22, 51, 736, DateTimeKind.Local).AddTicks(1398), new Guid("7201abd4-8a05-428f-a18e-979acc095e61"), new Guid("13349fec-40ce-4b17-a2db-ce2a5c1bc705") },
                    { new Guid("dbb817c0-dd3f-4cf9-aed9-aafb72374ce3"), new Guid("6707c0f2-2ea3-42a3-b90d-65d88e5942b4"), new DateTime(2023, 4, 15, 8, 15, 32, 293, DateTimeKind.Local).AddTicks(1999), new Guid("dd926ac5-5d14-4fc7-8903-b1a9c282f08f"), new Guid("3578e5f8-5a0b-4c54-a63b-ab11e7d36fc8") },
                    { new Guid("e10019c9-d676-4d27-a27a-f0c82d7e1a97"), new Guid("e3eae361-cab6-4747-ac79-de946cd51640"), new DateTime(2023, 4, 15, 9, 25, 5, 637, DateTimeKind.Local).AddTicks(5583), new Guid("8c380f67-c27b-43a2-9b1b-51eac3f1c424"), new Guid("beaac625-4e29-4163-9527-443a23bb742b") },
                    { new Guid("e2070a5e-1d3d-4b94-8bdc-2b0b3ff7ab03"), new Guid("d0589296-b3fc-487d-9a08-62134543865b"), new DateTime(2023, 4, 14, 17, 31, 2, 699, DateTimeKind.Local).AddTicks(9201), new Guid("03cd2876-5266-45e5-9771-6678ac7cee48"), new Guid("13349fec-40ce-4b17-a2db-ce2a5c1bc705") },
                    { new Guid("e3515ec9-bfcb-4c4a-ae26-b61e4c7e2d52"), new Guid("4849cfd9-69fd-404c-91ab-bccf449730d2"), new DateTime(2023, 4, 14, 21, 33, 7, 605, DateTimeKind.Local).AddTicks(6802), new Guid("390161b6-8098-486c-95ae-8fb18327acef"), new Guid("e0059e34-ada5-4d08-a92a-58a0297e27fe") },
                    { new Guid("e9d32cbf-8f52-4f47-95ea-ac7083ee5ece"), new Guid("d0589296-b3fc-487d-9a08-62134543865b"), new DateTime(2023, 4, 15, 6, 22, 12, 829, DateTimeKind.Local).AddTicks(5922), new Guid("fef634b4-dd46-4c1c-b4cb-6f5e84615608"), new Guid("16553225-5a91-4eef-b6b1-2529991e9da6") },
                    { new Guid("f08fd549-6e56-470c-9325-6718d29b7698"), new Guid("8e7c619f-a31f-43fb-8d29-630a2eb3b52b"), new DateTime(2023, 4, 14, 12, 53, 45, 630, DateTimeKind.Local).AddTicks(7875), new Guid("471d1f14-1f6e-41b9-8441-793362d4b146"), new Guid("e0059e34-ada5-4d08-a92a-58a0297e27fe") },
                    { new Guid("f965aa36-b664-4b2e-a9d1-5005a16789ba"), new Guid("1d30cc86-7af1-4c30-b5c0-2a343d725a32"), new DateTime(2023, 4, 15, 11, 34, 36, 405, DateTimeKind.Local).AddTicks(9432), new Guid("9df986b4-e049-4092-a6de-ced84af9b186"), new Guid("134b2603-2272-47c5-8e30-77fdd2f3f7ef") },
                    { new Guid("fbbf48c5-f0a6-4054-80eb-5ad4d8736162"), new Guid("e3eae361-cab6-4747-ac79-de946cd51640"), new DateTime(2023, 4, 14, 16, 6, 47, 679, DateTimeKind.Local).AddTicks(3667), new Guid("86ec2573-3aff-4602-88d5-27ec7ff15f28"), new Guid("3578e5f8-5a0b-4c54-a63b-ab11e7d36fc8") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("143a6814-579e-4898-90dc-32459715675b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("763e24cd-311a-4da7-8b77-fca2d90ac377"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8f9dc5e1-c2c6-42e7-a2fd-2b78dcd59ce2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b72b4e86-e813-4149-ab8c-fa04a8b5c28c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ccfd8498-127a-4326-9c20-88a9624f4b41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("01078ea6-ccf2-4c9b-865b-67bb3007f120"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("17f78bb0-c2c3-4d7d-8bf9-9dc26861e122"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2a66a3ca-99ca-4333-8845-383c753edbae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2c1a522f-454b-40f5-b1d4-92a0b7f0ab5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("50bc0b7a-0876-42c8-ad30-62b99780d158"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("66ca492f-b24a-4070-9bf2-ca195de0c570"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("752bac75-d2e8-43f8-be4f-77d2d9967e9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("77e87ed2-93e2-49c7-ab2e-d6ded7c6cd24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("88ebdedc-c49c-4d84-a18d-c81c1e708e42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8de1c672-4eb6-41eb-987f-3ef13496ecee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("934b04d4-ee9d-4e3b-ac22-f109e9869581"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9b99ba87-57ec-4617-97c6-13e70e5bbdd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9d8188a5-012b-4023-b5e0-24873b1b6fc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bedcd76f-e04e-4926-ac12-a7bd0846f88e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cf07e578-f7ce-4879-b711-95939f88eac5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dca87198-285e-44e4-b2fa-0e8b461e8d37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("df263ef9-13c7-448a-8628-340a1ab0e514"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4c81bf7-89be-4508-b72b-95a695d44c20"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("052db8a0-0bfa-4f21-a9df-b2853d4b8476"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("14db4a0b-4bcc-4c78-a606-8f9231993ffe"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1c033639-aa7c-449a-a63e-3c184f1b2c57"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1e31e1fc-a8f8-42c4-ada2-e40021c9191f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("26bfe37e-2f12-4ac2-82e8-1a39a707ee2a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("39b0d991-49db-4325-8352-f7c19bb3ffb0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3ca6d2b5-cdf6-41d4-8585-cdedb65dc917"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3d1c49a8-c2e9-476b-a3b6-ff00c287a0fc"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("46ead47a-a1e1-4a51-aa77-17e1c4d931c6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("72fb70df-4782-4794-ae65-b4739d4d346d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("79cc7737-4631-4924-b429-1b87afa1bc1c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("932eca28-0cc2-40f0-aaf7-c4fb33999182"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("96b2fc81-ce29-46a6-be2b-77a8870aa3ee"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("9c780ab9-c03c-4850-8cde-7c9c965e7778"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("a180b693-213e-4938-9559-bf394c189eda"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("b2655f95-7427-437a-99ed-e3c31cb3c33c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("beafee79-a47f-432b-a338-99e0491548cf"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c496d4fa-df32-49d8-9286-3d9943307294"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("cc02ab10-9e19-4209-af19-c5613aa752a5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d0f095fa-dc68-4892-beb8-67765f880309"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("d29ac925-fe79-4143-a865-a86bce7bf3c4"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("da763356-a8ba-4cc5-8a15-638404eeb512"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("dbb817c0-dd3f-4cf9-aed9-aafb72374ce3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e10019c9-d676-4d27-a27a-f0c82d7e1a97"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e2070a5e-1d3d-4b94-8bdc-2b0b3ff7ab03"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e3515ec9-bfcb-4c4a-ae26-b61e4c7e2d52"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e9d32cbf-8f52-4f47-95ea-ac7083ee5ece"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f08fd549-6e56-470c-9325-6718d29b7698"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f965aa36-b664-4b2e-a9d1-5005a16789ba"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("fbbf48c5-f0a6-4054-80eb-5ad4d8736162"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("425d8446-78e1-4db7-9dae-e822a16e6a78"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("5d74e877-71e6-443b-953b-50ab356f147d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("728c83bf-d917-48ba-9ed9-07beb6a52a67"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("a615e8f2-b613-4d05-9ab9-93350af90cfa"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("c90d40c5-d280-4510-bebb-e924bee7bc71"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("fc8341df-7422-437f-9452-8b4671fc7878"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0cb9f7a9-b855-4ed0-9ce3-b0ab6231490b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0e63364d-0fbe-4709-9a1a-afe6ac7b7028"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1d30cc86-7af1-4c30-b5c0-2a343d725a32"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("4849cfd9-69fd-404c-91ab-bccf449730d2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5d71c306-bfbd-49f8-a771-c80f3df1abf2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("5fa32538-7d44-4f21-8068-c0464bdd2ef2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6707c0f2-2ea3-42a3-b90d-65d88e5942b4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("80c5a775-b966-4f47-a9e4-7032dea2b047"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8c2b163a-2abc-49c6-a21a-325170f54185"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8e7c619f-a31f-43fb-8d29-630a2eb3b52b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("d0589296-b3fc-487d-9a08-62134543865b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dbcdf2a8-3bf9-45df-8f4b-312236e6d0c3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("dc10c621-dd52-401d-b010-6b32572bc2ff"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("e3eae361-cab6-4747-ac79-de946cd51640"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fe4ccf93-bf41-4100-b448-97299028dd7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("03cd2876-5266-45e5-9771-6678ac7cee48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cef0c07-cd6d-4966-88bb-6b46835726a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("390161b6-8098-486c-95ae-8fb18327acef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("471d1f14-1f6e-41b9-8441-793362d4b146"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("64064e0a-9ca4-4cca-bc25-d47217d6e357"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7201abd4-8a05-428f-a18e-979acc095e61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7435d83b-bd82-4d34-a3c3-396ee701db9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7eadc9eb-93b2-4f9c-afa9-6300de89220b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("86ec2573-3aff-4602-88d5-27ec7ff15f28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8c380f67-c27b-43a2-9b1b-51eac3f1c424"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8cfb0875-4233-4dd5-911e-d6e596774447"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9df986b4-e049-4092-a6de-ced84af9b186"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a12aaaae-24ae-4695-820d-5995174630f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b225ef06-9127-4caf-83e8-0c79b6a9dd9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b5d507eb-c485-4120-90ca-3f29f3cbb419"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b727fbcf-308c-4541-9e5f-a6a99c266137"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c7f8d80e-1f17-45c2-b2bc-5119a6b008d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d8d73bdf-f421-432d-9d9f-36eddbc92bd9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd926ac5-5d14-4fc7-8903-b1a9c282f08f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ebbef47c-2372-4fa5-b188-a5a769cd9b07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f473358f-e55d-42a0-9bb4-402117c63e49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fef634b4-dd46-4c1c-b4cb-6f5e84615608"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("10391290-75b1-456d-9c80-343945d0c18d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("13349fec-40ce-4b17-a2db-ce2a5c1bc705"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("134b2603-2272-47c5-8e30-77fdd2f3f7ef"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("16553225-5a91-4eef-b6b1-2529991e9da6"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("3578e5f8-5a0b-4c54-a63b-ab11e7d36fc8"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("35fd6ab9-961d-4937-9705-09579dc8be5e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("3939e1f9-94f3-48c3-96e5-4a284211eea1"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("44239b99-dc63-4b87-b9ff-964bc43ad7f2"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("72177cb4-d961-47fa-b784-f310658f1b21"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("a4aca96b-8726-4b51-ab77-37befb65a38f"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("b4ce6892-363f-4608-93ec-87fb51d012be"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("beaac625-4e29-4163-9527-443a23bb742b"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("e0059e34-ada5-4d08-a92a-58a0297e27fe"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("fb103200-2d0d-4ba7-a95c-c0a110fa0340"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

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
        }
    }
}
