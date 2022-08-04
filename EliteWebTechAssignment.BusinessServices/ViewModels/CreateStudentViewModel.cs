using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteWebTechAssignment.BusinessServices.ViewModels
{
    public class CreateStudentViewModel
    {
        public IEnumerable<ProgrammeEntityModel> programmeList { get; set; }
    }
}
