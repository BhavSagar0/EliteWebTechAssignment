using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EliteWebTechAssignment.Domain.Models
{
    public class StudentMarksEntityModel
    {
        [Key]
        public int PkId { get; set; }
        public int studentId { get; set; }
        public int marks1 { get; set; }
        public int marks2 { get; set; }
        public int marks3 { get; set; }
    }
}
