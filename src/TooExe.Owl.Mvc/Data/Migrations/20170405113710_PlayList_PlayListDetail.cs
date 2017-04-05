﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TooExe.Owl.Mvc.Migrations
{
    public partial class PlayList_PlayListDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PlayListDetails_IdPlayList",
                schema: "Owl",
                table: "PlayListDetails",
                column: "IdPlayList");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayListDetails_PlayLists_IdPlayList",
                schema: "Owl",
                table: "PlayListDetails",
                column: "IdPlayList",
                principalSchema: "Owl",
                principalTable: "PlayLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayListDetails_PlayLists_IdPlayList",
                schema: "Owl",
                table: "PlayListDetails");

            migrationBuilder.DropIndex(
                name: "IX_PlayListDetails_IdPlayList",
                schema: "Owl",
                table: "PlayListDetails");
        }
    }
}
