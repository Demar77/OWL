using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class PlayListDetail_Translation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PlayListDetails_IdTranslation",
                schema: "Owl",
                table: "PlayListDetails",
                column: "IdTranslation");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayListDetails_Translations_IdTranslation",
                schema: "Owl",
                table: "PlayListDetails",
                column: "IdTranslation",
                principalSchema: "Owl",
                principalTable: "Translations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayListDetails_Translations_IdTranslation",
                schema: "Owl",
                table: "PlayListDetails");

            migrationBuilder.DropIndex(
                name: "IX_PlayListDetails_IdTranslation",
                schema: "Owl",
                table: "PlayListDetails");
        }
    }
}
