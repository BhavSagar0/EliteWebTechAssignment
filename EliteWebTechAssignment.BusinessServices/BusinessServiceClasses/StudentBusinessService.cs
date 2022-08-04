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
    }
}
