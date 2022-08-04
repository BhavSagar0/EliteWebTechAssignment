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
        int Save();
    }
}
