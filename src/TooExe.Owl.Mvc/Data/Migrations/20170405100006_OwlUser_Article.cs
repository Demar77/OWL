using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class OwlUser_Article : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProfile",
                schema: "Owl",
                table: "Articles",
                newName: "IdOwlUser");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_IdOwlUser",
                schema: "Owl",
                table: "Articles",
                column: "IdOwlUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_OwlUsers_IdOwlUser",
                schema: "Owl",
                table: "Articles",
                column: "IdOwlUser",
                principalSchema: "Owl",
                principalTable: "OwlUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_OwlUsers_IdOwlUser",
                schema: "Owl",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_IdOwlUser",
                schema: "Owl",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "IdOwlUser",
                schema: "Owl",
                table: "Articles",
                newName: "IdProfile");
        }
    }
}
