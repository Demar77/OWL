using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class EnglishPolish_ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnglishPolish",
                schema: "Owl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IPolishWord = table.Column<int>(nullable: false),
                    IdEnglishWord = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishPolish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnglishPolish_PolishWords_IPolishWord",
                        column: x => x.IPolishWord,
                        principalSchema: "Owl",
                        principalTable: "PolishWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnglishPolish_EnglishWords_IdEnglishWord",
                        column: x => x.IdEnglishWord,
                        principalSchema: "Owl",
                        principalTable: "EnglishWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleDetails_IdTranslation",
                schema: "Owl",
                table: "ArticleDetails",
                column: "IdTranslation");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishPolish_IPolishWord",
                schema: "Owl",
                table: "EnglishPolish",
                column: "IPolishWord");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishPolish_IdEnglishWord",
                schema: "Owl",
                table: "EnglishPolish",
                column: "IdEnglishWord");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleDetails_Translations_IdTranslation",
                schema: "Owl",
                table: "ArticleDetails",
                column: "IdTranslation",
                principalSchema: "Owl",
                principalTable: "Translations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleDetails_Translations_IdTranslation",
                schema: "Owl",
                table: "ArticleDetails");

            migrationBuilder.DropTable(
                name: "EnglishPolish",
                schema: "Owl");

            migrationBuilder.DropIndex(
                name: "IX_ArticleDetails_IdTranslation",
                schema: "Owl",
                table: "ArticleDetails");
        }
    }
}
