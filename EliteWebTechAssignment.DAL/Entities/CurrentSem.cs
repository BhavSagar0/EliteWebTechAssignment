using System;
using System.Collections.Generic;

namespace EliteWebTechAssignment.DAL.Entities
{
    public partial class CurrentSem
    {
        public int Pkid { get; set; }
        public string StudentId { get; set; }
        public int? CurrentSem1 { get; set; }
    }
}
