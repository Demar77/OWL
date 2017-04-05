using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class NewSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OwlUser",
                table: "OwlUser");

            migrationBuilder.EnsureSchema(
                name: "Owl");

            migrationBuilder.RenameTable(
                name: "Translations",
                newSchema: "Owl");

            migrationBuilder.RenameTable(
                name: "PolishWords",
                newSchema: "Owl");

            migrationBuilder.RenameTable(
                name: "PlayListDetails",
                newSchema: "Owl");

            migrationBuilder.RenameTable(
                name: "PlayLists",
                newSchema: "Owl");

            migrationBuilder.RenameTable(
                name: "OwlUser",
                newName: "OwlUsers",
                newSchema: "Owl");

            migrationBuilder.RenameTable(
                name: "KnownWords",
                newSchema: "Owl");

            migrationBuilder.RenameTable(
                name: "EnglishWords",
                newSchema: "Owl");

            migrationBuilder.RenameTable(
                name: "ArticleDetails",
                newSchema: "Owl");

            migrationBuilder.RenameTable(
                name: "Articles",
                newSchema: "Owl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OwlUsers",
                schema: "Owl",
                table: "OwlUsers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OwlUsers",
                schema: "Owl",
                table: "OwlUsers");

            migrationBuilder.RenameTable(
                name: "Translations",
                schema: "Owl");

            migrationBuilder.RenameTable(
                name: "PolishWords",
                schema: "Owl");

            migrationBuilder.RenameTable(
                name: "PlayListDetails",
                schema: "Owl");

            migrationBuilder.RenameTable(
                name: "PlayLists",
                schema: "Owl");

            migrationBuilder.RenameTable(
                name: "OwlUsers",
                schema: "Owl",
                newName: "OwlUser");

            migrationBuilder.RenameTable(
                name: "KnownWords",
                schema: "Owl");

            migrationBuilder.RenameTable(
                name: "EnglishWords",
                schema: "Owl");

            migrationBuilder.RenameTable(
                name: "ArticleDetails",
                schema: "Owl");

            migrationBuilder.RenameTable(
                name: "Articles",
                schema: "Owl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OwlUser",
                table: "OwlUser",
                column: "Id");
        }
    }
}
