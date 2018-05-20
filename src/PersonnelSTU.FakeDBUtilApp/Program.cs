using System.Diagnostics.CodeAnalysis;
using PersonnelSTU.Data.Infrastructure;
using System.Linq;

namespace PersonnelSTU.FakeDBUtilApp
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class Program
    {
        public static void Main(string[] args)
        {
            var fakeContext = new PersonnelStuDbContext(AppConfig.FakePersonnelSTUDbConnectionString);

            var sdfsd = fakeContext.Faculties.AsNoTracking().ToArray();

            var realContext = new PersonnelStuDbContext(AppConfig.PersonnelSTUDbConnectionString);
            
            var faculties = realContext.Faculties.AsNoTracking().ToArray();
            fakeContext.Faculties.AddRange(faculties);

            var groups = realContext.Groups.AsNoTracking().ToArray();
            fakeContext.Groups.AddRange(groups);

            var persons = realContext.Persons.AsNoTracking().ToArray();
            fakeContext.Persons.AddRange(persons);

            var spec = realContext.Specialties.AsNoTracking().ToArray();
            fakeContext.Specialties.AddRange(spec);

            var studentStates = realContext.StudentStates.AsNoTracking().ToArray();
            fakeContext.StudentStates.AddRange(studentStates);

            var stuStates = realContext.StuStates.AsNoTracking().ToArray();
            fakeContext.StuStates.AddRange(stuStates);

            var teachers = realContext.Teachers.AsNoTracking().ToArray();
            fakeContext.Teachers.AddRange(teachers);

            fakeContext.SaveChanges();            
        }
    }
}