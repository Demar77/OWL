using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class Translation_PolishWord_EnglishWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Translations_IdEnglishWord",
                schema: "Owl",
                table: "Translations",
                column: "IdEnglishWord");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_IdPolishWord",
                schema: "Owl",
                table: "Translations",
                column: "IdPolishWord");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_EnglishWords_IdEnglishWord",
                schema: "Owl",
                table: "Translations",
                column: "IdEnglishWord",
                principalSchema: "Owl",
                principalTable: "EnglishWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_PolishWords_IdPolishWord",
                schema: "Owl",
                table: "Translations",
                column: "IdPolishWord",
                principalSchema: "Owl",
                principalTable: "PolishWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_EnglishWords_IdEnglishWord",
                schema: "Owl",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_PolishWords_IdPolishWord",
                schema: "Owl",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_IdEnglishWord",
                schema: "Owl",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_IdPolishWord",
                schema: "Owl",
                table: "Translations");
        }
    }
}
