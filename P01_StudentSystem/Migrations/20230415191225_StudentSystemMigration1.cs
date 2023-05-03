using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P01_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class StudentSystemMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    RegisteredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    ResourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Url = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.ResourceId);
                    table.ForeignKey(
                        name: "FK_Resources_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeworkSubmissions",
                columns: table => new
                {
                    HomeworkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeworkSubmissions", x => x.HomeworkId);
                    table.ForeignKey(
                        name: "FK_HomeworkSubmissions_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeworkSubmissions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { new Guid("2118b5e5-367a-4fcb-95f3-d07bd6971691"), "Maxime dolorum aut qui quas quia similique. Dolor dolorem deserunt qui perferendis sint quo. In et et reiciendis sit qui. Voluptatibus rerum inventore odit ex assumenda aut et quaerat blanditiis. Quidem molestiae sint qui aliquid eum quia omnis voluptatum. Sint necessitatibus velit sunt placeat error suscipit et vel.", new DateTime(2023, 4, 22, 6, 18, 32, 696, DateTimeKind.Local).AddTicks(4167), "Cloned fault-tolerant emulation", 304.990742307768350m, new DateTime(2023, 4, 16, 4, 50, 35, 334, DateTimeKind.Local).AddTicks(5556) },
                    { new Guid("31495db1-4432-4cd8-ba69-8035ad6b51a7"), "Aspernatur quis aut culpa accusantium molestiae debitis quam et. Consectetur eum qui quia amet tempora amet. A at qui voluptas. Id qui officia esse et sunt ut error.", new DateTime(2023, 4, 29, 9, 59, 31, 13, DateTimeKind.Local).AddTicks(6003), "Stand-alone directional definition", 433.525480105108100m, new DateTime(2023, 4, 16, 8, 33, 18, 131, DateTimeKind.Local).AddTicks(4216) },
                    { new Guid("3e7becd1-76cb-43dd-a6fc-f1f17a7a37b1"), "Suscipit quis rerum et voluptates porro officia laboriosam eveniet. Natus qui facilis excepturi in impedit earum. Sed ut quia est ducimus totam sit autem et.", new DateTime(2023, 5, 4, 13, 28, 13, 576, DateTimeKind.Local).AddTicks(1069), "Object-based optimizing secured line", 332.616267308561900m, new DateTime(2023, 4, 16, 14, 43, 54, 944, DateTimeKind.Local).AddTicks(1998) },
                    { new Guid("579a1893-1669-4790-8d32-d432f436b440"), "Ipsum officiis voluptatibus distinctio nobis rerum beatae consectetur. Voluptas dolorum optio praesentium autem aliquam ut impedit sequi nesciunt. Fuga ut quo quo blanditiis est numquam eos beatae.", new DateTime(2023, 5, 5, 6, 54, 33, 977, DateTimeKind.Local).AddTicks(9350), "Reverse-engineered zero tolerance task-force", 262.905500625527300m, new DateTime(2023, 4, 16, 11, 37, 37, 785, DateTimeKind.Local).AddTicks(5084) },
                    { new Guid("93784236-c722-4add-9e12-a7361fdb3bd7"), "Modi incidunt beatae. Repellendus eos animi quia dolores ut eligendi. Nulla ad dignissimos. Quia ducimus illo. Excepturi aliquid ducimus ut ad voluptatem in et. Inventore et omnis voluptas vitae magnam nobis.", new DateTime(2023, 5, 11, 15, 6, 53, 687, DateTimeKind.Local).AddTicks(4749), "Persistent human-resource website", 412.567680735690800m, new DateTime(2023, 4, 15, 23, 19, 31, 474, DateTimeKind.Local).AddTicks(6880) },
                    { new Guid("a55bfc43-e263-4ca1-8a07-95809004a7f5"), "Beatae aliquam placeat qui a perferendis et quibusdam assumenda. Ut quaerat adipisci aut perspiciatis quod sint iure. Similique autem et autem. Assumenda rem rem voluptatem.", new DateTime(2023, 4, 28, 4, 32, 56, 611, DateTimeKind.Local).AddTicks(8092), "Triple-buffered high-level implementation", 223.448267701755950m, new DateTime(2023, 4, 16, 2, 38, 22, 336, DateTimeKind.Local).AddTicks(5448) },
                    { new Guid("af28b460-cc1b-402a-b2eb-29ccca14d1dc"), "Eum officiis voluptatem qui qui quibusdam at ab. Inventore in veniam velit delectus eos. Non ea eos fugiat. Quos dicta id repellat est atque quia quia. Provident ullam aut.", new DateTime(2023, 5, 11, 19, 14, 38, 98, DateTimeKind.Local).AddTicks(7127), "Fundamental heuristic infrastructure", 482.849793148092800m, new DateTime(2023, 4, 16, 3, 31, 13, 372, DateTimeKind.Local).AddTicks(6343) },
                    { new Guid("bbc08b02-6dc7-4539-a67b-f50568eb9b76"), "Porro distinctio aut atque nam aut ab ipsa. Explicabo pariatur aut rem in unde nulla. Hic voluptas ut architecto ut accusantium iure qui.", new DateTime(2023, 4, 23, 0, 44, 51, 413, DateTimeKind.Local).AddTicks(3279), "Realigned executive instruction set", 176.560580817551750m, new DateTime(2023, 4, 16, 6, 1, 44, 476, DateTimeKind.Local).AddTicks(6484) },
                    { new Guid("dbea9829-1c17-4c23-a7a7-981a43d2e59e"), "Quas aperiam asperiores. Vero ut libero corrupti quia. Et molestiae dolorem nobis facere quae debitis sint culpa.", new DateTime(2023, 4, 23, 8, 37, 22, 717, DateTimeKind.Local).AddTicks(1462), "Advanced asymmetric functionalities", 375.941239560830750m, new DateTime(2023, 4, 16, 10, 55, 33, 602, DateTimeKind.Local).AddTicks(2408) },
                    { new Guid("ef21e5c4-9251-441d-8b33-6c1302a9b8c5"), "Ut tenetur optio minima voluptatem omnis vero possimus. Autem laboriosam quo molestiae eligendi saepe quis non. Provident incidunt totam laboriosam recusandae facilis. Nemo qui aperiam. Odio nisi quis unde autem quisquam hic.", new DateTime(2023, 5, 8, 3, 36, 10, 278, DateTimeKind.Local).AddTicks(4346), "Total motivating concept", 105.823319808689600m, new DateTime(2023, 4, 16, 16, 23, 3, 856, DateTimeKind.Local).AddTicks(6241) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Birthday", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[,]
                {
                    { new Guid("199f9874-80f9-4002-a392-69f55655acbc"), new DateTime(2000, 8, 10, 1, 13, 37, 43, DateTimeKind.Local).AddTicks(2310), "Mattie Lynch", "914.808.73", new DateTime(2023, 4, 14, 1, 47, 7, 222, DateTimeKind.Local).AddTicks(6067) },
                    { new Guid("46c1edcf-a2ff-4058-99ed-f7a73eed038f"), new DateTime(1999, 4, 11, 0, 44, 25, 482, DateTimeKind.Local).AddTicks(40), "Jannie Schulist", "1-885", new DateTime(2022, 10, 18, 5, 40, 2, 778, DateTimeKind.Local).AddTicks(7739) },
                    { new Guid("5922cebd-7e75-40f2-8cbb-8db57b2a67e1"), new DateTime(1995, 1, 20, 8, 38, 24, 25, DateTimeKind.Local).AddTicks(5857), "Alford Willms", "603-714", new DateTime(2022, 12, 10, 6, 59, 50, 829, DateTimeKind.Local).AddTicks(1009) },
                    { new Guid("5df343f1-769a-4f05-9a66-df6d8cdac4da"), new DateTime(1995, 8, 18, 5, 49, 50, 912, DateTimeKind.Local).AddTicks(8454), "Kory Quitzon", "1-349", new DateTime(2022, 12, 12, 19, 36, 32, 390, DateTimeKind.Local).AddTicks(1692) },
                    { new Guid("79c8d31b-b182-452f-9b0a-c3532cc1df01"), new DateTime(1999, 9, 2, 22, 43, 54, 39, DateTimeKind.Local).AddTicks(691), "Whitney Reinger", "348-439", new DateTime(2023, 3, 3, 1, 34, 28, 373, DateTimeKind.Local).AddTicks(8965) },
                    { new Guid("93230d81-d958-460e-bf3b-01072d29194c"), new DateTime(2003, 12, 6, 1, 7, 28, 762, DateTimeKind.Local).AddTicks(7333), "Cleta Satterfield", "1-825", new DateTime(2023, 1, 28, 0, 1, 8, 593, DateTimeKind.Local).AddTicks(7818) },
                    { new Guid("9829a10e-9afd-4787-a7e3-849e7974570e"), new DateTime(2001, 2, 2, 8, 25, 12, 648, DateTimeKind.Local).AddTicks(5765), "Jasen Kling", "1-470", new DateTime(2022, 11, 22, 12, 22, 12, 315, DateTimeKind.Local).AddTicks(9294) },
                    { new Guid("9d2d0672-292f-43d3-b24c-368a1eb46957"), new DateTime(2000, 11, 7, 10, 7, 58, 261, DateTimeKind.Local).AddTicks(4287), "Marilyne Hickle", "895-271", new DateTime(2022, 5, 14, 12, 18, 43, 479, DateTimeKind.Local).AddTicks(6481) },
                    { new Guid("a3417ce7-1b6e-4d4e-9bd0-e4b6c7fcb277"), new DateTime(1993, 9, 11, 16, 48, 14, 524, DateTimeKind.Local).AddTicks(3921), "Deangelo Romaguera", "619-1456", new DateTime(2023, 1, 3, 20, 28, 59, 472, DateTimeKind.Local).AddTicks(4968) },
                    { new Guid("cca72391-aaec-47ba-90c8-5d4935441652"), new DateTime(2004, 2, 24, 0, 23, 26, 897, DateTimeKind.Local).AddTicks(6649), "Nathaniel Rohan", "329-865", new DateTime(2022, 9, 1, 0, 11, 17, 236, DateTimeKind.Local).AddTicks(1675) }
                });

            migrationBuilder.InsertData(
                table: "HomeworkSubmissions",
                columns: new[] { "HomeworkId", "Content", "ContentType", "CourseId", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { new Guid("05bcad89-8828-4e21-98cc-7887eae61248"), "Et eum officia laborum aut aliquid et. Et praesentium optio dolor. Eum eveniet quia voluptas dolor eveniet exercitationem corrupti. Architecto perferendis voluptatibus laborum. Quaerat nam aut pariatur eligendi eum molestias quae.", "Pdf", new Guid("93784236-c722-4add-9e12-a7361fdb3bd7"), new Guid("cca72391-aaec-47ba-90c8-5d4935441652"), new DateTime(2023, 4, 15, 15, 1, 26, 248, DateTimeKind.Utc).AddTicks(5424) },
                    { new Guid("42b47a9f-4ccb-4852-87cd-68cd3fec78bf"), "Dicta sed fugiat maiores delectus. Consequuntur accusamus ipsa quis odio cumque a quas. Et ut eaque minima minima nulla repudiandae cupiditate delectus.", "Zip", new Guid("31495db1-4432-4cd8-ba69-8035ad6b51a7"), new Guid("46c1edcf-a2ff-4058-99ed-f7a73eed038f"), new DateTime(2023, 4, 10, 16, 47, 17, 101, DateTimeKind.Utc).AddTicks(8255) },
                    { new Guid("4653d498-0740-476f-b3dc-7cfe6b8aaf5f"), "Et et commodi rerum et et porro. Totam et quibusdam ipsam nobis quis rerum. Sed tenetur est quae ullam ut neque tempora fuga. Est est amet sit laudantium quo ad eligendi quibusdam dolores. Et voluptatum id quam quaerat pariatur est.", "Application", new Guid("a55bfc43-e263-4ca1-8a07-95809004a7f5"), new Guid("cca72391-aaec-47ba-90c8-5d4935441652"), new DateTime(2023, 4, 9, 11, 8, 12, 832, DateTimeKind.Utc).AddTicks(3444) },
                    { new Guid("5a558009-6075-4ca2-b5de-96ef97120fe4"), "Eum ea dolorum. Quia explicabo et non. Ut corporis magnam et sit quibusdam veniam. Laudantium illum aut et omnis vel rerum hic nemo. Ipsa laudantium nostrum at cum id. Sit voluptates et.", "Pdf", new Guid("579a1893-1669-4790-8d32-d432f436b440"), new Guid("5df343f1-769a-4f05-9a66-df6d8cdac4da"), new DateTime(2023, 4, 15, 15, 14, 28, 779, DateTimeKind.Utc).AddTicks(9903) },
                    { new Guid("80f1388f-1341-46e0-af4b-0cafc3a12827"), "Ducimus sed ratione eum dolores iure eos modi aliquid corrupti. Sint nesciunt et architecto eveniet nisi quod iste molestiae. Similique laboriosam vitae quisquam. Provident aspernatur et qui optio doloribus repudiandae.", "Zip", new Guid("a55bfc43-e263-4ca1-8a07-95809004a7f5"), new Guid("9829a10e-9afd-4787-a7e3-849e7974570e"), new DateTime(2023, 4, 13, 6, 26, 19, 328, DateTimeKind.Utc).AddTicks(426) },
                    { new Guid("8434acb3-01e6-489d-b93e-1b1ef4691188"), "Quasi occaecati id commodi ea quos quam atque aperiam. Sit qui aut fuga repellendus nam id. Quidem tempora deleniti et enim quae quam. Aut ullam modi corporis vitae velit ipsam quo voluptas.", "Application", new Guid("579a1893-1669-4790-8d32-d432f436b440"), new Guid("9829a10e-9afd-4787-a7e3-849e7974570e"), new DateTime(2023, 4, 9, 21, 46, 47, 942, DateTimeKind.Utc).AddTicks(1447) },
                    { new Guid("86173897-c3f5-4a3c-8cb1-127e57415dc4"), "Esse ut veniam consequatur eius quibusdam aliquam doloribus eligendi rerum. Praesentium et eaque aut qui delectus animi nam. Quam enim minima. Fuga sequi voluptatem deleniti id sed et qui perferendis quidem. Commodi sed optio deserunt aut quas quae amet repudiandae.", "Zip", new Guid("a55bfc43-e263-4ca1-8a07-95809004a7f5"), new Guid("9829a10e-9afd-4787-a7e3-849e7974570e"), new DateTime(2023, 4, 13, 21, 12, 7, 607, DateTimeKind.Utc).AddTicks(6350) },
                    { new Guid("895f88e4-a4c1-42d1-ac2c-36e3a980b19e"), "Non aut et quia sint incidunt necessitatibus quo quis quia. Voluptas suscipit ad deserunt possimus sint. Sed vero ex reprehenderit eos.", "Application", new Guid("93784236-c722-4add-9e12-a7361fdb3bd7"), new Guid("5df343f1-769a-4f05-9a66-df6d8cdac4da"), new DateTime(2023, 4, 9, 16, 41, 46, 18, DateTimeKind.Utc).AddTicks(7479) },
                    { new Guid("8e0bc162-384c-428b-bff4-75bb687ee3ea"), "Officiis qui temporibus. Ad laboriosam quasi et ab distinctio non at. Sint saepe quibusdam facilis sequi.", "Application", new Guid("dbea9829-1c17-4c23-a7a7-981a43d2e59e"), new Guid("46c1edcf-a2ff-4058-99ed-f7a73eed038f"), new DateTime(2023, 4, 9, 8, 50, 33, 902, DateTimeKind.Utc).AddTicks(7766) },
                    { new Guid("96b156c3-7105-420f-8cf7-2871b8b24e89"), "Voluptate repudiandae error rerum eligendi magnam. Pariatur quasi quis reiciendis. Vitae sint quia sed delectus rerum autem ab error temporibus. Qui non et. Est quae recusandae ipsam sunt eum nesciunt est est. Quia possimus vel odit.", "Pdf", new Guid("93784236-c722-4add-9e12-a7361fdb3bd7"), new Guid("199f9874-80f9-4002-a392-69f55655acbc"), new DateTime(2023, 4, 11, 1, 46, 4, 697, DateTimeKind.Utc).AddTicks(5976) },
                    { new Guid("9dad962d-01cb-49be-9ae1-d08796c09f69"), "Aliquam omnis quia rerum doloremque aspernatur et autem. Voluptas vero nemo quis praesentium aut repudiandae. Est autem doloribus itaque voluptatem qui atque enim nostrum recusandae. Eum sint harum sint aut consequatur eum. Assumenda dignissimos adipisci doloremque rerum et facilis quisquam. Vel quia laudantium laboriosam est maxime debitis eveniet id.", "Application", new Guid("ef21e5c4-9251-441d-8b33-6c1302a9b8c5"), new Guid("9829a10e-9afd-4787-a7e3-849e7974570e"), new DateTime(2023, 4, 15, 8, 38, 6, 591, DateTimeKind.Utc).AddTicks(5073) },
                    { new Guid("be2e00dc-5491-4e3a-af0f-6adf9fd40c7b"), "Pariatur nostrum excepturi. Eos non vitae sed aliquam. Sunt eos et quis.", "Pdf", new Guid("a55bfc43-e263-4ca1-8a07-95809004a7f5"), new Guid("9829a10e-9afd-4787-a7e3-849e7974570e"), new DateTime(2023, 4, 12, 4, 24, 3, 37, DateTimeKind.Utc).AddTicks(7320) },
                    { new Guid("f4bdf4a1-c181-47f8-852d-c104347580fc"), "Nisi et cumque. Soluta ut et accusamus eum dolorem. Architecto expedita soluta et possimus ad harum. Adipisci odio voluptatem officiis delectus non quidem.", "Zip", new Guid("93784236-c722-4add-9e12-a7361fdb3bd7"), new Guid("9d2d0672-292f-43d3-b24c-368a1eb46957"), new DateTime(2023, 4, 10, 23, 30, 17, 625, DateTimeKind.Utc).AddTicks(1757) },
                    { new Guid("f7374033-f9ae-43af-8380-37784a435e32"), "Dolorum facilis facere mollitia. Sint est et quas. Et dolorem maxime.", "Zip", new Guid("93784236-c722-4add-9e12-a7361fdb3bd7"), new Guid("93230d81-d958-460e-bf3b-01072d29194c"), new DateTime(2023, 4, 14, 15, 12, 47, 153, DateTimeKind.Utc).AddTicks(6228) },
                    { new Guid("faa97b68-faa9-48e0-8221-b6125f6000dd"), "Ut similique deleniti omnis esse ullam eos quas ipsum. Aliquam maiores minima est et dolorum iure non. Sunt doloremque at soluta consectetur animi molestias vero ratione amet.", "Application", new Guid("93784236-c722-4add-9e12-a7361fdb3bd7"), new Guid("5df343f1-769a-4f05-9a66-df6d8cdac4da"), new DateTime(2023, 4, 14, 2, 46, 42, 7, DateTimeKind.Utc).AddTicks(8619) }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { new Guid("27d40853-64ca-4232-b230-eab5e763ef05"), new Guid("31495db1-4432-4cd8-ba69-8035ad6b51a7"), "suscipit", "Document", "http://flossie.org" },
                    { new Guid("45fe0cba-3ac3-4df3-a093-74f1b73a1e7c"), new Guid("2118b5e5-367a-4fcb-95f3-d07bd6971691"), "repudiandae", "Document", "https://jewel.info" },
                    { new Guid("50709aba-30c4-4e82-8374-931ece2bedad"), new Guid("31495db1-4432-4cd8-ba69-8035ad6b51a7"), "eos", "Presentation", "https://rita.biz" },
                    { new Guid("5891fd27-10f4-4d25-af39-e1e04a1ae7bb"), new Guid("579a1893-1669-4790-8d32-d432f436b440"), "fugit", "Video", "https://jaquelin.org" },
                    { new Guid("66b5d7b7-ca64-4b53-bf01-8350347b15b1"), new Guid("31495db1-4432-4cd8-ba69-8035ad6b51a7"), "cupiditate", "Document", "http://georgette.com" },
                    { new Guid("849aeb08-2225-4068-a907-9af1cb2a6e2c"), new Guid("dbea9829-1c17-4c23-a7a7-981a43d2e59e"), "adipisci", "Presentation", "https://floy.name" },
                    { new Guid("99e60778-a445-45ef-bf09-28fed1a045c4"), new Guid("dbea9829-1c17-4c23-a7a7-981a43d2e59e"), "aliquid", "Video", "http://tanya.com" },
                    { new Guid("9cc5043e-21ec-4bc8-bbd2-44d2f5651c92"), new Guid("2118b5e5-367a-4fcb-95f3-d07bd6971691"), "ipsum", "Video", "https://elwin.org" },
                    { new Guid("a011565e-46ae-4360-a832-5d881d33f84c"), new Guid("2118b5e5-367a-4fcb-95f3-d07bd6971691"), "delectus", "Document", "https://skylar.com" },
                    { new Guid("d5d09cde-1173-4dd1-b44e-8a196734720e"), new Guid("579a1893-1669-4790-8d32-d432f436b440"), "odio", "Document", "https://margot.biz" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("579a1893-1669-4790-8d32-d432f436b440"), new Guid("46c1edcf-a2ff-4058-99ed-f7a73eed038f") },
                    { new Guid("bbc08b02-6dc7-4539-a67b-f50568eb9b76"), new Guid("5922cebd-7e75-40f2-8cbb-8db57b2a67e1") },
                    { new Guid("2118b5e5-367a-4fcb-95f3-d07bd6971691"), new Guid("9829a10e-9afd-4787-a7e3-849e7974570e") },
                    { new Guid("2118b5e5-367a-4fcb-95f3-d07bd6971691"), new Guid("9d2d0672-292f-43d3-b24c-368a1eb46957") },
                    { new Guid("bbc08b02-6dc7-4539-a67b-f50568eb9b76"), new Guid("a3417ce7-1b6e-4d4e-9bd0-e4b6c7fcb277") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkSubmissions_CourseId",
                table: "HomeworkSubmissions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkSubmissions_StudentId",
                table: "HomeworkSubmissions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CourseId",
                table: "Resources",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeworkSubmissions");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
