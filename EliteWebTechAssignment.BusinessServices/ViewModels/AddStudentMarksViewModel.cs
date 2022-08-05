using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EliteWebTechAssignment.BusinessServices.ViewModels
{
    public class AddStudentMarksViewModel
    {
        public int studentId { get; set; }
        [Display(Name = "Student Name")]
        [ReadOnly(true)]
        public string studentName { get; set; }
        public IEnumerable<SubjectEntityModel> subjectsList { get; set; }
        public int subject1 { get; set; }
        public int subject2 { get; set; }
        public int subject3 { get; set; }
        public bool isSuccess { get; set; }
    }
}
