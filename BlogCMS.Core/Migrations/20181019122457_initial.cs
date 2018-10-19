using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCMS.Core.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authorizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Cover = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: true),
                    ParentMenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    SiteTitle = table.Column<string>(nullable: true),
                    Slogan = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Tel1 = table.Column<string>(nullable: true),
                    Tel2 = table.Column<string>(nullable: true),
                    Gsm1 = table.Column<string>(nullable: true),
                    Gsm2 = table.Column<string>(nullable: true),
                    Mail1 = table.Column<string>(nullable: true),
                    Mail2 = table.Column<string>(nullable: true),
                    Fax1 = table.Column<string>(nullable: true),
                    Fax2 = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Il = table.Column<string>(nullable: true),
                    Ilce = table.Column<string>(nullable: true),
                    SMTPHost = table.Column<string>(nullable: true),
                    SMTPPort = table.Column<string>(nullable: true),
                    SMTPUser = table.Column<string>(nullable: true),
                    SMTPPassword = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    Youtube = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    Google = table.Column<string>(nullable: true),
                    Github = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Tumblr = table.Column<string>(nullable: true),
                    Flickr = table.Column<string>(nullable: true),
                    Reddit = table.Column<string>(nullable: true),
                    Snapchat = table.Column<string>(nullable: true),
                    Whatsapp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    AuthorizationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Authorizations_AuthorizationId",
                        column: x => x.AuthorizationId,
                        principalTable: "Authorizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Shortly = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Cover = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    MenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    PostId = table.Column<int>(nullable: true),
                    ParentCommentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Authorizations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local), null, "SuperAdmin", new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local) },
                    { 2, new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local), null, "Admin", new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local) },
                    { 3, new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local), null, "Author", new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Adres", "Copyright", "CreatedAt", "DeletedAt", "Description", "Facebook", "Fax1", "Fax2", "Flickr", "Github", "Google", "Gsm1", "Gsm2", "Il", "Ilce", "Instagram", "Linkedin", "Logo", "Mail1", "Mail2", "Pinterest", "Reddit", "SMTPHost", "SMTPPassword", "SMTPPort", "SMTPUser", "SiteTitle", "Slogan", "Snapchat", "Tel1", "Tel2", "Tumblr", "Twitter", "UpdatedAt", "Url", "Whatsapp", "Youtube" },
                values: new object[] { 1, "3.Defne Sok. Yeşilpınar Mah. No:5 Daire:3", "Ahmet Emin ŞİTe Aittir.", new DateTime(2018, 10, 19, 15, 24, 56, 834, DateTimeKind.Local), null, "Site Açıklaması Burada", "Facebook Adresiniz", "0000 000 0000", "0000 000 0000", "Flickr Adresiniz", "Github Adresiniz.", "Google Adresiniz.", "0546 245 9882", "0000 000 0000", "İstanbul", "Eyüpsultan", "Instagram Adresiniz.", "Linkedin Adresiniz.", "https://upload.wikimedia.org/wikipedia/commons/2/2f/Logo_TV_2015.svg.", "0000 000 0000", "0000 000 0000", "Pinterest Adresiniz.", "Reddit Adresiniz.", "Host", "Pass", "Port", "User", "Site Title", "Slogan Buraya", "Snapchat Adresiniz.", "0212 626 4707", "0000 000 0000", "Tumblr Adresiniz.", "Twitter Adresiniz.", new DateTime(2018, 10, 19, 15, 24, 56, 834, DateTimeKind.Local), "URL Buraya", "Whatsapp Adresiniz.", "Youtube Adresiniz." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthorizationId", "CreatedAt", "DeletedAt", "Email", "Name", "Password", "UpdatedAt" },
                values: new object[] { 1, 1, new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local), null, "sitahmetemin@gmail.com", "Ahmet Emin ŞİT", "123654", new DateTime(2018, 10, 19, 15, 24, 56, 836, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentCommentId",
                table: "Comments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentMenuId",
                table: "Menus",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_MenuId",
                table: "Posts",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AuthorizationId",
                table: "Users",
                column: "AuthorizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authorizations");
        }
    }
}
