using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCMS.Core.Migrations
{
    public partial class SettingUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ilce",
                table: "Settings",
                newName: "Recapctha");

            migrationBuilder.RenameColumn(
                name: "Il",
                table: "Settings",
                newName: "Province");

            migrationBuilder.RenameColumn(
                name: "Adres",
                table: "Settings",
                newName: "Maps");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Analytic",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Settings",
                nullable: true);

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
                columns: new[] { "Address", "Analytic", "Country", "CreatedAt", "Maps", "Province", "Recapctha", "UpdatedAt" },
                values: new object[] { "3.Defne Sok. Yeşilpınar Mah. No:5 Daire:3", "Google Analytic", "İstanbul", new DateTime(2018, 10, 19, 15, 38, 20, 860, DateTimeKind.Local), "Google Maps", "Eyüpsultan", "Google Recapctha", new DateTime(2018, 10, 19, 15, 38, 20, 860, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 38, 20, 862, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Analytic",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Settings");

            migrationBuilder.RenameColumn(
                name: "Recapctha",
                table: "Settings",
                newName: "Ilce");

            migrationBuilder.RenameColumn(
                name: "Province",
                table: "Settings",
                newName: "Il");

            migrationBuilder.RenameColumn(
                name: "Maps",
                table: "Settings",
                newName: "Adres");

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
                columns: new[] { "Adres", "CreatedAt", "Il", "Ilce", "UpdatedAt" },
                values: new object[] { "3.Defne Sok. Yeşilpınar Mah. No:5 Daire:3", new DateTime(2018, 10, 19, 15, 28, 9, 761, DateTimeKind.Local), "İstanbul", "Eyüpsultan", new DateTime(2018, 10, 19, 15, 28, 9, 761, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 28, 9, 763, DateTimeKind.Local) });
        }
    }
}
