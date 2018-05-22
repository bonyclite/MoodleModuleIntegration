using EducationalPlans.Parser.Api.Models.Attributes;

namespace EducationalPlans.Parser.Api.Models
{
    [Route("GetTeachers")]
    public class Teacher
    {
        public int Id { get; set; }
        public int TabelNumber { get; set; }
        public string Fio { get; set; }
        public char Position { get; set; }
        public string Department { get; set; }
        public string PostName { get; set; }
        public string Degree { get; set; }
        public virtual string Rank { get; set; }
    }
}