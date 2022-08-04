using EliteWebTechAssignment.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteWebTechAssignment.DAL.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<StudentEntityModel> Students { get; set; }
        public DbSet<ProgrammeEntityModel> Programmes { get; set; }
    }
}
