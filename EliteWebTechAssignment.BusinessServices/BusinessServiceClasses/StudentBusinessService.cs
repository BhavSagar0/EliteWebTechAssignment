using EliteWebTechAssignment.Domain.Interfaces;
using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EliteWebTechAssignment.BusinessServices.BusinessServiceClasses
{
    public class StudentBusinessService : IStudentBusinessService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentBusinessService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public bool CreateStudent(StudentEntityModel student)
        {
            bool result = false;
            try
            {
                _studentRepository.CreateStudent(student);
                result = Save() > 0 ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<ProgrammeEntityModel> GetAllProgrammes()
        {
            IEnumerable<ProgrammeEntityModel> programmes = Enumerable.Empty<ProgrammeEntityModel>();
            try
            {
                programmes = _studentRepository.GetAllProgrammes();
            }
            catch (Exception)
            {
                throw;
            }
            return programmes;
        }
        public bool CreateProgramme(ProgrammeEntityModel programme, IEnumerable<string> programmeSubjects)
        {
            bool result = false;
            try
            {
                int programmeId = _studentRepository.CreateProgramme(programme);
                if (programmeId > 0)
                {
                    _studentRepository.AddProgrammeSubjects(programmeId, programmeSubjects);
                }
                result = Save() > 0 ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public IEnumerable<StudentEntityModel> GetAllStudents()
        {
            IEnumerable<StudentEntityModel> students = Enumerable.Empty<StudentEntityModel>();
            try
            {
                students = _studentRepository.GetAllStudents();
            }
            catch { }
            return students;
        }
        public bool AddStudentIntakeYear(int studentId, int year)
        {
            bool result = false;
            try
            {
                IntakeEntityModel intakeYearModel = new IntakeEntityModel() { studentId = studentId, intakeYear = year };
                _studentRepository.AddStudentIntakeYear(intakeYearModel);
                result = Save() > 0 ? true : false;
            }
            catch { }
            return result;
            
        }
        public bool UpdateStudent(int studentId, int intakeYear, int currentSem, int programmeId)
        {
            bool result = false;
            try
            {
                bool updateStudentResult = false;
                StudentEntityModel oldStudentObj = _studentRepository.GetStudentById(studentId);
                StudentEntityModel newStudentObj = new StudentEntityModel() { studentId = studentId, programmeId = programmeId };
                if (oldStudentObj.programmeId != newStudentObj.programmeId && programmeId > 0)
                {
                    _studentRepository.UpdateStudent(oldStudentObj, newStudentObj);
                    updateStudentResult = Save() > 0 ? true : false;
                }
                else
                    updateStudentResult = true;
                    
                
                if (AddStudentIntakeYear(studentId, intakeYear) && updateStudentResult && AddCurrentSem(studentId, currentSem))
                    result = true;
            }
            catch { }
            return result;
        }
        public bool AddCurrentSem(int studentId, int currentSem)
        {
            bool result = false;
            try
            {
                CurrentSemEntityModel currentSemModel = new CurrentSemEntityModel() { studentId = studentId, currentSemester = currentSem };
                _studentRepository.AddCurrentSem(currentSemModel);
                result = Save() > 0 ? true : false;
            }
            catch { }
            return result;
        }
        public int Save()
        {
            int result = -1;
            try
            {
                result = _studentRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        
    }
}
