using EliteWebTechAssignment.DAL.DBContext;
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
    }
}
