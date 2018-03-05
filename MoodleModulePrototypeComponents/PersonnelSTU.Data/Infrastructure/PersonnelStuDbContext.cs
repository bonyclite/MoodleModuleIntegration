using System.Data.Entity;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Infrastructure
{
    public class PersonnelStuDbContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<StudentState> StudentStates { get; set; }
        public DbSet<StuState> StuStates { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public PersonnelStuDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PersonnelStuDbContext>());
        }

        public PersonnelStuDbContext(string connectionString) : base(connectionString)
        {
        }
    }
}