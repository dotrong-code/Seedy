using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Seed.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatePayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_UserID",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_OrderId",
                table: "Payment");

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
                name: "Accumulated",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "AmountIn",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "BankAccountId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Payment",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "SubAccount",
                table: "Payment",
                newName: "TransactionId");

            migrationBuilder.RenameColumn(
                name: "AmountOut",
                table: "Payment",
                newName: "Amount");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_UserID",
                table: "Payment",
                newName: "IX_Payment_UserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Payment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "OrderItem",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(865), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(859), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(855), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(843), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(852), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(849), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(857), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(863), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(846), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(821), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("3c051805-0729-4b08-a47e-0bc5eaf4eeee"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dba09-053a-4491-a770-210fb578375f"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("479dca09-053b-4491-a880-210fb578375a"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("7698f44c-4710-4e9a-98c0-8e6f80cc9d4d"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("97595211-a421-4a99-9840-5e795a2b3eef"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Occasion",
                keyColumn: "Id",
                keyValue: new Guid("a7619a43-a697-45b2-814c-fd8fbfdfea44"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("294bc753-8475-410d-a77c-4d388e8441eb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("8939d435-f544-4a28-93e4-06b2682545b9"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("930b74db-458f-4f4b-9928-c0490141cb7e"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("f38dd865-ac0b-4a04-8187-aa596e948deb"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("77be9079-5750-488b-9831-d637d2383e38"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Set",
                keyColumn: "Id",
                keyValue: new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428"),
                column: "CreatedDate",
                value: new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "IsEmailConfirmed", "IsRegister", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "Points", "ProfilePictureUrl", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("7dbc2fc5-c6a4-4561-b1c2-4f5f66e01dbf"), null, null, new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1199), null, "pqt2802@gmail.com", null, false, false, false, null, null, null, "0914725688", 0, null, 3, null },
                    { new Guid("88b0296e-4cfa-4204-a9c9-44fa90e43183"), "Userrr", null, new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1196), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(1197), "quocthangjk@gmail.com", "User_1", false, true, true, null, null, "String123!", "0914725688", 0, "Default", 3, null },
                    { new Guid("c214180d-41bc-4d8e-9ea2-56506b213a00"), "Admin", null, new DateTime(2025, 2, 25, 9, 54, 23, 741, DateTimeKind.Utc).AddTicks(1183), new DateTime(2025, 2, 25, 16, 54, 23, 741, DateTimeKind.Local).AddTicks(1189), "admin@gmail.com", "Admin", false, true, true, null, null, "String123!", "0254725644", 0, "Default", 1, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_UserId",
                table: "Payment",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_UserId",
                table: "Payment");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7dbc2fc5-c6a4-4561-b1c2-4f5f66e01dbf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("88b0296e-4cfa-4204-a9c9-44fa90e43183"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c214180d-41bc-4d8e-9ea2-56506b213a00"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Payment",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Payment",
                newName: "SubAccount");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Payment",
                newName: "AmountOut");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_UserId",
                table: "Payment",
                newName: "IX_Payment_UserID");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "Payment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<decimal>(
                name: "Accumulated",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountIn",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "BankAccountId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Payment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "OrderItem",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_UserID",
                table: "Payment",
                column: "UserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
