using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EliteWebTechAssignment.Domain.Models
{
    public class StudentEntityModel
    {
        [Key]
        [Column("StudentId")]
        public int studentId { get; set; }
        [Required]
        [Column("StudentName")]
        [Display(Name = "Student Name")]
        public string studentName { get; set; }
        [Column("ProgrammeId")]
        [Display(Name = "Programme")]
        public int programmeId { get; set; }
    }
}
