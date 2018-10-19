using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCMS.Core.Migrations
{
    public partial class initialEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 28, 9, 761, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 28, 9, 761, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 24, 56, 834, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 24, 56, 834, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local) });
        }
    }
}
