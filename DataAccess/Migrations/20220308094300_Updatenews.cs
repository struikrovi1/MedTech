using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Updatenews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "News",
                newName: "CommentsCount");

            migrationBuilder.AddColumn<string>(
                name: "Article",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Article",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "CommentsCount",
                table: "News",
                newName: "Year");

            migrationBuilder.AddColumn<byte>(
                name: "Day",
                table: "News",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Month",
                table: "News",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
