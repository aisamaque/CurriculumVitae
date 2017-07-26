using CurriculumVitae.DomainStandard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CurriculumVitae.DataStandard.Context
{
    public class CurriculumVitaeContext : DbContext
    {
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Career> Career { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ExperienceDetail> ExperienceDetail { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Interest> Interest { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Skill> Skill { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));
        }
    }
}
