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
        public IEnumerable<StudentEntityModel> GetAllStudents(string searchString = "")
        {
            IEnumerable<StudentEntityModel> students = Enumerable.Empty<StudentEntityModel>();
            try
            {
                students = _studentRepository.GetAllStudents();
                if (!string.IsNullOrEmpty(searchString))
                {
                    students = students.Where(s => 
                    s.studentName.ToLower().Contains(searchString.ToLower()) || 
                    GetStudentProgramme(s.studentId).programmeName.ToLower().Contains(searchString.ToLower()) ||
                    s.collegeName.ToLower().Contains(searchString.ToLower()) ||
                    GetStudentIntakeYear(s.studentId).intakeYear.ToString().Equals(searchString.ToLower()) ||
                    GetStudentCurrentSem(s.studentId).currentSemester.ToString().Equals(searchString.ToLower())
                    ).ToList();
                }
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
        public IEnumerable<SubjectEntityModel> GetProgrammeSubjects(int programmeId)
        {
            IEnumerable<SubjectEntityModel> subjects = Enumerable.Empty<SubjectEntityModel>();
            try
            {
                subjects = _studentRepository.GetProgrammeSubjects(programmeId);
            }
            catch { }
            return subjects;
        }
        public IEnumerable<SubjectEntityModel> GetStudentProgrammeSubjects(int studentId)
        {
            IEnumerable<SubjectEntityModel> students = Enumerable.Empty<SubjectEntityModel>();
            try
            {
                students = GetProgrammeSubjects(_studentRepository.GetStudentById(studentId).programmeId);
            }
            catch { }
            return students;
        }
        public bool AddStudentMarks(int studentId, IEnumerable<int> marksList)
        {
            bool result = false;
            try
            {
                StudentMarksEntityModel studentMarks = new StudentMarksEntityModel()
                {
                    studentId = studentId,
                    marks1 = marksList.ElementAt(0),
                    marks2 = marksList.ElementAt(1),
                    marks3 = marksList.ElementAt(2),
                };
                _studentRepository.AddStudentMarks(studentMarks);
                result = Save() > 0 ? true : false;
            }
            catch { }
            return result;
        }
        public StudentEntityModel GetStudentbyId(int studentId)
        {
            StudentEntityModel student = new StudentEntityModel();
            try
            {
                student = _studentRepository.GetStudentById(studentId);
            }
            catch { }
            return student;
        }
        public StudentMarksEntityModel GetStudentMarks(int studentId)
        {
            StudentMarksEntityModel studentMarks = new StudentMarksEntityModel();
            try
            {
                studentMarks = _studentRepository.GetStudentMarks(studentId);
            }
            catch { }
            return studentMarks;
        }
        public CurrentSemEntityModel GetStudentCurrentSem(int studentId)
        {
            CurrentSemEntityModel currentSem = new CurrentSemEntityModel();
            try
            {
                currentSem = _studentRepository.GetStudentCurrentSem(studentId);
            }
            catch { }
            return currentSem;
        }

        public IntakeEntityModel GetStudentIntakeYear(int studentId)
        {
            IntakeEntityModel studentIntake = new IntakeEntityModel();
            try
            {
                studentIntake = _studentRepository.GetStudentIntakeYear(studentId);
            }
            catch { }
            return studentIntake;
        }
        public ProgrammeEntityModel GetStudentProgramme(int studentId)
        {
            ProgrammeEntityModel programme = new ProgrammeEntityModel();
            try
            {
                programme = _studentRepository.GetStudentProgramme(GetStudentbyId(studentId));
            }
            catch { }
            return programme;
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
