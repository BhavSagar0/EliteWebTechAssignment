using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EliteWebTechAssignment.DAL.Migrations
{
    public partial class ProgrammeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "studentName",
                table: "Students",
                newName: "Student Name");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "Students",
                newName: "Student Id");

            migrationBuilder.CreateTable(
                name: "Programmes",
                columns: table => new
                {
                    ProgrammeId = table.Column<int>(name: "Programme Id", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProgrammeName = table.Column<string>(name: "Programme Name", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmes", x => x.ProgrammeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programmes");

            migrationBuilder.RenameColumn(
                name: "Student Name",
                table: "Students",
                newName: "studentName");

            migrationBuilder.RenameColumn(
                name: "Student Id",
                table: "Students",
                newName: "studentId");
        }
    }
}
