using EducationalPlans.Parser.Api.Models.Attributes;

namespace EducationalPlans.Parser.Api.Models
{
    [Route("GetFaculties")]
    public class Faculty
    {
        public short Id { get; set; }
        public string Name { get; set; }
    }
}