using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Seed.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    EmailTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageMappingsJson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.EmailTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "Occasion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OccasionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occasion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: true),
                    IsRegister = table.Column<bool>(type: "bit", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    OccasionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Set_Occasion_OccasionId",
                        column: x => x.OccasionId,
                        principalTable: "Occasion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OccasionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Occasion_OccasionId",
                        column: x => x.OccasionId,
                        principalTable: "Occasion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefundStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "PointsHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PointsChanged = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointsHistory_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "UserEmail",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmail", x => new { x.UserID, x.EmailTemplateId });
                    table.ForeignKey(
                        name: "FK_UserEmail_EmailTemplate_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplate",
                        principalColumn: "EmailTemplateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEmail_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SetProduct",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetProduct", x => new { x.SetId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_SetProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetProduct_Set_SetId",
                        column: x => x.SetId,
                        principalTable: "Set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "OrderTracking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TravelCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTracking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderTracking_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountOut = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Accumulated = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankBrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "EmailTemplate",
                columns: new[] { "EmailTemplateId", "Body", "CreateBy", "CreateDate", "ImageMappingsJson", "IsDelete", "Subject", "Type", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your service titled '{{ServiceTitle}}' has been deactivated for the following reason:</p>\r\n                    <p>{{DeactivationReason}}</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4877), "{}", false, "Service Deactivation Notification", "DeactivateService", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4878) },
                    { new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your account has been deactivated. If you think this is a mistake, please contact our support team.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4868), "{}", false, "Account Deactivation", "DeactivateUser", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4869) },
                    { new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>We are pleased to inform you that your appointment for koi fish care has been approved.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4859), "{}", false, "Appointment Approval Notification", "ApproveAppointment", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4860) },
                    { new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"), "\r\n                <!DOCTYPE html>\r\n\r\n<html lang=\"en\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:v=\"urn:schemas-microsoft-com:vml\">\r\n<head>\r\n<title></title>\r\n<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\"/>\r\n<meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\"/><!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]--><!--[if !mso]><!-->\r\n<link href=\"https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900\" rel=\"stylesheet\" type=\"text/css\"/><!--<![endif]-->\r\n<style>\r\n		* {\r\n			box-sizing: border-box;\r\n		}\r\n\r\n		body {\r\n			margin: 0;\r\n			padding: 0;\r\n		}\r\n\r\n		a[x-apple-data-detectors] {\r\n			color: inherit !important;\r\n			text-decoration: inherit !important;\r\n		}\r\n\r\n		#MessageViewBody a {\r\n			color: inherit;\r\n			text-decoration: none;\r\n		}\r\n\r\n		p {\r\n			line-height: inherit\r\n		}\r\n\r\n		.desktop_hide,\r\n		.desktop_hide table {\r\n			mso-hide: all;\r\n			display: none;\r\n			max-height: 0px;\r\n			overflow: hidden;\r\n		}\r\n\r\n		.image_block img+div {\r\n			display: none;\r\n		}\r\n\r\n		sup,\r\n		sub {\r\n			font-size: 75%;\r\n			line-height: 0;\r\n		}\r\n\r\n		@media (max-width:660px) {\r\n\r\n			.desktop_hide table.icons-inner,\r\n			.social_block.desktop_hide .social-table {\r\n				display: inline-block !important;\r\n			}\r\n\r\n			.icons-inner {\r\n				text-align: center;\r\n			}\r\n\r\n			.icons-inner td {\r\n				margin: 0 auto;\r\n			}\r\n\r\n			.image_block div.fullWidth {\r\n				max-width: 100% !important;\r\n			}\r\n\r\n			.mobile_hide {\r\n				display: none;\r\n			}\r\n\r\n			.row-content {\r\n				width: 100% !important;\r\n			}\r\n\r\n			.stack .column {\r\n				width: 100%;\r\n				display: block;\r\n			}\r\n\r\n			.mobile_hide {\r\n				min-height: 0;\r\n				max-height: 0;\r\n				max-width: 0;\r\n				overflow: hidden;\r\n				font-size: 0px;\r\n			}\r\n\r\n			.desktop_hide,\r\n			.desktop_hide table {\r\n				display: table !important;\r\n				max-height: none !important;\r\n			}\r\n		}\r\n	</style><!--[if mso ]><style>sup, sub { font-size: 100% !important; } sup { mso-text-raise:10% } sub { mso-text-raise:-10% }</style> <![endif]-->\r\n</head>\r\n<body class=\"body\" style=\"background-color: #f8f8f9; margin: 0; padding: 0; -webkit-text-size-adjust: none; text-size-adjust: none;\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"nl-container\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n	<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n							<tr>\r\n								<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n							</tr>\r\n						</table>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-left:40px;padding-right:40px;width:100%;\">\r\n					<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n						<div class=\"fullWidth\" style=\"max-width: 352px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{Img1_2x}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"352\" /></div>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-top:50px;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n							<tr>\r\n								<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n							</tr>\r\n						</table>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n					<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:30px;line-height:120%;text-align:center;mso-line-height-alt:36px;\">\r\n						<p style=\"margin: 0; word-break: break-word;\"><span style=\"word-break: break-word; color: #2b303a;\"><strong>Appointment Confirmation</strong></span></p>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n					<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:center;mso-line-height-alt:22.5px;\">\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\">\r\n								Hello {Name},\r\n							</span>\r\n						</p>\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\">\r\n								We’re confirming your appointment with us for our Koi care service. Please review the details below and click the button to view the appointment information.\r\n							</span>\r\n						</p>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n					<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:left;mso-line-height-alt:22.5px;\">\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\"><strong>Appointment Date:</strong> {AppointmentDate}</span>\r\n						</p>\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\"><strong>Time:</strong> {AppointmentTime}</span>\r\n						</p>\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\"><strong>Service:</strong> {ServiceName}</span>\r\n						</p>\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\"><strong>Pet:</strong> {PetName}</span>\r\n						</p>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"button_block block-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-left:10px;padding-right:10px;padding-top:15px;text-align:center;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<!--[if mso]>\r\n					<v:roundrect xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:w=\"urn:schemas-microsoft-com:office:word\" style=\"height:62px;width:222px;v-text-anchor:middle;\" arcsize=\"97%\" stroke=\"false\" fillcolor=\"#1aa19c\">\r\n					<w:anchorlock/>\r\n					<v:textbox inset=\"0px,0px,0px,0px\">\r\n					<center dir=\"false\" style=\"color:#ffffff;font-family:Tahoma, sans-serif;font-size:16px\">\r\n					<![endif]-->\r\n						<div style=\"background-color:#1aa19c;border-radius:60px;color:#ffffff;display:inline-block;font-family:Montserrat, sans-serif;font-size:16px;padding:15px 30px;text-align:center;text-decoration:none;\">\r\n							<a href=\"{AppointmentDetailURL}\" style=\"color: #ffffff; text-decoration: none; display: inline-block; line-height: 32px;\">\r\n								<strong>View Appointment Details</strong>\r\n							</a>\r\n						</div>\r\n						<!--[if mso]></center></v:textbox></v:roundrect><![endif]-->\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-8\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n							<tr>\r\n								<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n							</tr>\r\n						</table>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n							<tr>\r\n								<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n							</tr>\r\n						</table>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n	</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #2b303a; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"width:100%;\">\r\n<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n<div style=\"max-width: 640px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{footer}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"640\"/></div>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:10px;padding-right:10px;padding-top:28px;text-align:center;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social-table\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; display: inline-block;\" width=\"208px\">\r\n<tr>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.facebook.com\" target=\"_blank\"><img alt=\"Facebook\" height=\"auto\" src=\"{facebook2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Facebook\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.twitter.com\" target=\"_blank\"><img alt=\"Twitter\" height=\"auto\" src=\"{twitter2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Twitter\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.instagram.com\" target=\"_blank\"><img alt=\"Instagram\" height=\"auto\" src=\"{instagram2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Instagram\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.linkedin.com\" target=\"_blank\"><img alt=\"LinkedIn\" height=\"auto\" src=\"{linkedin2x}\" style=\"display: block; height: auto; border: 0;\" title=\"LinkedIn\" width=\"32\"/></a></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:25px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 1px solid #555961;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"icons_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; text-align: center; line-height: 0;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"vertical-align: middle; color: #1e0e4b; font-family: 'Inter', sans-serif; font-size: 15px; padding-bottom: 5px; padding-top: 5px; text-align: center;\"><!--[if vml]><table align=\"center\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"display:inline-block;padding-left:0px;padding-right:0px;mso-table-lspace: 0pt;mso-table-rspace: 0pt;\"><![endif]-->\r\n<!--[if !vml]><!-->\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table><!-- End -->\r\n</body>\r\n</html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4840), "{\"facebook2x\":\"EmailTemplate/c387781f-57b2-4daa-8dbb-74ae478b3527_facebook2x.png\",\"footer\":\"EmailTemplate/8d6faaac-8b6f-4ec9-a169-af2c3fdf0a1f_footer.png\",\"Img1_2x\":\"EmailTemplate/63acd16b-f91d-4158-957d-a0f873fd9bd0_Img1_2x.png\",\"instagram2x\":\"EmailTemplate/b0c0fa7e-ee9b-45d7-a804-07f37d96008b_instagram2x.png\",\"linkedin2x\":\"EmailTemplate/202c8e61-533b-4ffb-9639-a038de869c0c_linkedin2x.png\",\"twitter2x\":\"EmailTemplate/e576f46a-a7de-4ad3-81dd-7297fbde391d_twitter2x.png\"}", false, "Appointment Booking Notification", "MakeAppointment", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4841) },
                    { new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>We regret to inform you that your appointment for koi services has been rejected for the following reason:</p>\r\n                    <p>{{RejectionReason}}</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4855), "{}", false, "Appointment Rejection Notification", "RejectAppointment", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4856) },
                    { new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Thank you for registering with the Koi Veterinary Service Center. Please confirm your account by clicking the link below:</p>\r\n                    <p><a href='{{ConfirmationLink}}'>Confirm Account</a></p>\r\n                    <p>If you did not register, please ignore this email.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4850), "{}", false, "Account Confirmation", "ConfirmationAccount", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4851) },
                    { new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your account has been successfully activated. You can now log in and start using our koi veterinary services.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4864), "{}", false, "Ac", "ActivateUser", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4865) },
                    { new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"), "\r\n                <html>\r\n                <body>\r\n                    <p>Dear {{UserName}},</p>\r\n                    <p>Your requested koi service titled '{{ServiceTitle}}' has been successfully updated.</p>\r\n                    <p>If you have any questions or need further assistance, please feel free to reach out to us.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4873), "{}", false, "Service Update Notification", "UpdateService", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4873) },
                    { new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your password has been successfully reset. You can now log in with your new password.</p>\r\n                    <p>If you did not request this change, please contact our support team immediately.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4846), "{}", false, "Your Password Has Been Reset", "ResetPassword", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4847) },
                    { new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), "\r\n                <!DOCTYPE html>\r\n\r\n<html lang=\"en\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:v=\"urn:schemas-microsoft-com:vml\">\r\n<head>\r\n<title></title>\r\n<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\"/>\r\n<meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\"/><!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]--><!--[if !mso]><!-->\r\n<link href=\"https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900\" rel=\"stylesheet\" type=\"text/css\"/><!--<![endif]-->\r\n<style>\r\n		* {\r\n			box-sizing: border-box;\r\n		}\r\n\r\n		body {\r\n			margin: 0;\r\n			padding: 0;\r\n		}\r\n\r\n		a[x-apple-data-detectors] {\r\n			color: inherit !important;\r\n			text-decoration: inherit !important;\r\n		}\r\n\r\n		#MessageViewBody a {\r\n			color: inherit;\r\n			text-decoration: none;\r\n		}\r\n\r\n		p {\r\n			line-height: inherit\r\n		}\r\n\r\n		.desktop_hide,\r\n		.desktop_hide table {\r\n			mso-hide: all;\r\n			display: none;\r\n			max-height: 0px;\r\n			overflow: hidden;\r\n		}\r\n\r\n		.image_block img+div {\r\n			display: none;\r\n		}\r\n\r\n		sup,\r\n		sub {\r\n			font-size: 75%;\r\n			line-height: 0;\r\n		}\r\n\r\n		@media (max-width:660px) {\r\n\r\n			.desktop_hide table.icons-inner,\r\n			.social_block.desktop_hide .social-table {\r\n				display: inline-block !important;\r\n			}\r\n\r\n			.icons-inner {\r\n				text-align: center;\r\n			}\r\n\r\n			.icons-inner td {\r\n				margin: 0 auto;\r\n			}\r\n\r\n			.image_block div.fullWidth {\r\n				max-width: 100% !important;\r\n			}\r\n\r\n			.mobile_hide {\r\n				display: none;\r\n			}\r\n\r\n			.row-content {\r\n				width: 100% !important;\r\n			}\r\n\r\n			.stack .column {\r\n				width: 100%;\r\n				display: block;\r\n			}\r\n\r\n			.mobile_hide {\r\n				min-height: 0;\r\n				max-height: 0;\r\n				max-width: 0;\r\n				overflow: hidden;\r\n				font-size: 0px;\r\n			}\r\n\r\n			.desktop_hide,\r\n			.desktop_hide table {\r\n				display: table !important;\r\n				max-height: none !important;\r\n			}\r\n		}\r\n	</style><!--[if mso ]><style>sup, sub { font-size: 100% !important; } sup { mso-text-raise:10% } sub { mso-text-raise:-10% }</style> <![endif]-->\r\n</head>\r\n<body class=\"body\" style=\"background-color: #f8f8f9; margin: 0; padding: 0; -webkit-text-size-adjust: none; text-size-adjust: none;\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"nl-container\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-left:40px;padding-right:40px;width:100%;\">\r\n<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n<div class=\"fullWidth\" style=\"max-width: 352px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{Img1_2x}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"352\"/></div>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-top:50px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n	<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:30px;line-height:120%;text-align:center;mso-line-height-alt:36px;\">\r\n	<p style=\"margin: 0; word-break: break-word;\"><span style=\"word-break: break-word; color: #2b303a;\"><strong>Verify Your Email Account</strong></span></p>\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n	<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:center;mso-line-height-alt:22.5px;\">\r\n	<p style=\"margin: 0; word-break: break-word;\">\r\n	<span style=\"word-break: break-word; color: #808389;\">\r\n	We're so glad you're here. To start accessing our Koi care services, please verify your email. It only takes a moment!\r\n	</span>\r\n	</p>\r\n	<p style=\"margin: 0; word-break: break-word;\">\r\n	<span style=\"word-break: break-word; color: #808389;\">\r\n	Simply click the link below to confirm your email and unlock full access to our platform.\r\n	</span>\r\n	</p>\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"button_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-left:10px;padding-right:10px;padding-top:15px;text-align:center;\">\r\n	<div align=\"center\" class=\"alignment\"><!--[if mso]>\r\n	<v:roundrect xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:w=\"urn:schemas-microsoft-com:office:word\" style=\"height:62px;width:222px;v-text-anchor:middle;\" arcsize=\"97%\" stroke=\"false\" fillcolor=\"#1aa19c\">\r\n	<w:anchorlock/>\r\n	<v:textbox inset=\"0px,0px,0px,0px\">\r\n	<center dir=\"false\" style=\"color:#ffffff;font-family:Tahoma, sans-serif;font-size:16px\">\r\n	<![endif]-->\r\n	<div style=\"background-color:#1aa19c;border-radius:60px;color:#ffffff;display:inline-block;font-family:Montserrat, sans-serif;font-size:16px;padding:15px 30px;text-align:center;text-decoration:none;\">\r\n		<a href=\"{VerifyURL}\" style=\"color: #ffffff; text-decoration: none; display: inline-block; line-height: 32px;\">\r\n			<strong>Confirm Your Email</strong>\r\n		</a>\r\n	</div>\r\n	<!--[if mso]></center></v:textbox></v:roundrect><![endif]-->\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #2b303a; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"width:100%;\">\r\n<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n<div style=\"max-width: 640px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{footer}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"640\"/></div>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:10px;padding-right:10px;padding-top:28px;text-align:center;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social-table\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; display: inline-block;\" width=\"208px\">\r\n<tr>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.facebook.com\" target=\"_blank\"><img alt=\"Facebook\" height=\"auto\" src=\"{facebook2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Facebook\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.twitter.com\" target=\"_blank\"><img alt=\"Twitter\" height=\"auto\" src=\"{twitter2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Twitter\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.instagram.com\" target=\"_blank\"><img alt=\"Instagram\" height=\"auto\" src=\"{instagram2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Instagram\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.linkedin.com\" target=\"_blank\"><img alt=\"LinkedIn\" height=\"auto\" src=\"{linkedin2x}\" style=\"display: block; height: auto; border: 0;\" title=\"LinkedIn\" width=\"32\"/></a></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:25px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 1px solid #555961;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"icons_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; text-align: center; line-height: 0;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"vertical-align: middle; color: #1e0e4b; font-family: 'Inter', sans-serif; font-size: 15px; padding-bottom: 5px; padding-top: 5px; text-align: center;\"><!--[if vml]><table align=\"center\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"display:inline-block;padding-left:0px;padding-right:0px;mso-table-lspace: 0pt;mso-table-rspace: 0pt;\"><![endif]-->\r\n<!--[if !vml]><!-->\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table><!-- End -->\r\n</body>\r\n</html>", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4822), "{\"facebook2x\":\"EmailTemplate/e1fbe444-69f1-43f1-ac5a-5ce3e42a1e05_facebook2x.png\",\"footer\":\"EmailTemplate/305d75fc-b361-464e-937e-a495da6e4040_footer.png\",\"Img1_2x\":\"EmailTemplate/3b589f60-80a7-482c-9190-671f68b4a072_Img1_2x.jpg\",\"instagram2x\":\"EmailTemplate/39dd2a42-10b4-4449-a17e-cc5652ca7866_instagram2x.png\",\"linkedin2x\":\"EmailTemplate/54a2a542-a077-4d05-9c7a-e04c5335bf4d_linkedin2x.png\",\"twitter2x\":\"EmailTemplate/2564da8a-64ff-4fab-956e-dc0dd15c3b02_twitter2x.png\"}", false, "Account Activation", "VerifyEmail", "System", new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(4835) }
                });

            migrationBuilder.InsertData(
                table: "Occasion",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "OccasionName" },
                values: new object[,]
                {
                    { new Guid("20f929a6-8236-42aa-adfa-d532f817e1a2"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5385), "Description", false, null, null, "Valentine" },
                    { new Guid("3c051805-0729-4b08-a47e-0bc5eaf4eeee"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5348), "Description", false, null, null, "Spring" },
                    { new Guid("479dba09-053a-4491-a770-210fb578375f"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5388), "Description", false, null, null, "Woman Day" },
                    { new Guid("479dca09-053b-4491-a880-210fb578375a"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5392), "Description", false, null, null, "None" },
                    { new Guid("7698f44c-4710-4e9a-98c0-8e6f80cc9d4d"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5383), "Description", false, null, null, "Winter" },
                    { new Guid("97595211-a421-4a99-9840-5e795a2b3eef"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5381), "Description", false, null, null, "Autumn" },
                    { new Guid("a7619a43-a697-45b2-814c-fd8fbfdfea44"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5377), "Description", false, null, null, "Summer" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5695), "Description", false, null, null, "sticker" },
                    { new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5690), "Description", false, null, null, "postcard" },
                    { new Guid("930b74db-458f-4f4b-9928-c0490141cb7e"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5697), "Description", false, null, null, "evelope" },
                    { new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5685), "Description", false, null, null, "notebook" },
                    { new Guid("f38dd865-ac0b-4a04-8187-aa596e948deb"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5700), "Description", false, null, null, "plantpot" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "IsEmailConfirmed", "IsRegister", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "Points", "ProfilePictureUrl", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("5a9ec5a9-f537-46c2-855b-3a5e2097734a"), null, null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5200), null, "pqt2802@gmail.com", null, false, false, false, null, null, null, "0914725688", 0, null, 3, null },
                    { new Guid("9e8d353c-e071-4de2-ad28-9cd70c043cd8"), "Admin", null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5182), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(5186), "admin@gmail.com", "Admin", false, true, true, null, null, "String123!", "0254725644", 0, "Default", 1, null },
                    { new Guid("f7bdd3c5-d1d7-418b-9929-2d1878d6cbeb"), "Userrr", null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5194), new DateTime(2025, 2, 21, 16, 50, 4, 289, DateTimeKind.Local).AddTicks(5196), "quocthangjk@gmail.com", "User_1", false, true, true, null, null, "String123!", "0914725688", 0, "Default", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Note", "OccasionId", "Price", "ProductCategoryId", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5908), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fthuc_postcard.png?alt=media&token=84ca1a60-f1d2-4b6a-946d-79977e543832", false, null, null, "'Thức'Postcard", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 100m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("294bc753-8475-410d-a77c-4d388e8441eb"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5896), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FSticker%2Fkhoi_sticker.png?alt=media&token=bdb15026-411e-4a69-a936-ac2d0a2c2121", false, null, null, "'Khởi'Sticker", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 100m, new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"), 100 },
                    { new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5890), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FPostcard%2Fkhoi_postcard.png?alt=media&token=43542455-e49d-4d41-9e06-6b5984da3de3", false, null, null, "'Khởi'Postcard", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 100m, new Guid("8939d435-f544-4a28-93e4-06b2682545b9"), 100 },
                    { new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5917), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FSticker%2Fthuc_sticker.png?alt=media&token=54b9284e-398d-4a45-92fe-ec0ee2cdc922", false, null, null, "'Thức'Sticker", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 100m, new Guid("1139d453-c217-4c9a-bfa1-c027de0cdb10"), 100 },
                    { new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5903), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FNoteBook%2Fthuc_notebook.png?alt=media&token=05133546-cbc2-4eba-bf96-e8d3f3a653eb", false, null, null, "'Thức'Notebook", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 100m, new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"), 100 },
                    { new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(5877), "Description", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FNoteBook%2Fkhoi_notebook.png?alt=media&token=175005bb-bcbd-48f0-ae3a-769fdf921249", false, null, null, "'Khởi'Notebook", "Note", new Guid("479dca09-053b-4491-a880-210fb578375a"), 100m, new Guid("c381e083-c6e4-4296-b841-365906c0c9b2"), 100 }
                });

            migrationBuilder.InsertData(
                table: "Set",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Note", "OccasionId", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("77be9079-5750-488b-9831-d637d2383e38"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(6042), "Peach blossom - the symbol of spring and beginning. \"Khoi\" carries the meaning of a start, where ideas bloom, bringing hope and new promises.", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FNoteBook%2Fkhoi_notebook.png?alt=media&token=175005bb-bcbd-48f0-ae3a-769fdf921249", false, null, null, "“KHỞI\" SET", "This product requires a 15-day pre-order.", new Guid("479dca09-053b-4491-a880-210fb578375a"), 10000m, 100 },
                    { new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428"), null, new DateTime(2025, 2, 21, 9, 50, 4, 289, DateTimeKind.Utc).AddTicks(6049), "Flamboyant red of the flamboyant tree – the vibrant color of passion and energy. 'Thuc' marks the awakening, when you are filled with a strong will to face great challenges.", "https://firebasestorage.googleapis.com/v0/b/koiveterinaryservicecent-925db.appspot.com/o/ProductImage%2FNoteBook%2Fthuc_notebook.png?alt=media&token=05133546-cbc2-4eba-bf96-e8d3f3a653eb", false, null, null, "“THỨC\" SET", "This product requires a 15-day pre-order.", new Guid("479dca09-053b-4491-a880-210fb578375a"), 10000m, 100 }
                });

            migrationBuilder.InsertData(
                table: "SetProduct",
                columns: new[] { "ProductId", "SetId" },
                values: new object[,]
                {
                    { new Guid("294bc753-8475-410d-a77c-4d388e8441eb"), new Guid("77be9079-5750-488b-9831-d637d2383e38") },
                    { new Guid("964bbc90-f94d-4be4-9cc4-81f50f3247db"), new Guid("77be9079-5750-488b-9831-d637d2383e38") },
                    { new Guid("eae3ff4b-c1ba-4d52-a2cd-8ad99a10ff5b"), new Guid("77be9079-5750-488b-9831-d637d2383e38") },
                    { new Guid("0d30d6a4-b02c-4a31-bf1a-edec8863298c"), new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428") },
                    { new Guid("a11d4b4c-296e-41a5-ba52-3c144e945a91"), new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428") },
                    { new Guid("d2e6859d-2707-4105-a3fa-c68794e4530c"), new Guid("a0ccbec3-474b-45bf-89f8-59fb306b3428") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserID",
                table: "Cart",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductId",
                table: "CartItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTracking_OrderId",
                table: "OrderTracking",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UserID",
                table: "Payment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PointsHistory_UserID",
                table: "PointsHistory",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OccasionId",
                table: "Product",
                column: "OccasionId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Set_OccasionId",
                table: "Set",
                column: "OccasionId");

            migrationBuilder.CreateIndex(
                name: "IX_SetProduct_ProductId",
                table: "SetProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmail_EmailTemplateId",
                table: "UserEmail",
                column: "EmailTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "OrderTracking");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PointsHistory");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "SetProduct");

            migrationBuilder.DropTable(
                name: "UserEmail");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Occasion");
        }
    }
}
