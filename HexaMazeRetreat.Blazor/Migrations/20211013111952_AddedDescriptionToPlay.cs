using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaMazeRetreat.Blazor.Migrations
{
    public partial class AddedDescriptionToPlay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PLAYS",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PLAYS");
        }
    }
}