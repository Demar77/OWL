using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class Article_ArticleDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ArticleDetails_IdArticle",
                schema: "Owl",
                table: "ArticleDetails",
                column: "IdArticle");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleDetails_Articles_IdArticle",
                schema: "Owl",
                table: "ArticleDetails",
                column: "IdArticle",
                principalSchema: "Owl",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleDetails_Articles_IdArticle",
                schema: "Owl",
                table: "ArticleDetails");

            migrationBuilder.DropIndex(
                name: "IX_ArticleDetails_IdArticle",
                schema: "Owl",
                table: "ArticleDetails");
        }
    }
}
