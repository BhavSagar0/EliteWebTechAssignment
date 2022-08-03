using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EliteWebTechAssignment.Domain.Models
{
    public class SubjectEntityModel
    {
        [Column("ProgrammeId")]
        public int programmeId { get; set; }
        [Column("CurrentSemester")]
        public int currentSemester { get; set; }
    }
}
