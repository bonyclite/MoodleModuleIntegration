using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Infrastructure
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class PersonnelStuDbContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<StudentState> StudentStates { get; set; }
        public DbSet<StuState> StuStates { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public PersonnelStuDbContext(string connection) : base(connection)
        {
            
        }
    }
}