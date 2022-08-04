using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EliteWebTechAssignment.Domain.Models
{
    public class IntakeEntityModel
    {
        [Key]
        public int PkId { get; set; }
        [Column("StudentId")]
        public int studentId { get; set; }
        [Column("IntakeYear")]
        public int intakeYear { get; set; }
    }
}
