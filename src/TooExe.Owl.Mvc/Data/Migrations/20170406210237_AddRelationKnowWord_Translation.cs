using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class AddRelationKnowWord_Translation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_KnownWords_IdKnownWord",
                schema: "Owl",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_IdKnownWord",
                schema: "Owl",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "IdKnownWord",
                schema: "Owl",
                table: "Translations");

            migrationBuilder.AddColumn<int>(
                name: "IdOwlUser",
                schema: "Owl",
                table: "KnownWords",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_KnownWords_IdTranslation",
                schema: "Owl",
                table: "KnownWords",
                column: "IdTranslation");

            migrationBuilder.AddForeignKey(
                name: "FK_KnownWords_Translations_IdTranslation",
                schema: "Owl",
                table: "KnownWords",
                column: "IdTranslation",
                principalSchema: "Owl",
                principalTable: "Translations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KnownWords_Translations_IdTranslation",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.DropIndex(
                name: "IX_KnownWords_IdTranslation",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.DropColumn(
                name: "IdOwlUser",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.AddColumn<int>(
                name: "IdKnownWord",
                schema: "Owl",
                table: "Translations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_IdKnownWord",
                schema: "Owl",
                table: "Translations",
                column: "IdKnownWord");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_KnownWords_IdKnownWord",
                schema: "Owl",
                table: "Translations",
                column: "IdKnownWord",
                principalSchema: "Owl",
                principalTable: "KnownWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
