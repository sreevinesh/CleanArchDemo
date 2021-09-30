using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDbContext : DbContext
    {
       
         public UniversityDbContext(DbContextOptions options) : base(options)
         {
         }
        
        public DbSet<Crsss> Crsss { get; set; }
        public DbSet<Courses> Courses { get; set; }
       


    }
}