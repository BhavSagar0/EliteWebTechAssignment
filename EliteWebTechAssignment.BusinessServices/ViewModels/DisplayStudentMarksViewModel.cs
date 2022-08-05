using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteWebTechAssignment.BusinessServices.ViewModels
{
    public class DisplayStudentMarksViewModel
    {
        public StudentEntityModel student { get; set; }
        public CurrentSemEntityModel currentSem { get; set; }
        public IntakeEntityModel intakeYear { get; set; }
        public List<SubjectEntityModel> subjectsList { get; set; }
        public StudentMarksEntityModel marksList { get; set; }
        public ProgrammeEntityModel programme { get; set; }

    }
}
