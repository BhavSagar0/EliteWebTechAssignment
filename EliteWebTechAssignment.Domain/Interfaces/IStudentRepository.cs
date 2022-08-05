using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteWebTechAssignment.Domain.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<StudentEntityModel> GetAllStudents();
        void CreateStudent(StudentEntityModel student);
        IEnumerable<ProgrammeEntityModel> GetAllProgrammes();
        int CreateProgramme(ProgrammeEntityModel programme);
        void AddProgrammeSubjects(int programmeId, IEnumerable<string> subjects);
        void AddStudentIntakeYear(IntakeEntityModel intakeYearModel);
        StudentEntityModel GetStudentById(int studentId);
        void UpdateStudent(StudentEntityModel oldStudentObj, StudentEntityModel newStudentObj);
        void AddCurrentSem(CurrentSemEntityModel currentSem);
        IEnumerable<SubjectEntityModel> GetProgrammeSubjects(int programmeId);
        void AddStudentMarks(StudentMarksEntityModel studentMarks);
        StudentEntityModel GetStudentbyId(int studentId);
        StudentMarksEntityModel GetStudentMarks(int studentId);
        CurrentSemEntityModel GetStudentCurrentSem(int studentId);
        IntakeEntityModel GetStudentIntakeYear(int studentId);
        ProgrammeEntityModel GetStudentProgramme(StudentEntityModel student);
        int Save();
    }
}
