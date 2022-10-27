using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webbutik.Migrations
{
    public partial class AddedEverythingAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    Writers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Directors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
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
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OrderTotal = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "Description", "Directors", "Discount", "DiscountEnd", "DiscountStart", "ImageUrl", "InStock", "IsOnSale", "Price", "ReleaseDate", "Stars", "Title", "Writers" },
                values: new object[,]
                {
                    { 1, "Description 1", "Directors 1", 25, null, null, "ImageUrl 1", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2036), "Stars 1", "Title 1", "Writers 1" },
                    { 2, "Description 2", "Directors 2", 25, null, null, "ImageUrl 2", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2128), "Stars 2", "Title 2", "Writers 2" },
                    { 3, "Description 3", "Directors 3", 25, null, null, "ImageUrl 3", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2143), "Stars 3", "Title 3", "Writers 3" },
                    { 4, "Description 4", "Directors 4", 25, null, null, "ImageUrl 4", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2205), "Stars 4", "Title 4", "Writers 4" },
                    { 5, "Description 5", "Directors 5", 25, null, null, "ImageUrl 5", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2219), "Stars 5", "Title 5", "Writers 5" },
                    { 6, "Description 6", "Directors 6", 25, null, null, "ImageUrl 6", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2235), "Stars 6", "Title 6", "Writers 6" },
                    { 7, "Description 7", "Directors 7", 25, null, null, "ImageUrl 7", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2249), "Stars 7", "Title 7", "Writers 7" },
                    { 8, "Description 8", "Directors 8", 25, null, null, "ImageUrl 8", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2262), "Stars 8", "Title 8", "Writers 8" },
                    { 9, "Description 9", "Directors 9", 25, null, null, "ImageUrl 9", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2276), "Stars 9", "Title 9", "Writers 9" },
                    { 10, "Description 10", "Directors 10", 25, null, null, "ImageUrl 10", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2292), "Stars 10", "Title 10", "Writers 10" },
                    { 11, "Description 11", "Directors 11", 25, null, null, "ImageUrl 11", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2305), "Stars 11", "Title 11", "Writers 11" },
                    { 12, "Description 12", "Directors 12", 25, null, null, "ImageUrl 12", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2319), "Stars 12", "Title 12", "Writers 12" },
                    { 13, "Description 13", "Directors 13", 25, null, null, "ImageUrl 13", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2332), "Stars 13", "Title 13", "Writers 13" },
                    { 14, "Description 14", "Directors 14", 25, null, null, "ImageUrl 14", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2345), "Stars 14", "Title 14", "Writers 14" },
                    { 15, "Description 15", "Directors 15", 25, null, null, "ImageUrl 15", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2360), "Stars 15", "Title 15", "Writers 15" },
                    { 16, "Description 16", "Directors 16", 25, null, null, "ImageUrl 16", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2414), "Stars 16", "Title 16", "Writers 16" },
                    { 17, "Description 17", "Directors 17", 25, null, null, "ImageUrl 17", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2429), "Stars 17", "Title 17", "Writers 17" },
                    { 18, "Description 18", "Directors 18", 25, null, null, "ImageUrl 18", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2445), "Stars 18", "Title 18", "Writers 18" },
                    { 19, "Description 19", "Directors 19", 25, null, null, "ImageUrl 19", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2458), "Stars 19", "Title 19", "Writers 19" },
                    { 20, "Description 20", "Directors 20", 25, null, null, "ImageUrl 20", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2472), "Stars 20", "Title 20", "Writers 20" },
                    { 21, "Description 21", "Directors 21", 25, null, null, "ImageUrl 21", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2485), "Stars 21", "Title 21", "Writers 21" },
                    { 22, "Description 22", "Directors 22", 25, null, null, "ImageUrl 22", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2498), "Stars 22", "Title 22", "Writers 22" },
                    { 23, "Description 23", "Directors 23", 25, null, null, "ImageUrl 23", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2512), "Stars 23", "Title 23", "Writers 23" },
                    { 24, "Description 24", "Directors 24", 25, null, null, "ImageUrl 24", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2525), "Stars 24", "Title 24", "Writers 24" },
                    { 25, "Description 25", "Directors 25", 25, null, null, "ImageUrl 25", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2539), "Stars 25", "Title 25", "Writers 25" },
                    { 26, "Description 26", "Directors 26", 25, null, null, "ImageUrl 26", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2552), "Stars 26", "Title 26", "Writers 26" },
                    { 27, "Description 27", "Directors 27", 25, null, null, "ImageUrl 27", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2567), "Stars 27", "Title 27", "Writers 27" },
                    { 28, "Description 28", "Directors 28", 25, null, null, "ImageUrl 28", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2624), "Stars 28", "Title 28", "Writers 28" },
                    { 29, "Description 29", "Directors 29", 25, null, null, "ImageUrl 29", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2640), "Stars 29", "Title 29", "Writers 29" },
                    { 30, "Description 30", "Directors 30", 25, null, null, "ImageUrl 30", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2654), "Stars 30", "Title 30", "Writers 30" },
                    { 31, "Description 31", "Directors 31", 25, null, null, "ImageUrl 31", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2667), "Stars 31", "Title 31", "Writers 31" },
                    { 32, "Description 32", "Directors 32", 25, null, null, "ImageUrl 32", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2681), "Stars 32", "Title 32", "Writers 32" },
                    { 33, "Description 33", "Directors 33", 25, null, null, "ImageUrl 33", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2694), "Stars 33", "Title 33", "Writers 33" },
                    { 34, "Description 34", "Directors 34", 25, null, null, "ImageUrl 34", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2710), "Stars 34", "Title 34", "Writers 34" },
                    { 35, "Description 35", "Directors 35", 25, null, null, "ImageUrl 35", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2724), "Stars 35", "Title 35", "Writers 35" },
                    { 36, "Description 36", "Directors 36", 25, null, null, "ImageUrl 36", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2737), "Stars 36", "Title 36", "Writers 36" },
                    { 37, "Description 37", "Directors 37", 25, null, null, "ImageUrl 37", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2751), "Stars 37", "Title 37", "Writers 37" },
                    { 38, "Description 38", "Directors 38", 25, null, null, "ImageUrl 38", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2764), "Stars 38", "Title 38", "Writers 38" },
                    { 39, "Description 39", "Directors 39", 25, null, null, "ImageUrl 39", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2778), "Stars 39", "Title 39", "Writers 39" },
                    { 40, "Description 40", "Directors 40", 25, null, null, "ImageUrl 40", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3695), "Stars 40", "Title 40", "Writers 40" },
                    { 41, "Description 41", "Directors 41", 25, null, null, "ImageUrl 41", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3730), "Stars 41", "Title 41", "Writers 41" },
                    { 42, "Description 42", "Directors 42", 25, null, null, "ImageUrl 42", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3746), "Stars 42", "Title 42", "Writers 42" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Directors", "Discount", "DiscountEnd", "DiscountStart", "ImageUrl", "InStock", "IsOnSale", "Price", "ReleaseDate", "Stars", "Title", "Writers" },
                values: new object[,]
                {
                    { 43, "Description 43", "Directors 43", 25, null, null, "ImageUrl 43", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3759), "Stars 43", "Title 43", "Writers 43" },
                    { 44, "Description 44", "Directors 44", 25, null, null, "ImageUrl 44", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3774), "Stars 44", "Title 44", "Writers 44" },
                    { 45, "Description 45", "Directors 45", 25, null, null, "ImageUrl 45", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3788), "Stars 45", "Title 45", "Writers 45" },
                    { 46, "Description 46", "Directors 46", 25, null, null, "ImageUrl 46", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3802), "Stars 46", "Title 46", "Writers 46" },
                    { 47, "Description 47", "Directors 47", 25, null, null, "ImageUrl 47", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3816), "Stars 47", "Title 47", "Writers 47" },
                    { 48, "Description 48", "Directors 48", 25, null, null, "ImageUrl 48", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3831), "Stars 48", "Title 48", "Writers 48" },
                    { 49, "Description 49", "Directors 49", 25, null, null, "ImageUrl 49", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3844), "Stars 49", "Title 49", "Writers 49" },
                    { 50, "Description 50", "Directors 50", 25, null, null, "ImageUrl 50", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3858), "Stars 50", "Title 50", "Writers 50" },
                    { 51, "Description 51", "Directors 51", 25, null, null, "ImageUrl 51", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3871), "Stars 51", "Title 51", "Writers 51" },
                    { 52, "Description 52", "Directors 52", 25, null, null, "ImageUrl 52", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3885), "Stars 52", "Title 52", "Writers 52" },
                    { 53, "Description 53", "Directors 53", 25, null, null, "ImageUrl 53", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3946), "Stars 53", "Title 53", "Writers 53" },
                    { 54, "Description 54", "Directors 54", 25, null, null, "ImageUrl 54", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3962), "Stars 54", "Title 54", "Writers 54" },
                    { 55, "Description 55", "Directors 55", 25, null, null, "ImageUrl 55", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3976), "Stars 55", "Title 55", "Writers 55" },
                    { 56, "Description 56", "Directors 56", 25, null, null, "ImageUrl 56", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3990), "Stars 56", "Title 56", "Writers 56" },
                    { 57, "Description 57", "Directors 57", 25, null, null, "ImageUrl 57", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4004), "Stars 57", "Title 57", "Writers 57" },
                    { 58, "Description 58", "Directors 58", 25, null, null, "ImageUrl 58", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4018), "Stars 58", "Title 58", "Writers 58" },
                    { 59, "Description 59", "Directors 59", 25, null, null, "ImageUrl 59", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4032), "Stars 59", "Title 59", "Writers 59" },
                    { 60, "Description 60", "Directors 60", 25, null, null, "ImageUrl 60", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4045), "Stars 60", "Title 60", "Writers 60" },
                    { 61, "Description 61", "Directors 61", 25, null, null, "ImageUrl 61", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4059), "Stars 61", "Title 61", "Writers 61" },
                    { 62, "Description 62", "Directors 62", 25, null, null, "ImageUrl 62", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4073), "Stars 62", "Title 62", "Writers 62" },
                    { 63, "Description 63", "Directors 63", 25, null, null, "ImageUrl 63", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4088), "Stars 63", "Title 63", "Writers 63" },
                    { 64, "Description 64", "Directors 64", 25, null, null, "ImageUrl 64", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4101), "Stars 64", "Title 64", "Writers 64" },
                    { 65, "Description 65", "Directors 65", 25, null, null, "ImageUrl 65", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4115), "Stars 65", "Title 65", "Writers 65" },
                    { 66, "Description 66", "Directors 66", 25, null, null, "ImageUrl 66", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4214), "Stars 66", "Title 66", "Writers 66" },
                    { 67, "Description 67", "Directors 67", 25, null, null, "ImageUrl 67", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4229), "Stars 67", "Title 67", "Writers 67" },
                    { 68, "Description 68", "Directors 68", 25, null, null, "ImageUrl 68", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4243), "Stars 68", "Title 68", "Writers 68" },
                    { 69, "Description 69", "Directors 69", 25, null, null, "ImageUrl 69", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4257), "Stars 69", "Title 69", "Writers 69" },
                    { 70, "Description 70", "Directors 70", 25, null, null, "ImageUrl 70", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4271), "Stars 70", "Title 70", "Writers 70" },
                    { 71, "Description 71", "Directors 71", 25, null, null, "ImageUrl 71", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4284), "Stars 71", "Title 71", "Writers 71" },
                    { 72, "Description 72", "Directors 72", 25, null, null, "ImageUrl 72", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4297), "Stars 72", "Title 72", "Writers 72" },
                    { 73, "Description 73", "Directors 73", 25, null, null, "ImageUrl 73", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4311), "Stars 73", "Title 73", "Writers 73" },
                    { 74, "Description 74", "Directors 74", 25, null, null, "ImageUrl 74", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4325), "Stars 74", "Title 74", "Writers 74" },
                    { 75, "Description 75", "Directors 75", 25, null, null, "ImageUrl 75", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4339), "Stars 75", "Title 75", "Writers 75" },
                    { 76, "Description 76", "Directors 76", 25, null, null, "ImageUrl 76", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4353), "Stars 76", "Title 76", "Writers 76" },
                    { 77, "Description 77", "Directors 77", 25, null, null, "ImageUrl 77", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4422), "Stars 77", "Title 77", "Writers 77" },
                    { 78, "Description 78", "Directors 78", 25, null, null, "ImageUrl 78", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4438), "Stars 78", "Title 78", "Writers 78" },
                    { 79, "Description 79", "Directors 79", 25, null, null, "ImageUrl 79", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4451), "Stars 79", "Title 79", "Writers 79" },
                    { 80, "Description 80", "Directors 80", 25, null, null, "ImageUrl 80", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4465), "Stars 80", "Title 80", "Writers 80" },
                    { 81, "Description 81", "Directors 81", 25, null, null, "ImageUrl 81", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4479), "Stars 81", "Title 81", "Writers 81" },
                    { 82, "Description 82", "Directors 82", 25, null, null, "ImageUrl 82", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4492), "Stars 82", "Title 82", "Writers 82" },
                    { 83, "Description 83", "Directors 83", 25, null, null, "ImageUrl 83", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4506), "Stars 83", "Title 83", "Writers 83" },
                    { 84, "Description 84", "Directors 84", 25, null, null, "ImageUrl 84", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4520), "Stars 84", "Title 84", "Writers 84" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Directors", "Discount", "DiscountEnd", "DiscountStart", "ImageUrl", "InStock", "IsOnSale", "Price", "ReleaseDate", "Stars", "Title", "Writers" },
                values: new object[,]
                {
                    { 85, "Description 85", "Directors 85", 25, null, null, "ImageUrl 85", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4533), "Stars 85", "Title 85", "Writers 85" },
                    { 86, "Description 86", "Directors 86", 25, null, null, "ImageUrl 86", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4548), "Stars 86", "Title 86", "Writers 86" },
                    { 87, "Description 87", "Directors 87", 25, null, null, "ImageUrl 87", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4561), "Stars 87", "Title 87", "Writers 87" },
                    { 88, "Description 88", "Directors 88", 25, null, null, "ImageUrl 88", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4575), "Stars 88", "Title 88", "Writers 88" },
                    { 89, "Description 89", "Directors 89", 25, null, null, "ImageUrl 89", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4589), "Stars 89", "Title 89", "Writers 89" },
                    { 90, "Description 90", "Directors 90", 25, null, null, "ImageUrl 90", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4649), "Stars 90", "Title 90", "Writers 90" },
                    { 91, "Description 91", "Directors 91", 25, null, null, "ImageUrl 91", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4664), "Stars 91", "Title 91", "Writers 91" },
                    { 92, "Description 92", "Directors 92", 25, null, null, "ImageUrl 92", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4678), "Stars 92", "Title 92", "Writers 92" },
                    { 93, "Description 93", "Directors 93", 25, null, null, "ImageUrl 93", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4692), "Stars 93", "Title 93", "Writers 93" },
                    { 94, "Description 94", "Directors 94", 25, null, null, "ImageUrl 94", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4707), "Stars 94", "Title 94", "Writers 94" },
                    { 95, "Description 95", "Directors 95", 25, null, null, "ImageUrl 95", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4720), "Stars 95", "Title 95", "Writers 95" },
                    { 96, "Description 96", "Directors 96", 25, null, null, "ImageUrl 96", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4734), "Stars 96", "Title 96", "Writers 96" },
                    { 97, "Description 97", "Directors 97", 25, null, null, "ImageUrl 97", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4748), "Stars 97", "Title 97", "Writers 97" },
                    { 98, "Description 98", "Directors 98", 25, null, null, "ImageUrl 98", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4762), "Stars 98", "Title 98", "Writers 98" },
                    { 99, "Description 99", "Directors 99", 25, null, null, "ImageUrl 99", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4775), "Stars 99", "Title 99", "Writers 99" },
                    { 100, "Description 100", "Directors 100", 25, null, null, "ImageUrl 100", 1, true, null, new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4790), "Stars 100", "Title 100", "Writers 100" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
