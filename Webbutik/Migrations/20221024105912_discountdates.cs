using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webbutik.Migrations
{
    public partial class discountdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DiscountEnd",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DiscountStart",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 59, 12, 419, DateTimeKind.Local).AddTicks(7881));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountEnd",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DiscountStart",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 24, 12, 48, 13, 513, DateTimeKind.Local).AddTicks(9385));
        }
    }
}
