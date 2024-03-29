﻿using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; } 
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<DepartmetSubject> DepartmetSubjects { get; set;}
        public DbSet<StudentSubject> StudentSubjects { get; set; }
    }
}
