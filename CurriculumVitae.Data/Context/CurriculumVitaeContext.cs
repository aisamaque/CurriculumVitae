using CurriculumVitae.Domain.Models;
using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CurriculumVitae.Data.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CurriculumVitaeContext : DbContext
    {
        public CurriculumVitaeContext() : base("CurriculumVitaeContext")
        {

        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ExperienceDetail> Details { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Entity<Experience>()
                    .HasRequired<Career>(s => s.Career)
                    .WithMany(x => x.Experiences);

            modelBuilder.Entity<ExperienceDetail>()
                   .HasRequired<Experience>(s => s.Experience)
                   .WithMany(x => x.Details);

            modelBuilder.Entity<Project>()
                    .HasRequired<Career>(s => s.Career)
                    .WithMany(x => x.Projects);

            modelBuilder.Entity<Skill>()
                    .HasRequired<Career>(s => s.Career)
                    .WithMany(x => x.Skills);

            modelBuilder.Entity<Contact>()
                    .HasRequired<Profile>(s => s.Profile)
                    .WithMany(x => x.Contacts);

            modelBuilder.Entity<Education>()
                    .HasRequired<Profile>(s => s.Profile)
                    .WithMany(x => x.Educations);

            modelBuilder.Entity<Language>()
                    .HasRequired<Profile>(s => s.Profile)
                    .WithMany(x => x.Languages);

            modelBuilder.Entity<Interest>()
                    .HasRequired<Profile>(s => s.Profile)
                    .WithMany(x => x.Interest);

            modelBuilder.Entity<Career>()
                    .HasRequired<Profile>(s => s.Profile)
                    .WithMany(x => x.CareerProfile );

            modelBuilder.Entity<Address>()
                   .HasRequired<Profile>(s => s.Profile)
                   .WithMany(x => x.Address);
        }
    }
}
