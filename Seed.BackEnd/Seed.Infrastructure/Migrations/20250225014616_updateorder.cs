using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Seed.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("653847bc-b76d-47a1-bb8b-a36d272b7a20"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("815f92b9-d0b3-4c1c-a7e3-4702d9ecaa31"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("851d2d27-da7b-4801-8f0a-4b5f24db9106"));

            migrationBuilder.RenameColumn(
                name: "ShippingStatus",
                table: "Order",
                newName: "ReceiverPhone");

            migrationBuilder.RenameColumn(
                name: "RefundStatus",
                table: "Order",
                newName: "ReceiverFullName");

            migrationBuilder.RenameColumn(
                name: "PaymentStatus",
                table: "Order",
                newName: "ReceiverEmail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Order",
                newName: "ReceiverAddress");

            migrationBuilder.AddColumn<decimal>(
                name: "MoneyCollection",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "OrderNote",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrderService",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverDistrict",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverProvince",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverWard",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8576), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8566), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8556), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8531), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8550), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8543), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8561), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8571), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8537), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8499), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("3c051805-0729-4b08-a47e-0bc5eaf4eeee"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dba09-053a-4491-a770-210fb578375f"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dca09-053b-4491-a880-210fb578375a"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("7698f44c-4710-4e9a-98c0-8e6f80cc9d4d"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("97595211-a421-4a99-9840-5e795a2b3eef"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("a7619a43-a697-45b2-814c-fd8fbfdfea44"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("294bc753-8475-410d-a77c-4d388e8441eb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("930b74db-458f-4f4b-9928-c0490141cb7e"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("f38dd865-ac0b-4a04-8187-aa596e948deb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("77be9079-5750-488b-9831-d637d2383e38"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "IsEmailConfirmed", "IsRegister", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "Points", "ProfilePictureUrl", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("33153182-2880-4034-b109-fb872fe2ada5"), "Userrr", null, new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(8846), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8848), "quocthangjk@gmail.com", "User_1", false, true, true, null, null, "String123!", "0914725688", 0, "Default", 3, null },
                    { new Guid("9022dade-2452-4e35-9f54-b2c39103c3e0"), "Admin", null, new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(8829), new DateTime(2025, 2, 25, 8, 46, 15, 664, DateTimeKind.Local).AddTicks(8836), "admin@gmail.com", "Admin", false, true, true, null, null, "String123!", "0254725644", 0, "Default", 1, null },
                    { new Guid("c4ec1525-efcf-43de-80c3-a147c2e5cb2d"), null, null, new DateTime(2025, 2, 25, 1, 46, 15, 664, DateTimeKind.Utc).AddTicks(8852), null, "pqt2802@gmail.com", null, false, false, false, null, null, null, "0914725688", 0, null, 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("33153182-2880-4034-b109-fb872fe2ada5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9022dade-2452-4e35-9f54-b2c39103c3e0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4ec1525-efcf-43de-80c3-a147c2e5cb2d"));

            migrationBuilder.DropColumn(
                name: "MoneyCollection",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderNote",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderService",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ReceiverDistrict",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ReceiverProvince",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ReceiverWard",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "ReceiverPhone",
                table: "Order",
                newName: "ShippingStatus");

            migrationBuilder.RenameColumn(
                name: "ReceiverFullName",
                table: "Order",
                newName: "RefundStatus");

            migrationBuilder.RenameColumn(
                name: "ReceiverEmail",
                table: "Order",
                newName: "PaymentStatus");

            migrationBuilder.RenameColumn(
                name: "ReceiverAddress",
                table: "Order",
                newName: "Email");

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7395), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7391), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7372), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7383), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7380), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7388), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7393), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7377), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7354), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("3c051805-0729-4b08-a47e-0bc5eaf4eeee"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dba09-053a-4491-a770-210fb578375f"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dca09-053b-4491-a880-210fb578375a"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("7698f44c-4710-4e9a-98c0-8e6f80cc9d4d"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("97595211-a421-4a99-9840-5e795a2b3eef"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("a7619a43-a697-45b2-814c-fd8fbfdfea44"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("294bc753-8475-410d-a77c-4d388e8441eb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("930b74db-458f-4f4b-9928-c0490141cb7e"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("f38dd865-ac0b-4a04-8187-aa596e948deb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("77be9079-5750-488b-9831-d637d2383e38"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "IsEmailConfirmed", "IsRegister", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "Points", "ProfilePictureUrl", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("653847bc-b76d-47a1-bb8b-a36d272b7a20"), "Userrr", null, new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7565), "quocthangjk@gmail.com", "User_1", false, true, true, null, null, "String123!", "0914725688", 0, "Default", 3, null },
                    { new Guid("815f92b9-d0b3-4c1c-a7e3-4702d9ecaa31"), null, null, new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7567), null, "pqt2802@gmail.com", null, false, false, false, null, null, null, "0914725688", 0, null, 3, null },
                    { new Guid("851d2d27-da7b-4801-8f0a-4b5f24db9106"), "Admin", null, new DateTime(2025, 2, 23, 8, 12, 2, 509, DateTimeKind.Utc).AddTicks(7552), new DateTime(2025, 2, 23, 15, 12, 2, 509, DateTimeKind.Local).AddTicks(7557), "admin@gmail.com", "Admin", false, true, true, null, null, "String123!", "0254725644", 0, "Default", 1, null }
                });
        }
    }
}
