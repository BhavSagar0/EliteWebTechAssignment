using Microsoft.EntityFrameworkCore.Migrations;

namespace EliteWebTechAssignment.DAL.Migrations
{
    public partial class currentYearRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentYear",
                table: "CurrentSemYear");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentYear",
                table: "CurrentSemYear",
                nullable: false,
                defaultValue: 0);
        }
    }
}
