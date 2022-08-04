using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EliteWebTechAssignment.Domain.Models
{
    public class SubjectEntityModel
    {
        [Key]
        public int PkId { get; set; }
        [Column("ProgrammeId")]
        public int programmeId { get; set; }
        [Column("SubjectName")]
        public string subjectName { get; set; }
    }
}
