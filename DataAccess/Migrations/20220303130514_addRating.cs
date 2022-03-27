using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Ratings",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Ratings",
                newName: "Background");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ServiceId",
                table: "Ratings",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Services_ServiceId",
                table: "Ratings",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Services_ServiceId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_ServiceId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Ratings",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Background",
                table: "Ratings",
                newName: "Description");
        }
    }
}
