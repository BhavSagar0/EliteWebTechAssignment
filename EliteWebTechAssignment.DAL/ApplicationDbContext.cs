using EliteWebTechAssignment.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteWebTechAssignment.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        DbSet<StudentEntityModel> Students { get; set; }
        DbSet<ProgrammeEntityModel> Programmes { get; set; }
    }
}
