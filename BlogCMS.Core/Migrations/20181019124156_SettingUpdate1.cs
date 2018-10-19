using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCMS.Core.Migrations
{
    public partial class SettingUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Analytic",
                table: "Settings",
                newName: "Analystic");

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 41, 56, 582, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 41, 56, 582, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Analystic",
                table: "Settings",
                newName: "Analytic");

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 38, 20, 860, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 38, 20, 860, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local) });
        }
    }
}
