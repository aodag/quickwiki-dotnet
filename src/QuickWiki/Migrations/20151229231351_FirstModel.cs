using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace QuickWiki.Migrations
{
    public partial class FirstModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WikiPage",
                columns: table => new
                {
                    WikiPageId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    Content = table.Column<string>(nullable: true),
                    PageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WikiPage", x => x.WikiPageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("WikiPage");
        }
    }
}
