using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EliteWebTechAssignment.Domain.Models
{
    public class StudentMarksEntityModel
    {
        [Key]
        public int PkId { get; set; }
        public int studentId { get; set; }
        [DefaultValue(0)]
        public int marks1 { get; set; }
        [DefaultValue(0)]
        public int marks2 { get; set; }
        [DefaultValue(0)]
        public int marks3 { get; set; }
    }
}
