using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCMS.Core.Migrations
{
    public partial class statusUpgrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Menus_MenuId",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Album_Posts_PostId",
                table: "Album");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Album",
                table: "Album");

            migrationBuilder.RenameTable(
                name: "Album",
                newName: "Albums");

            migrationBuilder.RenameIndex(
                name: "IX_Album_PostId",
                table: "Albums",
                newName: "IX_Albums_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Album_MenuId",
                table: "Albums",
                newName: "IX_Albums_MenuId");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Html = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Cover = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 22, 10, 52, 32, 56, DateTimeKind.Local), new DateTime(2018, 10, 22, 10, 52, 32, 56, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 22, 10, 52, 32, 56, DateTimeKind.Local), new DateTime(2018, 10, 22, 10, 52, 32, 56, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Authorizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 22, 10, 52, 32, 56, DateTimeKind.Local), new DateTime(2018, 10, 22, 10, 52, 32, 56, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Facebook", "Fax1", "Fax2", "Gsm2", "Instagram", "SiteTitle", "Tel2", "Twitter", "UpdatedAt", "Whatsapp", "Youtube" },
                values: new object[] { new DateTime(2018, 10, 22, 10, 52, 32, 53, DateTimeKind.Local), "https://www.facebook.com/sitahmetemin", "0546 245 9882", "0546 245 9882", "0546 245 9882", "https://www.instagram.com/sitahmetemin", "Site Title Buraya", "0212 626 4707", "https://twitter.com/sitahmetemin", new DateTime(2018, 10, 22, 10, 52, 32, 54, DateTimeKind.Local), "0546 245 9882", "https://www.youtube.com/c/ahmet%20emin%20%C5%9Fit" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 22, 10, 52, 32, 56, DateTimeKind.Local), 1, new DateTime(2018, 10, 22, 10, 52, 32, 56, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Menus_MenuId",
                table: "Albums",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Posts_PostId",
                table: "Albums",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Menus_MenuId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Posts_PostId",
                table: "Albums");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Album");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_PostId",
                table: "Album",
                newName: "IX_Album_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_MenuId",
                table: "Album",
                newName: "IX_Album_MenuId");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Album",
                table: "Album",
                column: "Id");

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
                columns: new[] { "CreatedAt", "Facebook", "Fax1", "Fax2", "Gsm2", "Instagram", "SiteTitle", "Tel2", "Twitter", "UpdatedAt", "Whatsapp", "Youtube" },
                values: new object[] { new DateTime(2018, 10, 20, 15, 16, 50, 275, DateTimeKind.Local), "Facebook Adresiniz", "0000 000 0000", "0000 000 0000", "0000 000 0000", "Instagram Adresiniz.", "Site Title", "0000 000 0000", "Twitter Adresiniz.", new DateTime(2018, 10, 20, 15, 16, 50, 275, DateTimeKind.Local), "Whatsapp Adresiniz.", "Youtube Adresiniz." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local), new DateTime(2018, 10, 20, 15, 16, 50, 278, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Menus_MenuId",
                table: "Album",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Posts_PostId",
                table: "Album",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
