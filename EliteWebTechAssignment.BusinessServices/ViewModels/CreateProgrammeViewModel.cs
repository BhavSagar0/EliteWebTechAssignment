using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EliteWebTechAssignment.BusinessServices.ViewModels
{
    public class CreateProgrammeViewModel
    {
        public ProgrammeEntityModel programme { get; set; }
        [Display(Name = "Subject 1")]
        public string subject1 { get; set; }
        [Display(Name = "Subject 2")]
        public string subject2 { get; set; }
        [Display(Name = "Subject 3")]
        public string subject3 { get; set; }
        public bool isSuccess { get; set; }
    }
}
