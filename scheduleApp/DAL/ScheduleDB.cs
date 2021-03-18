using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using scheduleApp.Models;
using System;

namespace scheduleApp.DAL
{
    public class ScheduleDB: DbContext
    {
        public DbSet <time> time { get; set; }
        public DbSet<discipline> discipline { get; set; }
        public DbSet<schedule> schedule { get; set; }

        public ScheduleDB()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;username=root;password=21042000;database=schedule;");
        }
    }
}
