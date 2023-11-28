﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class startPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice" },
                values: new object[] { 1, "Computer", 15000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice" },
                values: new object[] { 2, "Keyboard", 500m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice" },
                values: new object[] { 3, "Mouse", 1000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice" },
                values: new object[] { 4, "Deck", 1500m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
