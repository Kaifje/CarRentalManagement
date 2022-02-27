using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39453608-3cd0-48c8-984a-cd19c44041b5", "AQAAAAEAACcQAAAAEI1bN6a0Azl3J+v4Cg5QYbpAVU+lduXhIYFPHvGmFBeWecg7kI0vLmw+nYli6GlxMw==", "c633149e-9795-4cd6-8f24-1fc9096b083b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "73bb9782-26cf-4be7-8348-230fa79bd65e", 0, "e705ddd7-b860-4ddf-b657-40791b20bf9c", "kai@midnightunit.com", false, "System", "User", false, null, "KAI@MIDNIGHTUNIT.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPRT90pIDyFS/Rm5ax9T3PNjIlrS1n1iQuSvrhWJinebULtVf4uCC8KjOdi590vctw==", null, false, "d4753bb5-69c9-4c8f-8463-85cf460dfcd8", false, "user@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "73bb9782-26cf-4be7-8348-230fa79bd65e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "73bb9782-26cf-4be7-8348-230fa79bd65e" });

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73bb9782-26cf-4be7-8348-230fa79bd65e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e2bc3a5a-1e95-4710-bb19-915312327cbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "f17f0ffc-0b0c-4383-8547-475534031ebd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e4f202-bb5b-47ab-9057-111fe537877d", "AQAAAAEAACcQAAAAEOOmf4yxUTmT8CO7MNIYP8EF0J5IlyA95dW2kcCMEHKOJqYkD67OKC2NAcX5WFJY2Q==", "5520a4e1-18a1-4f0e-846d-f208009ca45e" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(505), new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(545), new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(652), new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(656), new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(709), new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(712), new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(715), new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(717), new DateTime(2021, 12, 27, 13, 7, 49, 41, DateTimeKind.Local).AddTicks(718) });
        }
    }
}
