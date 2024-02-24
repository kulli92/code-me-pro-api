using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeMePro.Migrations
{
    public partial class AddedInitialDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CourierCharge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MinWeight = table.Column<int>(type: "int", nullable: false),
                    MaxWeight = table.Column<int>(type: "int", nullable: false),
                    Charge = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourierCharge", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalWeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageId);
                    table.ForeignKey(
                        name: "FK_Packages_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PackageDetails",
                columns: table => new
                {
                    PackageDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageDetails", x => x.PackageDetailId);
                    table.ForeignKey(
                        name: "FK_PackageDetails_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CourierCharge",
                columns: new[] { "Id", "Charge", "MaxWeight", "MinWeight" },
                values: new object[,]
                {
                    { 1, 5m, 200, 0 },
                    { 2, 10m, 500, 201 },
                    { 3, 15m, 1000, 501 },
                    { 4, 20m, 5000, 1001 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Weight" },
                values: new object[,]
                {
                    { 1, "Item 1", 10m, 200 },
                    { 2, "Item 2", 100m, 20 },
                    { 3, "Item 3", 30m, 300 },
                    { 4, "Item 4", 20m, 500 },
                    { 5, "Item 5", 30m, 250 },
                    { 6, "Item 6", 40m, 10 },
                    { 7, "Item 7", 200m, 10 },
                    { 8, "Item 8", 120m, 500 },
                    { 9, "Item 9", 130m, 790 },
                    { 10, "Item 10", 20m, 100 },
                    { 11, "Item 11", 10m, 340 },
                    { 12, "Item 12", 4m, 800 },
                    { 13, "Item 13", 5m, 200 },
                    { 14, "Item 14", 240m, 20 },
                    { 15, "Item 15", 123m, 700 },
                    { 16, "Item 16", 245m, 10 },
                    { 17, "Item 17", 230m, 20 },
                    { 18, "Item 18", 110m, 200 },
                    { 19, "Item 19", 45m, 200 },
                    { 20, "Item 20", 67m, 20 },
                    { 21, "Item 21", 88m, 300 },
                    { 22, "Item 22", 10m, 500 },
                    { 23, "Item 23", 17m, 250 },
                    { 24, "Item 24", 19m, 10 },
                    { 25, "Item 25", 89m, 10 },
                    { 26, "Item 26", 45m, 500 },
                    { 27, "Item 27", 99m, 790 },
                    { 28, "Item 28", 125m, 100 },
                    { 29, "Item 29", 198m, 340 },
                    { 30, "Item 30", 220m, 800 },
                    { 31, "Item 31", 249m, 200 },
                    { 32, "Item 32", 230m, 20 },
                    { 33, "Item 33", 190m, 700 },
                    { 34, "Item 34", 45m, 10 },
                    { 35, "Item 35", 12m, 20 },
                    { 36, "Item 36", 5m, 200 },
                    { 37, "Item 37", 2m, 200 },
                    { 38, "Item 38", 90m, 20 },
                    { 39, "Item 39", 12m, 300 },
                    { 40, "Item 40", 167m, 500 },
                    { 41, "Item 41", 12m, 250 },
                    { 42, "Item 42", 8m, 10 },
                    { 43, "Item 43", 2m, 10 },
                    { 44, "Item 44", 9m, 500 },
                    { 45, "Item 45", 210m, 790 },
                    { 46, "Item 46", 167m, 100 },
                    { 47, "Item 47", 23m, 340 },
                    { 48, "Item 48", 190m, 800 },
                    { 49, "Item 49", 199m, 200 },
                    { 50, "Item 50", 12m, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageDetails_PackageId",
                table: "PackageDetails",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageDetails_ProductId",
                table: "PackageDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_OrderId",
                table: "Packages",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourierCharge");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PackageDetails");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
