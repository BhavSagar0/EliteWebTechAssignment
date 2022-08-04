using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteWebTechAssignment.BusinessServices.ViewModels
{
    public class StudentIndexViewModel
    {
        public IEnumerable<StudentEntityModel> students { get; set; }
    }
}
