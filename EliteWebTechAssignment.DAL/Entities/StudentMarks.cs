using System;
using System.Collections.Generic;

namespace EliteWebTechAssignment.DAL.Entities
{
    public partial class StudentMarks
    {
        public int Pkid { get; set; }
        public int? StudentId { get; set; }
        public int? Marks1 { get; set; }
        public int? Marks2 { get; set; }
        public int? Marks3 { get; set; }
    }
}
