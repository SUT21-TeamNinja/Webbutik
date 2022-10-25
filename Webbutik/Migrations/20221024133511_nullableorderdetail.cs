using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webbutik.Migrations
{
    public partial class nullableorderdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Movies_MovieId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 35, 10, 730, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Movies_MovieId",
                table: "OrderDetails",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Movies_MovieId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 23, 6, 199, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Movies_MovieId",
                table: "OrderDetails",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
