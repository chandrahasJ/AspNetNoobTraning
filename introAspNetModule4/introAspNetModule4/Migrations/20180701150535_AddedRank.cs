using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace introAspNetModule4.Migrations
{
    public partial class AddedRank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "Album",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Album");
        }
    }
}
