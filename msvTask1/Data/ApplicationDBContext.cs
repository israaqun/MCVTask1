using Microsoft.EntityFrameworkCore;
using msvTask1.Models;

namespace msvTask1.Data
{
    public class ApplicationDBContext :DbContext

    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-1BMV37U;database=msvtask1;trusted_connection=True;trustServerCertificate=true");
        }
    }
}
