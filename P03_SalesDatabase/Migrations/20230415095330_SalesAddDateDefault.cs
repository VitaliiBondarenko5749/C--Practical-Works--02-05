using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("009762af-d785-452f-b238-5b19054b80bc"), "6759556054981411", "Kristine61@hotmail.com", "Kristine Schuster" },
                    { new Guid("16aeae9f-824e-470b-ab86-109913afa19f"), "67599561053505431438", "Rebecca27@gmail.com", "Rebecca Schumm" },
                    { new Guid("17833e28-fa62-44e9-af89-02115ce53ed6"), "3528-7940-1903-2684", "Paul_Keebler5@yahoo.com", "Paul Keebler" },
                    { new Guid("1877b944-abc2-4520-b8f3-2e7882abb42f"), "6761-2574-9607-4040", "Erik64@gmail.com", "Erik Ondricka" },
                    { new Guid("221fde44-da7e-40a4-a8b6-b4453d968064"), "5020-4765-0771-5297", "Jan_Monahan@hotmail.com", "Jan Monahan" },
                    { new Guid("2585d500-f84c-42ad-91f5-aabc7a001160"), "6759-3486-5625-9317", "Tamara13@gmail.com", "Tamara Will" },
                    { new Guid("2f350e0f-1e05-489e-a534-d3dbccb4a549"), "3539-0096-4434-5170", "Douglas29@yahoo.com", "Douglas Watsica" },
                    { new Guid("696c34e8-9b3d-4d9e-b060-44f6f0869acf"), "6393-7970-6668-4344", "Blanche.Mertz@hotmail.com", "Blanche Mertz" },
                    { new Guid("7100f416-ad96-4f5e-a025-5bac30ba364b"), "6771-8913-8894-0195", "Nathaniel_Wiza@hotmail.com", "Nathaniel Wiza" },
                    { new Guid("76357a45-a4c8-44ad-8cf2-3b4aae0a7fa5"), "6380-9531-4560-0372", "Adrienne_Cronin78@hotmail.com", "Adrienne Cronin" },
                    { new Guid("787d76ed-e829-44c2-a588-7380d05cdfa8"), "6485-6228-1450-0257-6871", "Ella.Wilkinson@yahoo.com", "Ella Wilkinson" },
                    { new Guid("8d8bdf71-2da2-4ad1-a834-301a32bfa72f"), "3051-911727-4376", "Horace85@gmail.com", "Horace Stamm" },
                    { new Guid("95faa7e8-4fac-46f2-9642-2809bb52fbf3"), "6011-7444-0625-1139", "Nicole_Rohan@hotmail.com", "Nicole Rohan" },
                    { new Guid("ab938cad-6465-4026-9ef3-3d9b30e20af9"), "6304604817785479", "Chester_Swaniawski62@yahoo.com", "Chester Swaniawski" },
                    { new Guid("ad95c910-fa23-488a-92c2-9049cdbe2fcc"), "6393-3091-0837-7232", "Alton_Mueller66@yahoo.com", "Alton Mueller" },
                    { new Guid("b545fcbc-0c85-4f2e-a702-4ba5089f702a"), "6767-2263-8324-0297-982", "Enrique.Fay@hotmail.com", "Enrique Fay" },
                    { new Guid("bdc0d062-d405-4b30-8a88-982c8cd810b0"), "3528-2555-5302-3083", "Dianne_Kiehn@yahoo.com", "Dianne Kiehn" },
                    { new Guid("cb583612-f843-4997-8f4f-1ea30345a571"), "3559-8327-1322-0676", "Ramona69@yahoo.com", "Ramona Hackett" },
                    { new Guid("da6ea412-8e15-4056-9920-c9c278f7592d"), "3015-062940-5199", "Kayla.Jaskolski@gmail.com", "Kayla Jaskolski" },
                    { new Guid("f5b83448-c1f4-4522-8066-5c1e040bf353"), "6767-9596-8116-1142-28", "Gretchen94@yahoo.com", "Gretchen Gleichner" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("018f9b79-e0e7-4164-9131-1a33106c141e"), "Handmade Granite Salad", 2810.82446499710000m, 368.97278f },
                    { new Guid("0a6907a4-f344-4e10-82a7-024a0700a2f2"), "Practical Metal Cheese", 9766.40921464080000m, 813.8265f },
                    { new Guid("0ca5a339-85b0-4426-9324-0210c34b9975"), "Generic Concrete Pizza", 9152.833210086270000m, 303.43155f },
                    { new Guid("0d6c1b39-abff-49f5-8231-09132aeddea2"), "Unbranded Fresh Shoes", 8013.503452152360000m, 181.00146f },
                    { new Guid("11328793-cf9b-471f-8240-e44e3e6a7ace"), "Refined Metal Towels", 7829.531180199570000m, 100.7725f },
                    { new Guid("14a122d8-ce72-4dde-95e1-f4ab9273cdaf"), "Handcrafted Granite Chips", 4611.0240829110000m, 69.25823f },
                    { new Guid("1e80c00d-d050-4299-9a34-3d123585f196"), "Practical Plastic Bike", 990.9037429835660000m, 983.72894f },
                    { new Guid("20c793c5-89bf-40e4-9d9a-221f4d46a8de"), "Ergonomic Cotton Car", 3331.214647642560000m, 694.36005f },
                    { new Guid("25dd6fc6-6c36-4078-80c9-da2cec40d009"), "Handcrafted Cotton Pants", 4899.4249745070000m, 31.891691f },
                    { new Guid("27f79389-dc63-4fd4-9124-015814765975"), "Licensed Soft Pizza", 6533.47001020790000m, 688.5904f },
                    { new Guid("33c6d0e7-0fb9-4145-8da4-1546d0b20483"), "Licensed Granite Bike", 1035.383969859620000m, 885.1648f },
                    { new Guid("33e34ac5-9222-461c-a728-ba22b3121c5d"), "Gorgeous Frozen Sausages", 1165.658533016490000m, 327.988f },
                    { new Guid("377322eb-f59e-479e-b4f2-69e115b0a2e7"), "Ergonomic Metal Chicken", 491.8371831744820000m, 402.1906f },
                    { new Guid("4ec94b80-27f1-467c-a80b-dabd27018548"), "Ergonomic Concrete Salad", 941.126082857790000m, 251.35135f },
                    { new Guid("5cdfa3ed-2eef-4d77-923a-208c0d43bce5"), "Practical Granite Tuna", 1741.132555024610000m, 26.41305f },
                    { new Guid("714dcc9b-e1c8-4bb4-9ad9-7e6fa466a8ba"), "Practical Cotton Sausages", 5797.135690116220000m, 874.4079f },
                    { new Guid("78f3d96e-9e40-4772-bef7-eb50713792ab"), "Tasty Frozen Mouse", 5739.746762074960000m, 221.89673f },
                    { new Guid("79b8e14d-7d45-424a-8d18-16684a24f583"), "Practical Metal Pants", 4051.064780816790000m, 587.2252f },
                    { new Guid("7c569d4a-ff6a-4ac9-9316-966b78a3f360"), "Generic Fresh Shirt", 1654.177301270350000m, 439.84396f },
                    { new Guid("80ae9339-65fe-479c-8b75-01bfcd33b8d5"), "Rustic Rubber Mouse", 3252.732414327270000m, 74.4556f },
                    { new Guid("839bff32-6709-4337-a655-1321663944c8"), "Handmade Plastic Hat", 6784.921879834640000m, 736.949f },
                    { new Guid("8825853c-37d0-4de5-bcae-94cfd5a57f2f"), "Unbranded Granite Chair", 6014.941641055650000m, 822.5766f },
                    { new Guid("88c73c61-3fc6-4c7d-8ca5-24ebe4c2998a"), "Ergonomic Concrete Cheese", 6644.505851616420000m, 368.99594f },
                    { new Guid("8c20c01e-e876-4acc-ad11-625a758262b5"), "Fantastic Rubber Salad", 2445.560236133620000m, 408.36218f },
                    { new Guid("979db3b5-aebd-43d0-87b4-97d507d4165d"), "Generic Fresh Bacon", 5454.421495650580000m, 294.69992f },
                    { new Guid("9c7f1eb4-626f-4667-a299-b9e954e7ee78"), "Gorgeous Wooden Shirt", 949.591153792370000m, 222.10248f },
                    { new Guid("9f22a7d4-b06b-4349-83be-7a42df5ef1bc"), "Awesome Cotton Bacon", 7588.453467624570000m, 106.783485f },
                    { new Guid("a2624c2d-aac1-4fb5-8bd0-8af55f21b6d6"), "Handcrafted Frozen Bike", 432.4530486614280000m, 333.32977f },
                    { new Guid("a62463f8-4a7d-4250-9301-4052a25b589c"), "Intelligent Cotton Fish", 44.9955901075050000m, 897.97906f },
                    { new Guid("a66bd49e-3c44-4629-82b7-a0218f947499"), "Awesome Plastic Ball", 1228.473554442930000m, 903.44025f },
                    { new Guid("a8b249b0-f986-42b7-b1c6-4eade2c64385"), "Fantastic Granite Towels", 1098.789701811910000m, 882.8381f },
                    { new Guid("ad39edb2-66a8-4001-8f1c-14b28f6b0384"), "Refined Plastic Pizza", 2577.843891795450000m, 978.5447f },
                    { new Guid("b3db3909-be26-4e50-a4a6-b552d26f8c47"), "Gorgeous Soft Tuna", 403.1992855746490000m, 263.8643f },
                    { new Guid("c6c5d479-cbc8-4e8a-859e-6c69990b9684"), "Handcrafted Metal Ball", 3170.525092092880000m, 727.4399f },
                    { new Guid("c9c0e111-dc00-4a2b-b611-bae73bc5e378"), "Practical Metal Ball", 3440.621281804730000m, 751.7017f },
                    { new Guid("cd4b5b9f-057d-4264-9948-7a477443b491"), "Awesome Rubber Salad", 5149.778677312840000m, 184.50395f },
                    { new Guid("ea23931a-36cc-4a9c-b042-bf99bf8eb924"), "Intelligent Wooden Table", 7532.940074563820000m, 756.53613f },
                    { new Guid("f922cb95-c4c2-4331-b564-3423c5006aea"), "Sleek Steel Shoes", 7825.485935272210000m, 855.5681f },
                    { new Guid("fdef68c1-5208-4c0c-ab44-9dc1564628b4"), "Rustic Granite Ball", 4646.882831872480000m, 936.08136f },
                    { new Guid("fe787156-2714-4291-bc66-e5391e8e428e"), "Incredible Granite Towels", 1032.622287708980000m, 624.5028f }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { new Guid("0b9241d4-edc0-4687-9af4-96460b5ff0c2"), "Gerlach, Von and Dare" },
                    { new Guid("106ba425-7a45-44c7-9cf1-3e1d2ca3bebf"), "Jaskolski - Hudson" },
                    { new Guid("1ad0e913-ecbb-43ea-a48f-eea323e62109"), "Maggio, Oberbrunner and Pouros" },
                    { new Guid("273eed76-7715-47bc-bec7-983a25949339"), "Lang and Sons" },
                    { new Guid("27823491-d439-4763-b74d-cb43902defc2"), "Corwin and Sons" },
                    { new Guid("323b5fe8-df4d-424f-8d8a-48d8cea91fbe"), "O'Connell LLC" },
                    { new Guid("65497ebb-6dc1-4bee-83de-9f9a3cb89330"), "Douglas - Turner" },
                    { new Guid("70c83c1c-9842-4636-aa34-d61d610add23"), "Farrell, Ankunding and Berge" },
                    { new Guid("7e2567da-01bb-4a31-854f-ebda149a6bf4"), "Gorczany Group" },
                    { new Guid("88b105c4-712f-4df4-8a2e-6aec53182f7a"), "Torp LLC" },
                    { new Guid("97d1c0da-e91e-4327-9721-5e0082424785"), "Bogisich, Labadie and Lebsack" },
                    { new Guid("988de305-599c-4aa5-9bc1-cc570c436d72"), "Swaniawski, Christiansen and Zboncak" },
                    { new Guid("9d46c85e-4ce2-4468-bdb1-eaba744849fa"), "Wunsch, Kassulke and Sauer" },
                    { new Guid("b21e3b26-0f8a-4365-aaad-74fecbd6f76c"), "Lindgren and Sons" },
                    { new Guid("c79fbd79-d309-4285-81ee-b7659740e4ab"), "Satterfield, Paucek and Reichel" },
                    { new Guid("cc9b7034-4c22-4053-ba0c-2241c0b4e8ec"), "Kirlin - Emmerich" },
                    { new Guid("d630fbee-387f-481c-b089-fc7f83635171"), "Bernier - Lindgren" },
                    { new Guid("e339c877-67d7-4048-b6ef-341b3becc31c"), "Schroeder and Sons" },
                    { new Guid("f541d2e4-9bda-49b3-8947-f3bf74101013"), "Hintz - Bradtke" },
                    { new Guid("f9467a16-fdb3-4c10-9334-b6318d1dce3a"), "Ondricka - Homenick" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "Customer", "Product", "Store" },
                values: new object[,]
                {
                    { new Guid("139e2ddf-a445-458e-80a3-ecca0f1cd4f6"), new Guid("76357a45-a4c8-44ad-8cf2-3b4aae0a7fa5"), new Guid("11328793-cf9b-471f-8240-e44e3e6a7ace"), new Guid("c79fbd79-d309-4285-81ee-b7659740e4ab") },
                    { new Guid("1a32eb2b-e3d6-41d2-81da-585b79c74cfd"), new Guid("f5b83448-c1f4-4522-8066-5c1e040bf353"), new Guid("4ec94b80-27f1-467c-a80b-dabd27018548"), new Guid("70c83c1c-9842-4636-aa34-d61d610add23") },
                    { new Guid("1f29d50b-de0c-4b9a-ae16-48d24b5b0c22"), new Guid("b545fcbc-0c85-4f2e-a702-4ba5089f702a"), new Guid("c9c0e111-dc00-4a2b-b611-bae73bc5e378"), new Guid("988de305-599c-4aa5-9bc1-cc570c436d72") },
                    { new Guid("2a6724fe-401a-4032-9db4-04dfe468bc88"), new Guid("8d8bdf71-2da2-4ad1-a834-301a32bfa72f"), new Guid("11328793-cf9b-471f-8240-e44e3e6a7ace"), new Guid("b21e3b26-0f8a-4365-aaad-74fecbd6f76c") },
                    { new Guid("32a0f88b-1c98-4ed7-a31c-6c3c368a2477"), new Guid("2585d500-f84c-42ad-91f5-aabc7a001160"), new Guid("c6c5d479-cbc8-4e8a-859e-6c69990b9684"), new Guid("f541d2e4-9bda-49b3-8947-f3bf74101013") },
                    { new Guid("3380601f-ca54-4c8b-84cf-7342aaa773b9"), new Guid("009762af-d785-452f-b238-5b19054b80bc"), new Guid("714dcc9b-e1c8-4bb4-9ad9-7e6fa466a8ba"), new Guid("c79fbd79-d309-4285-81ee-b7659740e4ab") },
                    { new Guid("379d6754-2385-47bf-9893-a07e2013f680"), new Guid("221fde44-da7e-40a4-a8b6-b4453d968064"), new Guid("b3db3909-be26-4e50-a4a6-b552d26f8c47"), new Guid("f541d2e4-9bda-49b3-8947-f3bf74101013") },
                    { new Guid("3a27fc7e-197f-42f4-bc39-afbead3aa28d"), new Guid("16aeae9f-824e-470b-ab86-109913afa19f"), new Guid("11328793-cf9b-471f-8240-e44e3e6a7ace"), new Guid("d630fbee-387f-481c-b089-fc7f83635171") },
                    { new Guid("3ab1bf02-9018-4721-9a28-b197caac8ca3"), new Guid("ab938cad-6465-4026-9ef3-3d9b30e20af9"), new Guid("11328793-cf9b-471f-8240-e44e3e6a7ace"), new Guid("7e2567da-01bb-4a31-854f-ebda149a6bf4") },
                    { new Guid("3e2df30e-7862-4b31-8f58-e1a386eada77"), new Guid("76357a45-a4c8-44ad-8cf2-3b4aae0a7fa5"), new Guid("33e34ac5-9222-461c-a728-ba22b3121c5d"), new Guid("0b9241d4-edc0-4687-9af4-96460b5ff0c2") },
                    { new Guid("49d0f78c-f189-4413-a10f-bc96d9c59300"), new Guid("cb583612-f843-4997-8f4f-1ea30345a571"), new Guid("a62463f8-4a7d-4250-9301-4052a25b589c"), new Guid("988de305-599c-4aa5-9bc1-cc570c436d72") },
                    { new Guid("4da9558f-a3eb-4fa8-866e-0d296b45d81f"), new Guid("221fde44-da7e-40a4-a8b6-b4453d968064"), new Guid("33e34ac5-9222-461c-a728-ba22b3121c5d"), new Guid("f541d2e4-9bda-49b3-8947-f3bf74101013") },
                    { new Guid("53b9269e-d268-47b4-8e39-92a3338094e3"), new Guid("da6ea412-8e15-4056-9920-c9c278f7592d"), new Guid("1e80c00d-d050-4299-9a34-3d123585f196"), new Guid("d630fbee-387f-481c-b089-fc7f83635171") },
                    { new Guid("5f3b54db-c342-4c41-acfd-17d01a06544c"), new Guid("7100f416-ad96-4f5e-a025-5bac30ba364b"), new Guid("78f3d96e-9e40-4772-bef7-eb50713792ab"), new Guid("323b5fe8-df4d-424f-8d8a-48d8cea91fbe") },
                    { new Guid("6dac4c1b-e58e-4c38-b280-e0f4a504795d"), new Guid("17833e28-fa62-44e9-af89-02115ce53ed6"), new Guid("c9c0e111-dc00-4a2b-b611-bae73bc5e378"), new Guid("7e2567da-01bb-4a31-854f-ebda149a6bf4") },
                    { new Guid("72a76576-f3b3-40a3-9537-3bb52ceec94c"), new Guid("76357a45-a4c8-44ad-8cf2-3b4aae0a7fa5"), new Guid("b3db3909-be26-4e50-a4a6-b552d26f8c47"), new Guid("27823491-d439-4763-b74d-cb43902defc2") },
                    { new Guid("73ff1e42-f98f-41ce-81cb-0ff31ab93ac2"), new Guid("7100f416-ad96-4f5e-a025-5bac30ba364b"), new Guid("839bff32-6709-4337-a655-1321663944c8"), new Guid("b21e3b26-0f8a-4365-aaad-74fecbd6f76c") },
                    { new Guid("751a9d10-8122-4265-baa0-c0c4c82cf0c9"), new Guid("cb583612-f843-4997-8f4f-1ea30345a571"), new Guid("fe787156-2714-4291-bc66-e5391e8e428e"), new Guid("cc9b7034-4c22-4053-ba0c-2241c0b4e8ec") },
                    { new Guid("765be0be-6f72-4e7b-b038-1f1d774b3322"), new Guid("cb583612-f843-4997-8f4f-1ea30345a571"), new Guid("27f79389-dc63-4fd4-9124-015814765975"), new Guid("106ba425-7a45-44c7-9cf1-3e1d2ca3bebf") },
                    { new Guid("7a61fc4c-0d57-4bf9-b190-94fd761f58e2"), new Guid("2f350e0f-1e05-489e-a534-d3dbccb4a549"), new Guid("979db3b5-aebd-43d0-87b4-97d507d4165d"), new Guid("c79fbd79-d309-4285-81ee-b7659740e4ab") },
                    { new Guid("7f6a3d7f-2cfa-4d93-9b2a-523793fa05ec"), new Guid("221fde44-da7e-40a4-a8b6-b4453d968064"), new Guid("377322eb-f59e-479e-b4f2-69e115b0a2e7"), new Guid("97d1c0da-e91e-4327-9721-5e0082424785") },
                    { new Guid("8f6a2206-4bd2-4d41-b02c-ed25ca4f5047"), new Guid("696c34e8-9b3d-4d9e-b060-44f6f0869acf"), new Guid("714dcc9b-e1c8-4bb4-9ad9-7e6fa466a8ba"), new Guid("7e2567da-01bb-4a31-854f-ebda149a6bf4") },
                    { new Guid("bf7ae89b-2bb5-4316-be9f-3f860ff33ebf"), new Guid("95faa7e8-4fac-46f2-9642-2809bb52fbf3"), new Guid("9c7f1eb4-626f-4667-a299-b9e954e7ee78"), new Guid("b21e3b26-0f8a-4365-aaad-74fecbd6f76c") },
                    { new Guid("c2c7dbcf-6e7d-46db-ac6b-ddeff9cc8c10"), new Guid("f5b83448-c1f4-4522-8066-5c1e040bf353"), new Guid("5cdfa3ed-2eef-4d77-923a-208c0d43bce5"), new Guid("f541d2e4-9bda-49b3-8947-f3bf74101013") },
                    { new Guid("c2f250f8-32fa-4bd1-98a4-1a58273b71be"), new Guid("8d8bdf71-2da2-4ad1-a834-301a32bfa72f"), new Guid("27f79389-dc63-4fd4-9124-015814765975"), new Guid("27823491-d439-4763-b74d-cb43902defc2") },
                    { new Guid("cd8e99b5-7c87-4e3d-b982-51ca2d45d090"), new Guid("221fde44-da7e-40a4-a8b6-b4453d968064"), new Guid("c6c5d479-cbc8-4e8a-859e-6c69990b9684"), new Guid("f541d2e4-9bda-49b3-8947-f3bf74101013") },
                    { new Guid("e2e4f978-ceb0-477f-9713-ad47260aa108"), new Guid("cb583612-f843-4997-8f4f-1ea30345a571"), new Guid("377322eb-f59e-479e-b4f2-69e115b0a2e7"), new Guid("c79fbd79-d309-4285-81ee-b7659740e4ab") },
                    { new Guid("f13e3a39-7a2b-4c52-9c61-964d1dc82c7a"), new Guid("221fde44-da7e-40a4-a8b6-b4453d968064"), new Guid("b3db3909-be26-4e50-a4a6-b552d26f8c47"), new Guid("f9467a16-fdb3-4c10-9334-b6318d1dce3a") },
                    { new Guid("f834fa31-e0aa-431c-aefa-0a96854cc014"), new Guid("221fde44-da7e-40a4-a8b6-b4453d968064"), new Guid("0ca5a339-85b0-4426-9324-0210c34b9975"), new Guid("f9467a16-fdb3-4c10-9334-b6318d1dce3a") },
                    { new Guid("f9007a73-bbf5-4b0a-81ed-d564deab4926"), new Guid("cb583612-f843-4997-8f4f-1ea30345a571"), new Guid("11328793-cf9b-471f-8240-e44e3e6a7ace"), new Guid("27823491-d439-4763-b74d-cb43902defc2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("1877b944-abc2-4520-b8f3-2e7882abb42f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("787d76ed-e829-44c2-a588-7380d05cdfa8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ad95c910-fa23-488a-92c2-9049cdbe2fcc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("bdc0d062-d405-4b30-8a88-982c8cd810b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("018f9b79-e0e7-4164-9131-1a33106c141e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a6907a4-f344-4e10-82a7-024a0700a2f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0d6c1b39-abff-49f5-8231-09132aeddea2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("14a122d8-ce72-4dde-95e1-f4ab9273cdaf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("20c793c5-89bf-40e4-9d9a-221f4d46a8de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25dd6fc6-6c36-4078-80c9-da2cec40d009"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("33c6d0e7-0fb9-4145-8da4-1546d0b20483"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("79b8e14d-7d45-424a-8d18-16684a24f583"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7c569d4a-ff6a-4ac9-9316-966b78a3f360"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("80ae9339-65fe-479c-8b75-01bfcd33b8d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8825853c-37d0-4de5-bcae-94cfd5a57f2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("88c73c61-3fc6-4c7d-8ca5-24ebe4c2998a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8c20c01e-e876-4acc-ad11-625a758262b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f22a7d4-b06b-4349-83be-7a42df5ef1bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a2624c2d-aac1-4fb5-8bd0-8af55f21b6d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a66bd49e-3c44-4629-82b7-a0218f947499"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a8b249b0-f986-42b7-b1c6-4eade2c64385"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ad39edb2-66a8-4001-8f1c-14b28f6b0384"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cd4b5b9f-057d-4264-9948-7a477443b491"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ea23931a-36cc-4a9c-b042-bf99bf8eb924"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f922cb95-c4c2-4331-b564-3423c5006aea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fdef68c1-5208-4c0c-ab44-9dc1564628b4"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("139e2ddf-a445-458e-80a3-ecca0f1cd4f6"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1a32eb2b-e3d6-41d2-81da-585b79c74cfd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("1f29d50b-de0c-4b9a-ae16-48d24b5b0c22"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("2a6724fe-401a-4032-9db4-04dfe468bc88"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("32a0f88b-1c98-4ed7-a31c-6c3c368a2477"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3380601f-ca54-4c8b-84cf-7342aaa773b9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("379d6754-2385-47bf-9893-a07e2013f680"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3a27fc7e-197f-42f4-bc39-afbead3aa28d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3ab1bf02-9018-4721-9a28-b197caac8ca3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("3e2df30e-7862-4b31-8f58-e1a386eada77"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("49d0f78c-f189-4413-a10f-bc96d9c59300"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("4da9558f-a3eb-4fa8-866e-0d296b45d81f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("53b9269e-d268-47b4-8e39-92a3338094e3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("5f3b54db-c342-4c41-acfd-17d01a06544c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("6dac4c1b-e58e-4c38-b280-e0f4a504795d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("72a76576-f3b3-40a3-9537-3bb52ceec94c"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("73ff1e42-f98f-41ce-81cb-0ff31ab93ac2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("751a9d10-8122-4265-baa0-c0c4c82cf0c9"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("765be0be-6f72-4e7b-b038-1f1d774b3322"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7a61fc4c-0d57-4bf9-b190-94fd761f58e2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("7f6a3d7f-2cfa-4d93-9b2a-523793fa05ec"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("8f6a2206-4bd2-4d41-b02c-ed25ca4f5047"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("bf7ae89b-2bb5-4316-be9f-3f860ff33ebf"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c2c7dbcf-6e7d-46db-ac6b-ddeff9cc8c10"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("c2f250f8-32fa-4bd1-98a4-1a58273b71be"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("cd8e99b5-7c87-4e3d-b982-51ca2d45d090"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("e2e4f978-ceb0-477f-9713-ad47260aa108"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f13e3a39-7a2b-4c52-9c61-964d1dc82c7a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f834fa31-e0aa-431c-aefa-0a96854cc014"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: new Guid("f9007a73-bbf5-4b0a-81ed-d564deab4926"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("1ad0e913-ecbb-43ea-a48f-eea323e62109"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("273eed76-7715-47bc-bec7-983a25949339"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("65497ebb-6dc1-4bee-83de-9f9a3cb89330"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("88b105c4-712f-4df4-8a2e-6aec53182f7a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("9d46c85e-4ce2-4468-bdb1-eaba744849fa"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("e339c877-67d7-4048-b6ef-341b3becc31c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("009762af-d785-452f-b238-5b19054b80bc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("16aeae9f-824e-470b-ab86-109913afa19f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("17833e28-fa62-44e9-af89-02115ce53ed6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("221fde44-da7e-40a4-a8b6-b4453d968064"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2585d500-f84c-42ad-91f5-aabc7a001160"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2f350e0f-1e05-489e-a534-d3dbccb4a549"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("696c34e8-9b3d-4d9e-b060-44f6f0869acf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7100f416-ad96-4f5e-a025-5bac30ba364b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("76357a45-a4c8-44ad-8cf2-3b4aae0a7fa5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("8d8bdf71-2da2-4ad1-a834-301a32bfa72f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("95faa7e8-4fac-46f2-9642-2809bb52fbf3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ab938cad-6465-4026-9ef3-3d9b30e20af9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b545fcbc-0c85-4f2e-a702-4ba5089f702a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("cb583612-f843-4997-8f4f-1ea30345a571"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("da6ea412-8e15-4056-9920-c9c278f7592d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("f5b83448-c1f4-4522-8066-5c1e040bf353"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0ca5a339-85b0-4426-9324-0210c34b9975"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("11328793-cf9b-471f-8240-e44e3e6a7ace"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1e80c00d-d050-4299-9a34-3d123585f196"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27f79389-dc63-4fd4-9124-015814765975"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("33e34ac5-9222-461c-a728-ba22b3121c5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("377322eb-f59e-479e-b4f2-69e115b0a2e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4ec94b80-27f1-467c-a80b-dabd27018548"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5cdfa3ed-2eef-4d77-923a-208c0d43bce5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("714dcc9b-e1c8-4bb4-9ad9-7e6fa466a8ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("78f3d96e-9e40-4772-bef7-eb50713792ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("839bff32-6709-4337-a655-1321663944c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("979db3b5-aebd-43d0-87b4-97d507d4165d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9c7f1eb4-626f-4667-a299-b9e954e7ee78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a62463f8-4a7d-4250-9301-4052a25b589c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b3db3909-be26-4e50-a4a6-b552d26f8c47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c6c5d479-cbc8-4e8a-859e-6c69990b9684"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9c0e111-dc00-4a2b-b611-bae73bc5e378"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fe787156-2714-4291-bc66-e5391e8e428e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("0b9241d4-edc0-4687-9af4-96460b5ff0c2"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("106ba425-7a45-44c7-9cf1-3e1d2ca3bebf"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("27823491-d439-4763-b74d-cb43902defc2"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("323b5fe8-df4d-424f-8d8a-48d8cea91fbe"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("70c83c1c-9842-4636-aa34-d61d610add23"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("7e2567da-01bb-4a31-854f-ebda149a6bf4"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("97d1c0da-e91e-4327-9721-5e0082424785"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("988de305-599c-4aa5-9bc1-cc570c436d72"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("b21e3b26-0f8a-4365-aaad-74fecbd6f76c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("c79fbd79-d309-4285-81ee-b7659740e4ab"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("cc9b7034-4c22-4053-ba0c-2241c0b4e8ec"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("d630fbee-387f-481c-b089-fc7f83635171"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("f541d2e4-9bda-49b3-8947-f3bf74101013"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: new Guid("f9467a16-fdb3-4c10-9334-b6318d1dce3a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

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
    }
}
