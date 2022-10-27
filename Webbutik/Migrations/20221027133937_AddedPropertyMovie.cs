using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webbutik.Migrations
{
    public partial class AddedPropertyMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "Movies",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 15, 39, 36, 380, DateTimeKind.Local).AddTicks(7992));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 27, 14, 3, 57, 715, DateTimeKind.Local).AddTicks(4790));
        }
    }
}
