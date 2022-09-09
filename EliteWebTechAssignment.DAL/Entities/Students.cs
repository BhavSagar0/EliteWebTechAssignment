using System;
using System.Collections.Generic;

namespace EliteWebTechAssignment.DAL.Entities
{
    public partial class Students
    {
        public int Pkid { get; set; }
        public string StudentName { get; set; }
        public string CollegeName { get; set; }
        public int? ProgrammeId { get; set; }
    }
}
