﻿using EliteWebTechAssignment.DAL.DBContext;
using EliteWebTechAssignment.Domain.Interfaces;
using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EliteWebTechAssignment.DAL.RepositoryClasses
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _db;
        public StudentRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void CreateStudent(StudentEntityModel student)
        {
            try
            {
                _db.Students.Add(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ProgrammeEntityModel> GetAllProgrammes()
        {
            IEnumerable<ProgrammeEntityModel> programmeList = Enumerable.Empty<ProgrammeEntityModel>();
            try
            {
                programmeList = _db.Programmes.ToList();
            }
            catch(Exception)
            {
                throw;
            }
            return programmeList;
        }
        public int CreateProgramme(ProgrammeEntityModel programme)
        {
            int programmeId = 0;
            try
            {
                var programmeEntity = _db.Programmes.Add(programme);
                if(Save() > 0)
                    programmeId = programme.programmeId;
            }
            catch (Exception)
            {
                throw;
            }
            return programmeId;
        }
        public void AddProgrammeSubjects(int programmeId, IEnumerable<string> subjects)
        {
            try
            {
                foreach (var subject in subjects)
                {
                    SubjectEntityModel subjectToAdd = new SubjectEntityModel { programmeId = programmeId, subjectName = subject };
                    _db.ProgrammeSubjects.Add(subjectToAdd);
                }
            }
            catch { }
        }
        public IEnumerable<StudentEntityModel> GetAllStudents()
        {
            IEnumerable<StudentEntityModel> studentList = Enumerable.Empty<StudentEntityModel>();   
            try
            {
                studentList = _db.Students.ToList();
            }
            catch { }
            return studentList;
        }
        public void AddStudentIntakeYear(IntakeEntityModel intakeYearModel)
        {
            try
            {
                _db.Intakes.Add(intakeYearModel);
            }
            catch { }
        }
        public StudentEntityModel GetStudentById(int studentId)
        {
            StudentEntityModel student = new StudentEntityModel();
            try
            {
                student = _db.Students.Where(s => s.studentId == studentId).FirstOrDefault();
            }
            catch { }
            return student;
        }
        public void UpdateStudent(StudentEntityModel oldStudentObj, StudentEntityModel newStudentObj)
        {
            try
            {
                _db.Entry(oldStudentObj).CurrentValues.SetValues(newStudentObj);
            }
            catch { }
        }

        public void AddCurrentSem(CurrentSemEntityModel currentSem)
        {
            try
            {
                _db.CurrentSemesters.Add(currentSem);
            }
            catch { }
        }
        public int Save()
        {
            int result = 0;
            try
            {
                result = _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
