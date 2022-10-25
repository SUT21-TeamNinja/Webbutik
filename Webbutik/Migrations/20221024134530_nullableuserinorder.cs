using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webbutik.Migrations
{
    public partial class nullableuserinorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 15, 45, 29, 747, DateTimeKind.Local).AddTicks(2939));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
