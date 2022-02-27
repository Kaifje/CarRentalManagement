using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedDefaultUsers3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "49bfffbe-bcc8-47b5-a715-a67150dcca80");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "e3b19db2-bbb7-45fc-9362-53d7d6592f88");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73bb9782-26cf-4be7-8348-230fa79bd65e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a761fd19-1001-4dd0-b472-b3b7c261d1ce", "AQAAAAEAACcQAAAAEKJbsJgG5I4xKTHe4IZKOoe/9t1e2Mhvdux9E9i/voGLgVr2Xe8b2MgousB1V334qQ==", "4f54de6c-0b9f-45e4-8f41-ccb3db5d44d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efcb4674-9b22-4d92-9813-b5de24279f54", "AQAAAAEAACcQAAAAEIDgLUW45qZ362Rigtueg5HoPB36mr8zZCUx/fQZpeVGi5V7GXAirZf8y8QRtj7Dew==", "68c4b33c-f21d-4959-b3ad-40b3967a772d" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5792), new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5907), new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5963), new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5967), new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5972), new DateTime(2022, 2, 27, 19, 24, 50, 439, DateTimeKind.Local).AddTicks(5973) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
