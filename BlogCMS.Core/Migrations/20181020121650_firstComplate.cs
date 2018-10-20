using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCMS.Core.Migrations
{
    public partial class firstComplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultMenu",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DefaultSlider",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Posts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Lock",
                table: "Menus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Menus",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Menus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Menus",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Way = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: true),
                    PostId = table.Column<int>(nullable: true),
                    MenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Album_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Album_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local), new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local), new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local), new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Logo", "Mail1", "Mail2", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 20, 15, 16, 50, 275, DateTimeKind.Local), "https://upload.wikimedia.org/wikipedia/commons/2/2f/Logo_TV_2015.svg", "sitahmetemin@gmail.com", "sitahmetemin@hotmail.com", new DateTime(2018, 10, 20, 15, 16, 50, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local), new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Album_MenuId",
                table: "Album",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_PostId",
                table: "Album",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropColumn(
                name: "DefaultMenu",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "DefaultSlider",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Lock",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Menus");

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
                columns: new[] { "CreatedAt", "Logo", "Mail1", "Mail2", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 41, 56, 582, DateTimeKind.Local), "https://upload.wikimedia.org/wikipedia/commons/2/2f/Logo_TV_2015.svg.", "0000 000 0000", "0000 000 0000", new DateTime(2018, 10, 19, 15, 41, 56, 582, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local), new DateTime(2018, 10, 19, 15, 41, 56, 585, DateTimeKind.Local) });
        }
    }
}
