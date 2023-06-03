using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoB_App
{
    public class DoBAppContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-604CIS3\SQLEXPRESS;" +
                        "Initial catalog=PersonsDB;" +
                         "Integrated Security=True;" +
                         "TrustServerCertificate = True;" +
                         "Trusted_Connection=True");
        }
    }
}
