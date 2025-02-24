using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Seed.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5a9ec5a9-f537-46c2-855b-3a5e2097734a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9e8d353c-e071-4de2-ad28-9cd70c043cd8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f7bdd3c5-d1d7-418b-9929-2d1878d6cbeb"));

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(681), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(675), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(669), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(654), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(666), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(661), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(672), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(678), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(658), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(636), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("3c051805-0729-4b08-a47e-0bc5eaf4eeee"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dba09-053a-4491-a770-210fb578375f"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dca09-053b-4491-a880-210fb578375a"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("7698f44c-4710-4e9a-98c0-8e6f80cc9d4d"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("97595211-a421-4a99-9840-5e795a2b3eef"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("a7619a43-a697-45b2-814c-fd8fbfdfea44"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("294bc753-8475-410d-a77c-4d388e8441eb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Note", "OccasionId", "Price", "ProductCategoryId", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("2b029c62-3cc7-443e-99e3-fd122eab348e"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1244), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Ftham-lang_postcard.png?alt=media&token=a0cb58c2-119c-4e76-bdda-0a64b76ee0cc", false, null, null, "THIỆP'THẦM LẶNG'", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 29000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("2ee59d22-7217-4b6e-b7b3-1768b97f6532"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1231), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fchu-bai-hong_postcard.png?alt=media&token=8ce9d527-fbbd-4df4-ae16-50d6a1f8d16d", false, null, null, "THIỆP'CHỦ BÀI'(HỒNG)", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 25000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("53f4a339-bcaf-4578-917b-658843b48e61"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1227), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fcho-che_postcard.png?alt=media&token=3e9dd1df-207d-4886-8265-7cf9e2e952df", false, null, null, "THIỆP'CHỞ CHE'", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 29000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("8503354b-fa6a-4f94-9515-c86220f7bed1"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1239), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fdon-nha_postcard.png?alt=media&token=b60c80f4-3a58-4d63-9202-5c9670086ab8", false, null, null, "THIỆP'DỌN NHÀ'", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 29000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("898c3659-b119-4df7-aecc-015693184abd"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1242), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Ftan-tao_postcard.png?alt=media&token=42f3a0df-a25e-4284-ab9e-481964d9073e", false, null, null, "THIỆP'TẦN TẢO'", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 29000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("a38d5f4f-1764-4bc0-95b4-979ebd8d7f12"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1235), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fchu-bai-nau_postcard.png?alt=media&token=be6779b4-8170-4fab-8ff1-b5ec57223bcb", false, null, null, "THIỆP'CHỦ BÀI'(NÂU)", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 25000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("f2f6e7e2-c46e-4218-958e-c56c780f22cb"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1248), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fuong-tra_postcard.png?alt=media&token=9127f6dd-5170-47ab-bf35-63b96d7c8ffa", false, null, null, "THIỆP'UỐNG TRÀ'", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 29000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("fdd02b3f-7e01-4213-ad1c-8c485ccd904f"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1251), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fyeu-thuong_postcard.png?alt=media&token=fec3f6b2-af5b-4149-b6b4-9f37a04efc5b", false, null, null, "THIỆP'YÊU THƯƠNG'", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 29000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("fe1430bd-1b1b-496a-8be5-0c995ff42133"), null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1223), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fban-an_postcard_%202.png?alt=media&token=0b27e5c9-01d6-46f4-bef1-26eb9a3d4cb9", false, null, null, "THIỆP'BÀN ĂN'", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 29000m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("930b74db-458f-4f4b-9928-c0490141cb7e"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("f38dd865-ac0b-4a04-8187-aa596e948deb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("77be9079-5750-488b-9831-d637d2383e38"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "IsEmailConfirmed", "IsRegister", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "Points", "ProfilePictureUrl", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("1b6e5a20-f412-41a3-a576-7cc19c4191c0"), "Userrr", null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(884), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(885), "quocthangjk@gmail.com", "User_1", false, true, true, null, null, "String123!", "0914725688", 0, "Default", 3, null },
                    { new Guid("5423ceca-0c1e-4898-9811-f6ade1f50f1c"), "Admin", null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(874), new DateTime(2025, 2, 24, 14, 7, 49, 814, DateTimeKind.Local).AddTicks(879), "admin@gmail.com", "Admin", false, true, true, null, null, "String123!", "0254725644", 0, "Default", 1, null },
                    { new Guid("a706aa75-f227-4152-920d-af09647f9e7c"), null, null, new DateTime(2025, 2, 24, 7, 7, 49, 814, DateTimeKind.Utc).AddTicks(926), null, "pqt2802@gmail.com", null, false, false, false, null, null, null, "0914725688", 0, null, 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2b029c62-3cc7-443e-99e3-fd122eab348e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2ee59d22-7217-4b6e-b7b3-1768b97f6532"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("53f4a339-bcaf-4578-917b-658843b48e61"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8503354b-fa6a-4f94-9515-c86220f7bed1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("898c3659-b119-4df7-aecc-015693184abd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a38d5f4f-1764-4bc0-95b4-979ebd8d7f12"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f2f6e7e2-c46e-4218-958e-c56c780f22cb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fdd02b3f-7e01-4213-ad1c-8c485ccd904f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fe1430bd-1b1b-496a-8be5-0c995ff42133"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1b6e5a20-f412-41a3-a576-7cc19c4191c0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5423ceca-0c1e-4898-9811-f6ade1f50f1c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a706aa75-f227-4152-920d-af09647f9e7c"));

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4877), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4868), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4859), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4840), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4855), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4850), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4864), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4873), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4846), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4822), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("3c051805-0729-4b08-a47e-0bc5eaf4eeee"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dba09-053a-4491-a770-210fb578375f"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dca09-053b-4491-a880-210fb578375a"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("7698f44c-4710-4e9a-98c0-8e6f80cc9d4d"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("97595211-a421-4a99-9840-5e795a2b3eef"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("a7619a43-a697-45b2-814c-fd8fbfdfea44"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("294bc753-8475-410d-a77c-4d388e8441eb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("930b74db-458f-4f4b-9928-c0490141cb7e"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("f38dd865-ac0b-4a04-8187-aa596e948deb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("77be9079-5750-488b-9831-d637d2383e38"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "IsEmailConfirmed", "IsRegister", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "Points", "ProfilePictureUrl", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("5a9ec5a9-f537-46c2-855b-3a5e2097734a"), null, null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5200), null, "pqt2802@gmail.com", null, false, false, false, null, null, null, "0914725688", 0, null, 3, null },
                    { new Guid("9e8d353c-e071-4de2-ad28-9cd70c043cd8"), "Admin", null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5182), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(5186), "admin@gmail.com", "Admin", false, true, true, null, null, "String123!", "0254725644", 0, "Default", 1, null },
                    { new Guid("f7bdd3c5-d1d7-418b-9929-2d1878d6cbeb"), "Userrr", null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5194), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(5196), "quocthangjk@gmail.com", "User_1", false, true, true, null, null, "String123!", "0914725688", 0, "Default", 3, null }
                });
        }
    }
}
