using Microsoft.EntityFrameworkCore;
using PersonnelSTU.Core.Domain;

namespace PersonnelSTU.Core.Data.Infrastructure
{
    public class PersonnelStuCoreDbContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<StudentState> StudentStates { get; set; }
        public DbSet<StuState> StuStates { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public PersonnelStuCoreDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}