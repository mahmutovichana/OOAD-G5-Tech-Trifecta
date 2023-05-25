using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCafe.Data.Migrations
{
    public partial class FirstFullMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bartender",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bartender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Drink",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drink", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tableNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Statistic",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalProfit = table.Column<double>(type: "float", nullable: false),
                    dailyProfit = table.Column<double>(type: "float", nullable: false),
                    idDrink = table.Column<int>(type: "int", nullable: false),
                    mostSoldDrinkid = table.Column<int>(type: "int", nullable: true),
                    noOfEmployees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistic", x => x.id);
                    table.ForeignKey(
                        name: "FK_Statistic_Drink_mostSoldDrinkid",
                        column: x => x.mostSoldDrinkid,
                        principalTable: "Drink",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    done = table.Column<bool>(type: "bit", nullable: false),
                    tableNumber = table.Column<int>(type: "int", nullable: false),
                    orderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idBartender = table.Column<int>(type: "int", nullable: false),
                    bartenderid = table.Column<int>(type: "int", nullable: true),
                    idGuest = table.Column<int>(type: "int", nullable: false),
                    guestid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                    table.ForeignKey(
                        name: "FK_Order_Bartender_bartenderid",
                        column: x => x.bartenderid,
                        principalTable: "Bartender",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Guest_guestid",
                        column: x => x.guestid,
                        principalTable: "Guest",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DrinkIngredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDrink = table.Column<int>(type: "int", nullable: false),
                    drinkid = table.Column<int>(type: "int", nullable: true),
                    idIngredient = table.Column<int>(type: "int", nullable: false),
                    ingredientid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkIngredient", x => x.id);
                    table.ForeignKey(
                        name: "FK_DrinkIngredient_Drink_drinkid",
                        column: x => x.drinkid,
                        principalTable: "Drink",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DrinkIngredient_Ingredient_ingredientid",
                        column: x => x.ingredientid,
                        principalTable: "Ingredient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDrink = table.Column<int>(type: "int", nullable: false),
                    drinkid = table.Column<int>(type: "int", nullable: true),
                    idOrder = table.Column<int>(type: "int", nullable: false),
                    orderid = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Drink_drinkid",
                        column: x => x.drinkid,
                        principalTable: "Drink",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_orderid",
                        column: x => x.orderid,
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrinkIngredient_drinkid",
                table: "DrinkIngredient",
                column: "drinkid");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkIngredient_ingredientid",
                table: "DrinkIngredient",
                column: "ingredientid");

            migrationBuilder.CreateIndex(
                name: "IX_Order_bartenderid",
                table: "Order",
                column: "bartenderid");

            migrationBuilder.CreateIndex(
                name: "IX_Order_guestid",
                table: "Order",
                column: "guestid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_drinkid",
                table: "OrderItem",
                column: "drinkid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_orderid",
                table: "OrderItem",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_Statistic_mostSoldDrinkid",
                table: "Statistic",
                column: "mostSoldDrinkid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrinkIngredient");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Statistic");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Drink");

            migrationBuilder.DropTable(
                name: "Bartender");

            migrationBuilder.DropTable(
                name: "Guest");
        }
    }
}
