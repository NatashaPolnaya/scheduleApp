using Microsoft.EntityFrameworkCore;
using scheduleApp.Models;


namespace scheduleApp.DAL
{
    public class ScheduleDB: DbContext
    {
        public DbSet <Time> Time { get; set; }
        public DbSet<Discipline> Discipline { get; set; }
        public DbSet<Schedule> Schedule { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Natas\OneDrive\Рабочий стол\123\WEBKA\pr_s_db\db1.db");
        }
    }
}
