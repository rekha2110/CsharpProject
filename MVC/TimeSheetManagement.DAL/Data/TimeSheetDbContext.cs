using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Data
{
    public class TimeSheetDbContext : DbContext
    {
        public TimeSheetDbContext(DbContextOptions<TimeSheetDbContext> options) : base(options)
        {

        }      
        public DbSet<Manager> manager { get; set; }      
        public DbSet<Project> project { get; set; }      
        public DbSet<Employee> employee { get; set; }      
             
    }
}
