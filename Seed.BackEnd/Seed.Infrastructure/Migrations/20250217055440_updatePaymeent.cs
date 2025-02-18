using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seed.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatePaymeent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "Payment",
                newName: "TransactionDate");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Payment",
                newName: "AmountOut");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductCategoryId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "BankBrandName",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReferenceNumber",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubAccount",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TransactionContent",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9279), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9274), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9269), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9255), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9266), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9263), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9272), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9276), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9261), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9230), new DateTime(2025, 2, 17, 12, 54, 39, 166, DateTimeKind.Local).AddTicks(9251) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Payment");

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
                name: "BankBrandName",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ReferenceNumber",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "SubAccount",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "TransactionContent",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "TransactionDate",
                table: "Payment",
                newName: "PaymentDate");

            migrationBuilder.RenameColumn(
                name: "AmountOut",
                table: "Payment",
                newName: "Amount");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductCategoryId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1128), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1122), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1113), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1100), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1110), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1107), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1116), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1125), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1104), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1082), new DateTime(2025, 1, 4, 23, 5, 36, 781, DateTimeKind.Local).AddTicks(1096) });
        }
    }
}
