using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class RemoveTable_EnglishPolish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KnownWords_OwlUsers_OwlUserId",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.DropTable(
                name: "EnglishPolish",
                schema: "Owl");

            migrationBuilder.DropIndex(
                name: "IX_KnownWords_OwlUserId",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.DropColumn(
                name: "IdEnglishWord",
                schema: "Owl",
                table: "PolishWords");

            migrationBuilder.DropColumn(
                name: "OwlUserId",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.CreateIndex(
                name: "IX_KnownWords_IdOwlUser",
                schema: "Owl",
                table: "KnownWords",
                column: "IdOwlUser");

            migrationBuilder.AddForeignKey(
                name: "FK_KnownWords_OwlUsers_IdOwlUser",
                schema: "Owl",
                table: "KnownWords",
                column: "IdOwlUser",
                principalSchema: "Owl",
                principalTable: "OwlUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KnownWords_OwlUsers_IdOwlUser",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.DropIndex(
                name: "IX_KnownWords_IdOwlUser",
                schema: "Owl",
                table: "KnownWords");

            migrationBuilder.AddColumn<int>(
                name: "IdEnglishWord",
                schema: "Owl",
                table: "PolishWords",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwlUserId",
                schema: "Owl",
                table: "KnownWords",
                nullable: true);

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
                name: "IX_KnownWords_OwlUserId",
                schema: "Owl",
                table: "KnownWords",
                column: "OwlUserId");

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
                name: "FK_KnownWords_OwlUsers_OwlUserId",
                schema: "Owl",
                table: "KnownWords",
                column: "OwlUserId",
                principalSchema: "Owl",
                principalTable: "OwlUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
