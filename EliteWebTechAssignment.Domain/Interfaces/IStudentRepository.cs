﻿using EliteWebTechAssignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteWebTechAssignment.Domain.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<ProgrammeEntityModel> GetAllProgrammes();
    }
}
