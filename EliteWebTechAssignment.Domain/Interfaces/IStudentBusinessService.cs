using EliteWebTechAssignment.Domain.Models;
using System.Collections.Generic;

namespace EliteWebTechAssignment.Domain.Interfaces
{
    public interface IStudentBusinessService
    {
        IEnumerable<StudentEntityModel> GetAllStudents(string searchString);
        bool CreateStudent(StudentEntityModel student);
        IEnumerable<ProgrammeEntityModel> GetAllProgrammes();
        bool CreateProgramme(ProgrammeEntityModel programme, IEnumerable<string> programmeSubjects);
        bool UpdateStudent(int studentId, int intakeYear, int currentSem, int programmeId);
        bool AddStudentIntakeYear(int studentId, int year);
        bool AddCurrentSem(int studentId, int currentSem);
        IEnumerable<SubjectEntityModel> GetProgrammeSubjects(int programmeId);
        IEnumerable<SubjectEntityModel> GetStudentProgrammeSubjects(int studentId);
        bool AddStudentMarks(int studentId, IEnumerable<int> marksList);
        StudentEntityModel GetStudentbyId(int studentId);
        StudentMarksEntityModel GetStudentMarks(int studentId);
        CurrentSemEntityModel GetStudentCurrentSem(int studentId);
        IntakeEntityModel GetStudentIntakeYear(int studentId);
        ProgrammeEntityModel GetStudentProgramme(int studentId);
        int Save();
    }
}
