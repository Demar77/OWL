using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class Article_PlayList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_IdDocument",
                schema: "Owl",
                table: "PlayLists",
                column: "IdDocument");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayLists_Articles_IdDocument",
                schema: "Owl",
                table: "PlayLists",
                column: "IdDocument",
                principalSchema: "Owl",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayLists_Articles_IdDocument",
                schema: "Owl",
                table: "PlayLists");

            migrationBuilder.DropIndex(
                name: "IX_PlayLists_IdDocument",
                schema: "Owl",
                table: "PlayLists");
        }
    }
}
