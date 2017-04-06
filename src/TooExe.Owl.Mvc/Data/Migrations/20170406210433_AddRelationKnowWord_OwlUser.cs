using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class AddRelationKnowWord_OwlUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwlUserId",
                schema: "Owl",
                table: "KnownWords",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KnownWords_OwlUserId",
                schema: "Owl",
                table: "KnownWords",
                column: "OwlUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_KnownWords_OwlUsers_OwlUserId",
                schema: "Owl",
                table: "KnownWords",
                column: "OwlUserId",
                principalSchema: "Owl",
                principalTable: "OwlUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KnownWords_OwlUsers_OwlUserId",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.DropIndex(
                name: "IX_KnownWords_OwlUserId",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.DropColumn(
                name: "OwlUserId",
                schema: "Owl",
                table: "KnownWords");
        }
    }
}
