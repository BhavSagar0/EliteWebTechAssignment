using System;
using System.Collections.Generic;

namespace EliteWebTechAssignment.DAL.Entities
{
    public partial class Subjects
    {
        public int Pkid { get; set; }
        public int? ProgrammeId { get; set; }
        public string SubjectName { get; set; }
    }
}
