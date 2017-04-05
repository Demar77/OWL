using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class ArticleDetails_Translation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEnglishWord",
                schema: "Owl",
                table: "ArticleDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArticleDetails_IdEnglishWord",
                schema: "Owl",
                table: "ArticleDetails",
                column: "IdEnglishWord");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleDetails_Translations_IdEnglishWord",
                schema: "Owl",
                table: "ArticleDetails",
                column: "IdEnglishWord",
                principalSchema: "Owl",
                principalTable: "Translations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleDetails_Translations_IdEnglishWord",
                schema: "Owl",
                table: "ArticleDetails");

            migrationBuilder.DropIndex(
                name: "IX_ArticleDetails_IdEnglishWord",
                schema: "Owl",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "IdEnglishWord",
                schema: "Owl",
                table: "ArticleDetails");
        }
    }
}
