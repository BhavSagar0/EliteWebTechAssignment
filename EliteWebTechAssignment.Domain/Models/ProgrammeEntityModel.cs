using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EliteWebTechAssignment.Domain.Models
{
    public class ProgrammeEntityModel
    {
        [Key]
        [Column("ProgrammeId")]
        public int programmeId { get; set; }
        [Required]
        [Column("ProgrammeName")]
        [Display(Name = "Programme Name")]
        public string programmeName { get; set; }
    }
}
