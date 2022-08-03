using Microsoft.EntityFrameworkCore.Migrations;

namespace EliteWebTechAssignment.DAL.Migrations
{
    public partial class ColumnNamesCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Student Name",
                table: "Students",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "Student Id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Programme Name",
                table: "Programmes",
                newName: "ProgrammeName");

            migrationBuilder.RenameColumn(
                name: "Programme Id",
                table: "Programmes",
                newName: "ProgrammeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Student Name");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "Student Id");

            migrationBuilder.RenameColumn(
                name: "ProgrammeName",
                table: "Programmes",
                newName: "Programme Name");

            migrationBuilder.RenameColumn(
                name: "ProgrammeId",
                table: "Programmes",
                newName: "Programme Id");
        }
    }
}
