using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedDefaultUsers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2267e819-507f-42d5-bfd4-c7a3c51861c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "f73b394a-8553-4be1-abc5-68b54b9a1ac4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73bb9782-26cf-4be7-8348-230fa79bd65e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9f6db16-8656-4195-97bb-3297efc24e38", "AQAAAAEAACcQAAAAEI0D3oTtC4t5Ae8oM5CxPOYYAY65+hX+XGBYjdjGNyUPzvmRBegzeqif/18YnU9qRQ==", "fd3371b2-a886-4f4c-838e-d86cf4348bfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c14decb-8230-4191-b33e-6d0b0a8f8908", "AQAAAAEAACcQAAAAEJrX9+Qq1M/LKuQxVLCzWqnBdURSD7QG8g/JABzh+CEids6oLBqx6ItNW8dloWY7BQ==", "192ba02e-2407-490a-9121-f053f43f141d" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7597), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7635), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7751), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7754), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7812), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7815), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7818), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7820), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 6, "System", new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7823), new DateTime(2022, 2, 27, 19, 24, 9, 88, DateTimeKind.Local).AddTicks(7824), "525xd", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d3a47284-0218-4a10-b70a-4606c42e467f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "412c64f7-b652-4ad1-baba-a4222d88c451");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73bb9782-26cf-4be7-8348-230fa79bd65e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e705ddd7-b860-4ddf-b657-40791b20bf9c", "AQAAAAEAACcQAAAAEPRT90pIDyFS/Rm5ax9T3PNjIlrS1n1iQuSvrhWJinebULtVf4uCC8KjOdi590vctw==", "d4753bb5-69c9-4c8f-8463-85cf460dfcd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39453608-3cd0-48c8-984a-cd19c44041b5", "AQAAAAEAACcQAAAAEI1bN6a0Azl3J+v4Cg5QYbpAVU+lduXhIYFPHvGmFBeWecg7kI0vLmw+nYli6GlxMw==", "c633149e-9795-4cd6-8f24-1fc9096b083b" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7703), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7745), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7854), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7857), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7959), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7962), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7965), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7967), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 5, "System", new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7969), new DateTime(2022, 2, 27, 19, 14, 42, 277, DateTimeKind.Local).AddTicks(7971), "525xd", "System" });
        }
    }
}
