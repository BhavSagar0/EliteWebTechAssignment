using EliteWebTechAssignment.Domain.Models;
using System.Collections.Generic;

namespace EliteWebTechAssignment.Domain.Interfaces
{
    public interface IStudentBusinessService
    {
        IEnumerable<StudentEntityModel> GetAllStudents();
        bool CreateStudent(StudentEntityModel student);
        IEnumerable<ProgrammeEntityModel> GetAllProgrammes();
        bool CreateProgramme(ProgrammeEntityModel programme, IEnumerable<string> programmeSubjects);
        bool AddStudentIntakeYear(int studentId, int year);
        int Save();
    }
}
