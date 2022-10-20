using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webbutik.Migrations
{
    public partial class PHmovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Directors", "Discount", "ImageUrl", "InStock", "IsOnSale", "ReleaseDate", "Stars", "Title", "Writers" },
                values: new object[] { "Description 1", "Directors 1", 25, "ImageUrl 1", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(2843), "Stars 1", "Title 1", "Writers 1" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Directors", "Discount", "ImageUrl", "InStock", "IsOnSale", "ReleaseDate", "Stars", "Title", "Writers" },
                values: new object[,]
                {
                    { 2, "Description 2", "Directors 2", 25, "ImageUrl 2", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(2909), "Stars 2", "Title 2", "Writers 2" },
                    { 3, "Description 3", "Directors 3", 25, "ImageUrl 3", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(2923), "Stars 3", "Title 3", "Writers 3" },
                    { 4, "Description 4", "Directors 4", 25, "ImageUrl 4", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(2935), "Stars 4", "Title 4", "Writers 4" },
                    { 5, "Description 5", "Directors 5", 25, "ImageUrl 5", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(2947), "Stars 5", "Title 5", "Writers 5" },
                    { 6, "Description 6", "Directors 6", 25, "ImageUrl 6", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3009), "Stars 6", "Title 6", "Writers 6" },
                    { 7, "Description 7", "Directors 7", 25, "ImageUrl 7", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3025), "Stars 7", "Title 7", "Writers 7" },
                    { 8, "Description 8", "Directors 8", 25, "ImageUrl 8", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3037), "Stars 8", "Title 8", "Writers 8" },
                    { 9, "Description 9", "Directors 9", 25, "ImageUrl 9", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3048), "Stars 9", "Title 9", "Writers 9" },
                    { 10, "Description 10", "Directors 10", 25, "ImageUrl 10", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3063), "Stars 10", "Title 10", "Writers 10" },
                    { 11, "Description 11", "Directors 11", 25, "ImageUrl 11", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3075), "Stars 11", "Title 11", "Writers 11" },
                    { 12, "Description 12", "Directors 12", 25, "ImageUrl 12", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3087), "Stars 12", "Title 12", "Writers 12" },
                    { 13, "Description 13", "Directors 13", 25, "ImageUrl 13", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3098), "Stars 13", "Title 13", "Writers 13" },
                    { 14, "Description 14", "Directors 14", 25, "ImageUrl 14", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3111), "Stars 14", "Title 14", "Writers 14" },
                    { 15, "Description 15", "Directors 15", 25, "ImageUrl 15", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3122), "Stars 15", "Title 15", "Writers 15" },
                    { 16, "Description 16", "Directors 16", 25, "ImageUrl 16", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3134), "Stars 16", "Title 16", "Writers 16" },
                    { 17, "Description 17", "Directors 17", 25, "ImageUrl 17", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3147), "Stars 17", "Title 17", "Writers 17" },
                    { 18, "Description 18", "Directors 18", 25, "ImageUrl 18", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3159), "Stars 18", "Title 18", "Writers 18" },
                    { 19, "Description 19", "Directors 19", 25, "ImageUrl 19", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3217), "Stars 19", "Title 19", "Writers 19" },
                    { 20, "Description 20", "Directors 20", 25, "ImageUrl 20", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3231), "Stars 20", "Title 20", "Writers 20" },
                    { 21, "Description 21", "Directors 21", 25, "ImageUrl 21", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3243), "Stars 21", "Title 21", "Writers 21" },
                    { 22, "Description 22", "Directors 22", 25, "ImageUrl 22", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3254), "Stars 22", "Title 22", "Writers 22" },
                    { 23, "Description 23", "Directors 23", 25, "ImageUrl 23", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3267), "Stars 23", "Title 23", "Writers 23" },
                    { 24, "Description 24", "Directors 24", 25, "ImageUrl 24", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3279), "Stars 24", "Title 24", "Writers 24" },
                    { 25, "Description 25", "Directors 25", 25, "ImageUrl 25", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3291), "Stars 25", "Title 25", "Writers 25" },
                    { 26, "Description 26", "Directors 26", 25, "ImageUrl 26", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3303), "Stars 26", "Title 26", "Writers 26" },
                    { 27, "Description 27", "Directors 27", 25, "ImageUrl 27", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3314), "Stars 27", "Title 27", "Writers 27" },
                    { 28, "Description 28", "Directors 28", 25, "ImageUrl 28", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3326), "Stars 28", "Title 28", "Writers 28" },
                    { 29, "Description 29", "Directors 29", 25, "ImageUrl 29", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3337), "Stars 29", "Title 29", "Writers 29" },
                    { 30, "Description 30", "Directors 30", 25, "ImageUrl 30", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3350), "Stars 30", "Title 30", "Writers 30" },
                    { 31, "Description 31", "Directors 31", 25, "ImageUrl 31", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3361), "Stars 31", "Title 31", "Writers 31" },
                    { 32, "Description 32", "Directors 32", 25, "ImageUrl 32", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3373), "Stars 32", "Title 32", "Writers 32" },
                    { 33, "Description 33", "Directors 33", 25, "ImageUrl 33", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3447), "Stars 33", "Title 33", "Writers 33" },
                    { 34, "Description 34", "Directors 34", 25, "ImageUrl 34", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3462), "Stars 34", "Title 34", "Writers 34" },
                    { 35, "Description 35", "Directors 35", 25, "ImageUrl 35", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3474), "Stars 35", "Title 35", "Writers 35" },
                    { 36, "Description 36", "Directors 36", 25, "ImageUrl 36", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3486), "Stars 36", "Title 36", "Writers 36" },
                    { 37, "Description 37", "Directors 37", 25, "ImageUrl 37", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3498), "Stars 37", "Title 37", "Writers 37" },
                    { 38, "Description 38", "Directors 38", 25, "ImageUrl 38", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3509), "Stars 38", "Title 38", "Writers 38" },
                    { 39, "Description 39", "Directors 39", 25, "ImageUrl 39", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3521), "Stars 39", "Title 39", "Writers 39" },
                    { 40, "Description 40", "Directors 40", 25, "ImageUrl 40", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3533), "Stars 40", "Title 40", "Writers 40" },
                    { 41, "Description 41", "Directors 41", 25, "ImageUrl 41", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3545), "Stars 41", "Title 41", "Writers 41" },
                    { 42, "Description 42", "Directors 42", 25, "ImageUrl 42", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3556), "Stars 42", "Title 42", "Writers 42" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Directors", "Discount", "ImageUrl", "InStock", "IsOnSale", "ReleaseDate", "Stars", "Title", "Writers" },
                values: new object[,]
                {
                    { 43, "Description 43", "Directors 43", 25, "ImageUrl 43", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3569), "Stars 43", "Title 43", "Writers 43" },
                    { 44, "Description 44", "Directors 44", 25, "ImageUrl 44", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3580), "Stars 44", "Title 44", "Writers 44" },
                    { 45, "Description 45", "Directors 45", 25, "ImageUrl 45", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3592), "Stars 45", "Title 45", "Writers 45" },
                    { 46, "Description 46", "Directors 46", 25, "ImageUrl 46", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3644), "Stars 46", "Title 46", "Writers 46" },
                    { 47, "Description 47", "Directors 47", 25, "ImageUrl 47", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3656), "Stars 47", "Title 47", "Writers 47" },
                    { 48, "Description 48", "Directors 48", 25, "ImageUrl 48", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3668), "Stars 48", "Title 48", "Writers 48" },
                    { 49, "Description 49", "Directors 49", 25, "ImageUrl 49", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3680), "Stars 49", "Title 49", "Writers 49" },
                    { 50, "Description 50", "Directors 50", 25, "ImageUrl 50", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3691), "Stars 50", "Title 50", "Writers 50" },
                    { 51, "Description 51", "Directors 51", 25, "ImageUrl 51", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3703), "Stars 51", "Title 51", "Writers 51" },
                    { 52, "Description 52", "Directors 52", 25, "ImageUrl 52", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3715), "Stars 52", "Title 52", "Writers 52" },
                    { 53, "Description 53", "Directors 53", 25, "ImageUrl 53", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3727), "Stars 53", "Title 53", "Writers 53" },
                    { 54, "Description 54", "Directors 54", 25, "ImageUrl 54", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3738), "Stars 54", "Title 54", "Writers 54" },
                    { 55, "Description 55", "Directors 55", 25, "ImageUrl 55", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3750), "Stars 55", "Title 55", "Writers 55" },
                    { 56, "Description 56", "Directors 56", 25, "ImageUrl 56", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3761), "Stars 56", "Title 56", "Writers 56" },
                    { 57, "Description 57", "Directors 57", 25, "ImageUrl 57", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3773), "Stars 57", "Title 57", "Writers 57" },
                    { 58, "Description 58", "Directors 58", 25, "ImageUrl 58", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3784), "Stars 58", "Title 58", "Writers 58" },
                    { 59, "Description 59", "Directors 59", 25, "ImageUrl 59", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3832), "Stars 59", "Title 59", "Writers 59" },
                    { 60, "Description 60", "Directors 60", 25, "ImageUrl 60", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3845), "Stars 60", "Title 60", "Writers 60" },
                    { 61, "Description 61", "Directors 61", 25, "ImageUrl 61", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3857), "Stars 61", "Title 61", "Writers 61" },
                    { 62, "Description 62", "Directors 62", 25, "ImageUrl 62", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3868), "Stars 62", "Title 62", "Writers 62" },
                    { 63, "Description 63", "Directors 63", 25, "ImageUrl 63", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3880), "Stars 63", "Title 63", "Writers 63" },
                    { 64, "Description 64", "Directors 64", 25, "ImageUrl 64", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3892), "Stars 64", "Title 64", "Writers 64" },
                    { 65, "Description 65", "Directors 65", 25, "ImageUrl 65", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3903), "Stars 65", "Title 65", "Writers 65" },
                    { 66, "Description 66", "Directors 66", 25, "ImageUrl 66", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3917), "Stars 66", "Title 66", "Writers 66" },
                    { 67, "Description 67", "Directors 67", 25, "ImageUrl 67", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3928), "Stars 67", "Title 67", "Writers 67" },
                    { 68, "Description 68", "Directors 68", 25, "ImageUrl 68", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3941), "Stars 68", "Title 68", "Writers 68" },
                    { 69, "Description 69", "Directors 69", 25, "ImageUrl 69", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3952), "Stars 69", "Title 69", "Writers 69" },
                    { 70, "Description 70", "Directors 70", 25, "ImageUrl 70", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(3964), "Stars 70", "Title 70", "Writers 70" },
                    { 71, "Description 71", "Directors 71", 25, "ImageUrl 71", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4016), "Stars 71", "Title 71", "Writers 71" },
                    { 72, "Description 72", "Directors 72", 25, "ImageUrl 72", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4028), "Stars 72", "Title 72", "Writers 72" },
                    { 73, "Description 73", "Directors 73", 25, "ImageUrl 73", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4040), "Stars 73", "Title 73", "Writers 73" },
                    { 74, "Description 74", "Directors 74", 25, "ImageUrl 74", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4052), "Stars 74", "Title 74", "Writers 74" },
                    { 75, "Description 75", "Directors 75", 25, "ImageUrl 75", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4064), "Stars 75", "Title 75", "Writers 75" },
                    { 76, "Description 76", "Directors 76", 25, "ImageUrl 76", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4075), "Stars 76", "Title 76", "Writers 76" },
                    { 77, "Description 77", "Directors 77", 25, "ImageUrl 77", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4087), "Stars 77", "Title 77", "Writers 77" },
                    { 78, "Description 78", "Directors 78", 25, "ImageUrl 78", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4099), "Stars 78", "Title 78", "Writers 78" },
                    { 79, "Description 79", "Directors 79", 25, "ImageUrl 79", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4111), "Stars 79", "Title 79", "Writers 79" },
                    { 80, "Description 80", "Directors 80", 25, "ImageUrl 80", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4122), "Stars 80", "Title 80", "Writers 80" },
                    { 81, "Description 81", "Directors 81", 25, "ImageUrl 81", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4134), "Stars 81", "Title 81", "Writers 81" },
                    { 82, "Description 82", "Directors 82", 25, "ImageUrl 82", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4146), "Stars 82", "Title 82", "Writers 82" },
                    { 83, "Description 83", "Directors 83", 25, "ImageUrl 83", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4157), "Stars 83", "Title 83", "Writers 83" },
                    { 84, "Description 84", "Directors 84", 25, "ImageUrl 84", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4169), "Stars 84", "Title 84", "Writers 84" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Directors", "Discount", "ImageUrl", "InStock", "IsOnSale", "ReleaseDate", "Stars", "Title", "Writers" },
                values: new object[,]
                {
                    { 85, "Description 85", "Directors 85", 25, "ImageUrl 85", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4221), "Stars 85", "Title 85", "Writers 85" },
                    { 86, "Description 86", "Directors 86", 25, "ImageUrl 86", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4233), "Stars 86", "Title 86", "Writers 86" },
                    { 87, "Description 87", "Directors 87", 25, "ImageUrl 87", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4244), "Stars 87", "Title 87", "Writers 87" },
                    { 88, "Description 88", "Directors 88", 25, "ImageUrl 88", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4256), "Stars 88", "Title 88", "Writers 88" },
                    { 89, "Description 89", "Directors 89", 25, "ImageUrl 89", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4268), "Stars 89", "Title 89", "Writers 89" },
                    { 90, "Description 90", "Directors 90", 25, "ImageUrl 90", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4279), "Stars 90", "Title 90", "Writers 90" },
                    { 91, "Description 91", "Directors 91", 25, "ImageUrl 91", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4291), "Stars 91", "Title 91", "Writers 91" },
                    { 92, "Description 92", "Directors 92", 25, "ImageUrl 92", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4303), "Stars 92", "Title 92", "Writers 92" },
                    { 93, "Description 93", "Directors 93", 25, "ImageUrl 93", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4315), "Stars 93", "Title 93", "Writers 93" },
                    { 94, "Description 94", "Directors 94", 25, "ImageUrl 94", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4326), "Stars 94", "Title 94", "Writers 94" },
                    { 95, "Description 95", "Directors 95", 25, "ImageUrl 95", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4337), "Stars 95", "Title 95", "Writers 95" },
                    { 96, "Description 96", "Directors 96", 25, "ImageUrl 96", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4349), "Stars 96", "Title 96", "Writers 96" },
                    { 97, "Description 97", "Directors 97", 25, "ImageUrl 97", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4360), "Stars 97", "Title 97", "Writers 97" },
                    { 98, "Description 98", "Directors 98", 25, "ImageUrl 98", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4409), "Stars 98", "Title 98", "Writers 98" },
                    { 99, "Description 99", "Directors 99", 25, "ImageUrl 99", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4422), "Stars 99", "Title 99", "Writers 99" },
                    { 100, "Description 100", "Directors 100", 25, "ImageUrl 100", 1, true, new DateTime(2022, 10, 20, 8, 23, 36, 76, DateTimeKind.Local).AddTicks(4435), "Stars 100", "Title 100", "Writers 100" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Directors", "Discount", "ImageUrl", "InStock", "IsOnSale", "ReleaseDate", "Stars", "Title", "Writers" },
                values: new object[] { null, null, null, null, null, null, null, null, "PH", null });
        }
    }
}
