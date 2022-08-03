using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EliteWebTechAssignment.Domain.Models
{
    public class CurrentSemEntityModel
    {
        [Column("StudentId")]
        public int studentId { get; set; }
        [Column("CurrentSemester")]
        public int currentSemester { get; set; }
    }
}
