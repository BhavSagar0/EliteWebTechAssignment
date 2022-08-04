using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EliteWebTechAssignment.BusinessServices.ViewModels
{
    public class AddStudentIntakeYearViewModel
    {
        public IEnumerable<StudentEntityModel> students { get; set; }
        [Display(Name = "Intake Year")]
        public int intakeYear { get; set; }
        [Display(Name = "Student")]
        public int studentId { get; set; }
        public bool isSuccess { get; set; }
    }
}
