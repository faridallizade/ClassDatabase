using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupDatabase.DAL
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-4R5RDF2;database=ClassData;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        }
}
