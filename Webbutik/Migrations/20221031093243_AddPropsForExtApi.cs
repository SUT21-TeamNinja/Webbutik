using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webbutik.Migrations
{
    public partial class AddPropsForExtApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Stars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImDbRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunTimeStr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImdbId = table.Column<int>(type: "int", nullable: true),
                    Directors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InStock = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OrderTotal = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

           

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryMovie",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMovie", x => new { x.CategoriesId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_CategoryMovie_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "ContentRating", "Description", "Directors", "Discount", "DiscountEnd", "DiscountPrice", "DiscountStart", "Genres", "ImDbRating", "ImageUrl", "ImdbId", "InStock", "IsOnSale", "Price", "ReleaseDate", "RunTimeStr", "Stars", "Title" },
                values: new object[,]
                {
                    { 1, "ContentRating 1", "Description 1", "Directors 1", 25, null, null, null, "Genres 1", "ImDbRating 1", "ImageUrl 1", 1, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(4852), "RunTimeStr  1", "Stars 1", "Title 1" },
                    { 2, "ContentRating 2", "Description 2", "Directors 2", 25, null, null, null, "Genres 2", "ImDbRating 2", "ImageUrl 2", 2, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(4949), "RunTimeStr  2", "Stars 2", "Title 2" },
                    { 3, "ContentRating 3", "Description 3", "Directors 3", 25, null, null, null, "Genres 3", "ImDbRating 3", "ImageUrl 3", 3, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(4965), "RunTimeStr  3", "Stars 3", "Title 3" },
                    { 4, "ContentRating 4", "Description 4", "Directors 4", 25, null, null, null, "Genres 4", "ImDbRating 4", "ImageUrl 4", 4, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(4978), "RunTimeStr  4", "Stars 4", "Title 4" },
                    { 5, "ContentRating 5", "Description 5", "Directors 5", 25, null, null, null, "Genres 5", "ImDbRating 5", "ImageUrl 5", 5, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(4991), "RunTimeStr  5", "Stars 5", "Title 5" },
                    { 6, "ContentRating 6", "Description 6", "Directors 6", 25, null, null, null, "Genres 6", "ImDbRating 6", "ImageUrl 6", 6, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5006), "RunTimeStr  6", "Stars 6", "Title 6" },
                    { 7, "ContentRating 7", "Description 7", "Directors 7", 25, null, null, null, "Genres 7", "ImDbRating 7", "ImageUrl 7", 7, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5019), "RunTimeStr  7", "Stars 7", "Title 7" },
                    { 8, "ContentRating 8", "Description 8", "Directors 8", 25, null, null, null, "Genres 8", "ImDbRating 8", "ImageUrl 8", 8, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5032), "RunTimeStr  8", "Stars 8", "Title 8" },
                    { 9, "ContentRating 9", "Description 9", "Directors 9", 25, null, null, null, "Genres 9", "ImDbRating 9", "ImageUrl 9", 9, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5045), "RunTimeStr  9", "Stars 9", "Title 9" },
                    { 10, "ContentRating 10", "Description 10", "Directors 10", 25, null, null, null, "Genres 10", "ImDbRating 10", "ImageUrl 10", 10, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5059), "RunTimeStr  10", "Stars 10", "Title 10" },
                    { 11, "ContentRating 11", "Description 11", "Directors 11", 25, null, null, null, "Genres 11", "ImDbRating 11", "ImageUrl 11", 11, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5102), "RunTimeStr  11", "Stars 11", "Title 11" },
                    { 12, "ContentRating 12", "Description 12", "Directors 12", 25, null, null, null, "Genres 12", "ImDbRating 12", "ImageUrl 12", 12, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5117), "RunTimeStr  12", "Stars 12", "Title 12" },
                    { 13, "ContentRating 13", "Description 13", "Directors 13", 25, null, null, null, "Genres 13", "ImDbRating 13", "ImageUrl 13", 13, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5130), "RunTimeStr  13", "Stars 13", "Title 13" },
                    { 14, "ContentRating 14", "Description 14", "Directors 14", 25, null, null, null, "Genres 14", "ImDbRating 14", "ImageUrl 14", 14, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5143), "RunTimeStr  14", "Stars 14", "Title 14" },
                    { 15, "ContentRating 15", "Description 15", "Directors 15", 25, null, null, null, "Genres 15", "ImDbRating 15", "ImageUrl 15", 15, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5156), "RunTimeStr  15", "Stars 15", "Title 15" },
                    { 16, "ContentRating 16", "Description 16", "Directors 16", 25, null, null, null, "Genres 16", "ImDbRating 16", "ImageUrl 16", 16, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5169), "RunTimeStr  16", "Stars 16", "Title 16" },
                    { 17, "ContentRating 17", "Description 17", "Directors 17", 25, null, null, null, "Genres 17", "ImDbRating 17", "ImageUrl 17", 17, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5182), "RunTimeStr  17", "Stars 17", "Title 17" },
                    { 18, "ContentRating 18", "Description 18", "Directors 18", 25, null, null, null, "Genres 18", "ImDbRating 18", "ImageUrl 18", 18, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5196), "RunTimeStr  18", "Stars 18", "Title 18" },
                    { 19, "ContentRating 19", "Description 19", "Directors 19", 25, null, null, null, "Genres 19", "ImDbRating 19", "ImageUrl 19", 19, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5209), "RunTimeStr  19", "Stars 19", "Title 19" },
                    { 20, "ContentRating 20", "Description 20", "Directors 20", 25, null, null, null, "Genres 20", "ImDbRating 20", "ImageUrl 20", 20, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5257), "RunTimeStr  20", "Stars 20", "Title 20" },
                    { 21, "ContentRating 21", "Description 21", "Directors 21", 25, null, null, null, "Genres 21", "ImDbRating 21", "ImageUrl 21", 21, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5272), "RunTimeStr  21", "Stars 21", "Title 21" },
                    { 22, "ContentRating 22", "Description 22", "Directors 22", 25, null, null, null, "Genres 22", "ImDbRating 22", "ImageUrl 22", 22, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5285), "RunTimeStr  22", "Stars 22", "Title 22" },
                    { 23, "ContentRating 23", "Description 23", "Directors 23", 25, null, null, null, "Genres 23", "ImDbRating 23", "ImageUrl 23", 23, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5298), "RunTimeStr  23", "Stars 23", "Title 23" },
                    { 24, "ContentRating 24", "Description 24", "Directors 24", 25, null, null, null, "Genres 24", "ImDbRating 24", "ImageUrl 24", 24, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5311), "RunTimeStr  24", "Stars 24", "Title 24" },
                    { 25, "ContentRating 25", "Description 25", "Directors 25", 25, null, null, null, "Genres 25", "ImDbRating 25", "ImageUrl 25", 25, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5324), "RunTimeStr  25", "Stars 25", "Title 25" },
                    { 26, "ContentRating 26", "Description 26", "Directors 26", 25, null, null, null, "Genres 26", "ImDbRating 26", "ImageUrl 26", 26, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5336), "RunTimeStr  26", "Stars 26", "Title 26" },
                    { 27, "ContentRating 27", "Description 27", "Directors 27", 25, null, null, null, "Genres 27", "ImDbRating 27", "ImageUrl 27", 27, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5349), "RunTimeStr  27", "Stars 27", "Title 27" },
                    { 28, "ContentRating 28", "Description 28", "Directors 28", 25, null, null, null, "Genres 28", "ImDbRating 28", "ImageUrl 28", 28, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5362), "RunTimeStr  28", "Stars 28", "Title 28" },
                    { 29, "ContentRating 29", "Description 29", "Directors 29", 25, null, null, null, "Genres 29", "ImDbRating 29", "ImageUrl 29", 29, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5375), "RunTimeStr  29", "Stars 29", "Title 29" },
                    { 30, "ContentRating 30", "Description 30", "Directors 30", 25, null, null, null, "Genres 30", "ImDbRating 30", "ImageUrl 30", 30, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5434), "RunTimeStr  30", "Stars 30", "Title 30" },
                    { 31, "ContentRating 31", "Description 31", "Directors 31", 25, null, null, null, "Genres 31", "ImDbRating 31", "ImageUrl 31", 31, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5448), "RunTimeStr  31", "Stars 31", "Title 31" },
                    { 32, "ContentRating 32", "Description 32", "Directors 32", 25, null, null, null, "Genres 32", "ImDbRating 32", "ImageUrl 32", 32, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5461), "RunTimeStr  32", "Stars 32", "Title 32" },
                    { 33, "ContentRating 33", "Description 33", "Directors 33", 25, null, null, null, "Genres 33", "ImDbRating 33", "ImageUrl 33", 33, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5474), "RunTimeStr  33", "Stars 33", "Title 33" },
                    { 34, "ContentRating 34", "Description 34", "Directors 34", 25, null, null, null, "Genres 34", "ImDbRating 34", "ImageUrl 34", 34, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5488), "RunTimeStr  34", "Stars 34", "Title 34" },
                    { 35, "ContentRating 35", "Description 35", "Directors 35", 25, null, null, null, "Genres 35", "ImDbRating 35", "ImageUrl 35", 35, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5501), "RunTimeStr  35", "Stars 35", "Title 35" },
                    { 36, "ContentRating 36", "Description 36", "Directors 36", 25, null, null, null, "Genres 36", "ImDbRating 36", "ImageUrl 36", 36, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5514), "RunTimeStr  36", "Stars 36", "Title 36" },
                    { 37, "ContentRating 37", "Description 37", "Directors 37", 25, null, null, null, "Genres 37", "ImDbRating 37", "ImageUrl 37", 37, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5527), "RunTimeStr  37", "Stars 37", "Title 37" },
                    { 38, "ContentRating 38", "Description 38", "Directors 38", 25, null, null, null, "Genres 38", "ImDbRating 38", "ImageUrl 38", 38, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5539), "RunTimeStr  38", "Stars 38", "Title 38" },
                    { 39, "ContentRating 39", "Description 39", "Directors 39", 25, null, null, null, "Genres 39", "ImDbRating 39", "ImageUrl 39", 39, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5581), "RunTimeStr  39", "Stars 39", "Title 39" },
                    { 40, "ContentRating 40", "Description 40", "Directors 40", 25, null, null, null, "Genres 40", "ImDbRating 40", "ImageUrl 40", 40, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5595), "RunTimeStr  40", "Stars 40", "Title 40" },
                    { 41, "ContentRating 41", "Description 41", "Directors 41", 25, null, null, null, "Genres 41", "ImDbRating 41", "ImageUrl 41", 41, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5608), "RunTimeStr  41", "Stars 41", "Title 41" },
                    { 42, "ContentRating 42", "Description 42", "Directors 42", 25, null, null, null, "Genres 42", "ImDbRating 42", "ImageUrl 42", 42, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5621), "RunTimeStr  42", "Stars 42", "Title 42" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "ContentRating", "Description", "Directors", "Discount", "DiscountEnd", "DiscountPrice", "DiscountStart", "Genres", "ImDbRating", "ImageUrl", "ImdbId", "InStock", "IsOnSale", "Price", "ReleaseDate", "RunTimeStr", "Stars", "Title" },
                values: new object[,]
                {
                    { 43, "ContentRating 43", "Description 43", "Directors 43", 25, null, null, null, "Genres 43", "ImDbRating 43", "ImageUrl 43", 43, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5634), "RunTimeStr  43", "Stars 43", "Title 43" },
                    { 44, "ContentRating 44", "Description 44", "Directors 44", 25, null, null, null, "Genres 44", "ImDbRating 44", "ImageUrl 44", 44, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5646), "RunTimeStr  44", "Stars 44", "Title 44" },
                    { 45, "ContentRating 45", "Description 45", "Directors 45", 25, null, null, null, "Genres 45", "ImDbRating 45", "ImageUrl 45", 45, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5659), "RunTimeStr  45", "Stars 45", "Title 45" },
                    { 46, "ContentRating 46", "Description 46", "Directors 46", 25, null, null, null, "Genres 46", "ImDbRating 46", "ImageUrl 46", 46, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5672), "RunTimeStr  46", "Stars 46", "Title 46" },
                    { 47, "ContentRating 47", "Description 47", "Directors 47", 25, null, null, null, "Genres 47", "ImDbRating 47", "ImageUrl 47", 47, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5684), "RunTimeStr  47", "Stars 47", "Title 47" },
                    { 48, "ContentRating 48", "Description 48", "Directors 48", 25, null, null, null, "Genres 48", "ImDbRating 48", "ImageUrl 48", 48, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5697), "RunTimeStr  48", "Stars 48", "Title 48" },
                    { 49, "ContentRating 49", "Description 49", "Directors 49", 25, null, null, null, "Genres 49", "ImDbRating 49", "ImageUrl 49", 49, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5739), "RunTimeStr  49", "Stars 49", "Title 49" },
                    { 50, "ContentRating 50", "Description 50", "Directors 50", 25, null, null, null, "Genres 50", "ImDbRating 50", "ImageUrl 50", 50, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5752), "RunTimeStr  50", "Stars 50", "Title 50" },
                    { 51, "ContentRating 51", "Description 51", "Directors 51", 25, null, null, null, "Genres 51", "ImDbRating 51", "ImageUrl 51", 51, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5765), "RunTimeStr  51", "Stars 51", "Title 51" },
                    { 52, "ContentRating 52", "Description 52", "Directors 52", 25, null, null, null, "Genres 52", "ImDbRating 52", "ImageUrl 52", 52, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5778), "RunTimeStr  52", "Stars 52", "Title 52" },
                    { 53, "ContentRating 53", "Description 53", "Directors 53", 25, null, null, null, "Genres 53", "ImDbRating 53", "ImageUrl 53", 53, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5790), "RunTimeStr  53", "Stars 53", "Title 53" },
                    { 54, "ContentRating 54", "Description 54", "Directors 54", 25, null, null, null, "Genres 54", "ImDbRating 54", "ImageUrl 54", 54, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5803), "RunTimeStr  54", "Stars 54", "Title 54" },
                    { 55, "ContentRating 55", "Description 55", "Directors 55", 25, null, null, null, "Genres 55", "ImDbRating 55", "ImageUrl 55", 55, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5816), "RunTimeStr  55", "Stars 55", "Title 55" },
                    { 56, "ContentRating 56", "Description 56", "Directors 56", 25, null, null, null, "Genres 56", "ImDbRating 56", "ImageUrl 56", 56, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5828), "RunTimeStr  56", "Stars 56", "Title 56" },
                    { 57, "ContentRating 57", "Description 57", "Directors 57", 25, null, null, null, "Genres 57", "ImDbRating 57", "ImageUrl 57", 57, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5841), "RunTimeStr  57", "Stars 57", "Title 57" },
                    { 58, "ContentRating 58", "Description 58", "Directors 58", 25, null, null, null, "Genres 58", "ImDbRating 58", "ImageUrl 58", 58, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5882), "RunTimeStr  58", "Stars 58", "Title 58" },
                    { 59, "ContentRating 59", "Description 59", "Directors 59", 25, null, null, null, "Genres 59", "ImDbRating 59", "ImageUrl 59", 59, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5896), "RunTimeStr  59", "Stars 59", "Title 59" },
                    { 60, "ContentRating 60", "Description 60", "Directors 60", 25, null, null, null, "Genres 60", "ImDbRating 60", "ImageUrl 60", 60, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5909), "RunTimeStr  60", "Stars 60", "Title 60" },
                    { 61, "ContentRating 61", "Description 61", "Directors 61", 25, null, null, null, "Genres 61", "ImDbRating 61", "ImageUrl 61", 61, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5922), "RunTimeStr  61", "Stars 61", "Title 61" },
                    { 62, "ContentRating 62", "Description 62", "Directors 62", 25, null, null, null, "Genres 62", "ImDbRating 62", "ImageUrl 62", 62, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5935), "RunTimeStr  62", "Stars 62", "Title 62" },
                    { 63, "ContentRating 63", "Description 63", "Directors 63", 25, null, null, null, "Genres 63", "ImDbRating 63", "ImageUrl 63", 63, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5948), "RunTimeStr  63", "Stars 63", "Title 63" },
                    { 64, "ContentRating 64", "Description 64", "Directors 64", 25, null, null, null, "Genres 64", "ImDbRating 64", "ImageUrl 64", 64, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5960), "RunTimeStr  64", "Stars 64", "Title 64" },
                    { 65, "ContentRating 65", "Description 65", "Directors 65", 25, null, null, null, "Genres 65", "ImDbRating 65", "ImageUrl 65", 65, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5973), "RunTimeStr  65", "Stars 65", "Title 65" },
                    { 66, "ContentRating 66", "Description 66", "Directors 66", 25, null, null, null, "Genres 66", "ImDbRating 66", "ImageUrl 66", 66, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(5987), "RunTimeStr  66", "Stars 66", "Title 66" },
                    { 67, "ContentRating 67", "Description 67", "Directors 67", 25, null, null, null, "Genres 67", "ImDbRating 67", "ImageUrl 67", 67, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6029), "RunTimeStr  67", "Stars 67", "Title 67" },
                    { 68, "ContentRating 68", "Description 68", "Directors 68", 25, null, null, null, "Genres 68", "ImDbRating 68", "ImageUrl 68", 68, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6042), "RunTimeStr  68", "Stars 68", "Title 68" },
                    { 69, "ContentRating 69", "Description 69", "Directors 69", 25, null, null, null, "Genres 69", "ImDbRating 69", "ImageUrl 69", 69, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6055), "RunTimeStr  69", "Stars 69", "Title 69" },
                    { 70, "ContentRating 70", "Description 70", "Directors 70", 25, null, null, null, "Genres 70", "ImDbRating 70", "ImageUrl 70", 70, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6068), "RunTimeStr  70", "Stars 70", "Title 70" },
                    { 71, "ContentRating 71", "Description 71", "Directors 71", 25, null, null, null, "Genres 71", "ImDbRating 71", "ImageUrl 71", 71, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6081), "RunTimeStr  71", "Stars 71", "Title 71" },
                    { 72, "ContentRating 72", "Description 72", "Directors 72", 25, null, null, null, "Genres 72", "ImDbRating 72", "ImageUrl 72", 72, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6093), "RunTimeStr  72", "Stars 72", "Title 72" },
                    { 73, "ContentRating 73", "Description 73", "Directors 73", 25, null, null, null, "Genres 73", "ImDbRating 73", "ImageUrl 73", 73, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6106), "RunTimeStr  73", "Stars 73", "Title 73" },
                    { 74, "ContentRating 74", "Description 74", "Directors 74", 25, null, null, null, "Genres 74", "ImDbRating 74", "ImageUrl 74", 74, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6119), "RunTimeStr  74", "Stars 74", "Title 74" },
                    { 75, "ContentRating 75", "Description 75", "Directors 75", 25, null, null, null, "Genres 75", "ImDbRating 75", "ImageUrl 75", 75, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6132), "RunTimeStr  75", "Stars 75", "Title 75" },
                    { 76, "ContentRating 76", "Description 76", "Directors 76", 25, null, null, null, "Genres 76", "ImDbRating 76", "ImageUrl 76", 76, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6173), "RunTimeStr  76", "Stars 76", "Title 76" },
                    { 77, "ContentRating 77", "Description 77", "Directors 77", 25, null, null, null, "Genres 77", "ImDbRating 77", "ImageUrl 77", 77, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6187), "RunTimeStr  77", "Stars 77", "Title 77" },
                    { 78, "ContentRating 78", "Description 78", "Directors 78", 25, null, null, null, "Genres 78", "ImDbRating 78", "ImageUrl 78", 78, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6200), "RunTimeStr  78", "Stars 78", "Title 78" },
                    { 79, "ContentRating 79", "Description 79", "Directors 79", 25, null, null, null, "Genres 79", "ImDbRating 79", "ImageUrl 79", 79, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6213), "RunTimeStr  79", "Stars 79", "Title 79" },
                    { 80, "ContentRating 80", "Description 80", "Directors 80", 25, null, null, null, "Genres 80", "ImDbRating 80", "ImageUrl 80", 80, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6226), "RunTimeStr  80", "Stars 80", "Title 80" },
                    { 81, "ContentRating 81", "Description 81", "Directors 81", 25, null, null, null, "Genres 81", "ImDbRating 81", "ImageUrl 81", 81, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6238), "RunTimeStr  81", "Stars 81", "Title 81" },
                    { 82, "ContentRating 82", "Description 82", "Directors 82", 25, null, null, null, "Genres 82", "ImDbRating 82", "ImageUrl 82", 82, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6251), "RunTimeStr  82", "Stars 82", "Title 82" },
                    { 83, "ContentRating 83", "Description 83", "Directors 83", 25, null, null, null, "Genres 83", "ImDbRating 83", "ImageUrl 83", 83, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6264), "RunTimeStr  83", "Stars 83", "Title 83" },
                    { 84, "ContentRating 84", "Description 84", "Directors 84", 25, null, null, null, "Genres 84", "ImDbRating 84", "ImageUrl 84", 84, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6277), "RunTimeStr  84", "Stars 84", "Title 84" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "ContentRating", "Description", "Directors", "Discount", "DiscountEnd", "DiscountPrice", "DiscountStart", "Genres", "ImDbRating", "ImageUrl", "ImdbId", "InStock", "IsOnSale", "Price", "ReleaseDate", "RunTimeStr", "Stars", "Title" },
                values: new object[,]
                {
                    { 85, "ContentRating 85", "Description 85", "Directors 85", 25, null, null, null, "Genres 85", "ImDbRating 85", "ImageUrl 85", 85, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6290), "RunTimeStr  85", "Stars 85", "Title 85" },
                    { 86, "ContentRating 86", "Description 86", "Directors 86", 25, null, null, null, "Genres 86", "ImDbRating 86", "ImageUrl 86", 86, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6332), "RunTimeStr  86", "Stars 86", "Title 86" },
                    { 87, "ContentRating 87", "Description 87", "Directors 87", 25, null, null, null, "Genres 87", "ImDbRating 87", "ImageUrl 87", 87, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6346), "RunTimeStr  87", "Stars 87", "Title 87" },
                    { 88, "ContentRating 88", "Description 88", "Directors 88", 25, null, null, null, "Genres 88", "ImDbRating 88", "ImageUrl 88", 88, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6359), "RunTimeStr  88", "Stars 88", "Title 88" },
                    { 89, "ContentRating 89", "Description 89", "Directors 89", 25, null, null, null, "Genres 89", "ImDbRating 89", "ImageUrl 89", 89, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6371), "RunTimeStr  89", "Stars 89", "Title 89" },
                    { 90, "ContentRating 90", "Description 90", "Directors 90", 25, null, null, null, "Genres 90", "ImDbRating 90", "ImageUrl 90", 90, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6384), "RunTimeStr  90", "Stars 90", "Title 90" },
                    { 91, "ContentRating 91", "Description 91", "Directors 91", 25, null, null, null, "Genres 91", "ImDbRating 91", "ImageUrl 91", 91, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6397), "RunTimeStr  91", "Stars 91", "Title 91" },
                    { 92, "ContentRating 92", "Description 92", "Directors 92", 25, null, null, null, "Genres 92", "ImDbRating 92", "ImageUrl 92", 92, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6410), "RunTimeStr  92", "Stars 92", "Title 92" },
                    { 93, "ContentRating 93", "Description 93", "Directors 93", 25, null, null, null, "Genres 93", "ImDbRating 93", "ImageUrl 93", 93, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6422), "RunTimeStr  93", "Stars 93", "Title 93" },
                    { 94, "ContentRating 94", "Description 94", "Directors 94", 25, null, null, null, "Genres 94", "ImDbRating 94", "ImageUrl 94", 94, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6435), "RunTimeStr  94", "Stars 94", "Title 94" },
                    { 95, "ContentRating 95", "Description 95", "Directors 95", 25, null, null, null, "Genres 95", "ImDbRating 95", "ImageUrl 95", 95, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6448), "RunTimeStr  95", "Stars 95", "Title 95" },
                    { 96, "ContentRating 96", "Description 96", "Directors 96", 25, null, null, null, "Genres 96", "ImDbRating 96", "ImageUrl 96", 96, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6492), "RunTimeStr  96", "Stars 96", "Title 96" },
                    { 97, "ContentRating 97", "Description 97", "Directors 97", 25, null, null, null, "Genres 97", "ImDbRating 97", "ImageUrl 97", 97, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6505), "RunTimeStr  97", "Stars 97", "Title 97" },
                    { 98, "ContentRating 98", "Description 98", "Directors 98", 25, null, null, null, "Genres 98", "ImDbRating 98", "ImageUrl 98", 98, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6518), "RunTimeStr  98", "Stars 98", "Title 98" },
                    { 99, "ContentRating 99", "Description 99", "Directors 99", 25, null, null, null, "Genres 99", "ImDbRating 99", "ImageUrl 99", 99, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6530), "RunTimeStr  99", "Stars 99", "Title 99" },
                    { 100, "ContentRating 100", "Description 100", "Directors 100", 25, null, null, null, "Genres 100", "ImDbRating 100", "ImageUrl 100", 100, 1, true, null, new DateTime(2022, 10, 31, 10, 32, 43, 702, DateTimeKind.Local).AddTicks(6544), "RunTimeStr  100", "Stars 100", "Title 100" }
                });



            migrationBuilder.CreateIndex(
                name: "IX_CartItems_MovieId",
                table: "CartItems",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMovie_MoviesId",
                table: "CategoryMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MovieId",
                table: "OrderDetails",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "CategoryMovie");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
