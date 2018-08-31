using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class EdittedDirectorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Directors_DirectorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_DirectorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_DirectorId",
                table: "Books",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Directors_DirectorId",
                table: "Books",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
