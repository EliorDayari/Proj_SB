using Microsoft.EntityFrameworkCore;
using Proj_SB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_SB.Date
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options): base(options){
            }

        DbSet<Student> Student { get; set; }
        DbSet<Course> Course { get; set; }
        DbSet<Enrollment> Enrollment { get; set; }
    }   
}

    

