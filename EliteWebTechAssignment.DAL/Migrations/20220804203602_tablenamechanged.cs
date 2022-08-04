using Microsoft.EntityFrameworkCore.Migrations;

namespace EliteWebTechAssignment.DAL.Migrations
{
    public partial class tablenamechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrentSemYear",
                table: "CurrentSemYear");

            migrationBuilder.RenameTable(
                name: "CurrentSemYear",
                newName: "CurrentSemesters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrentSemesters",
                table: "CurrentSemesters",
                column: "PkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrentSemesters",
                table: "CurrentSemesters");

            migrationBuilder.RenameTable(
                name: "CurrentSemesters",
                newName: "CurrentSemYear");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrentSemYear",
                table: "CurrentSemYear",
                column: "PkId");
        }
    }
}
