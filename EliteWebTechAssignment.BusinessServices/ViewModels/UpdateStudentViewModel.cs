using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EliteWebTechAssignment.BusinessServices.ViewModels
{
    public class UpdateStudentViewModel
    {
        [Display(Name = "Student Name")]
        public int studentId { get; set; }
        [Display(Name = "Intake Year")]
        public int intakeYear { get; set; }
        [Display(Name = "Current Semester")]
        public int currentSem { get; set; }
        [Display(Name = "Programme")]
        public int programmeId { get; set; }
        public bool isSuccess { get; set; }
        public IEnumerable<StudentEntityModel> studentsList { get; set; }
        public IEnumerable<ProgrammeEntityModel> programmesList { get; set; }
    }
}
