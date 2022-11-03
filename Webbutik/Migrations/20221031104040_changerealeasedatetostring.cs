using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webbutik.Migrations
{
    public partial class changerealeasedatetostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImdbId",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImdbId",
                table: "Movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 1, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 2, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 3, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 4, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 5, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 6, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 7, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 8, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 9, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 10, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 11, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 12, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 13, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 14, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 15, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 16, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 17, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 18, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 19, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 20, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 21, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 22, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 23, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 24, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 25, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 26, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 27, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 28, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 29, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 30, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 31, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 32, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 33, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 34, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 35, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 36, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 37, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 38, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 39, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 40, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 41, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 42, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 43, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 44, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 45, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 46, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 47, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 48, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 49, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ImdbId", "ReleaseDate" },
                values: new object[] { 50, new DateTime(2022, 10, 31, 10, 50, 46, 973, DateTimeKind.Local).AddTicks(9319) });
        }
    }
}
