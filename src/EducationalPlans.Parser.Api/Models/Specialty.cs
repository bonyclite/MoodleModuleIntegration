using EducationalPlans.Parser.Api.Models.Attributes;

namespace EducationalPlans.Parser.Api.Models
{
    [Route("GetSpecialties")]
    public class Specialty
    {
        public string Id { get; set; }
        public short Faculty { get; set; }
        public string Name { get; set; }
        public string SpecNumber { get; set; }
        public short EduForm { get; set; }
    }
}