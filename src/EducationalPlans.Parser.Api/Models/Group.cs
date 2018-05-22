using System;
using EducationalPlans.Parser.Api.Models.Attributes;

namespace EducationalPlans.Parser.Api.Models
{
    [Route("GetGroups")]
    public class Group
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public short Index { get; set; }
        public DateTime StartDate { get; set; }
        public string SpecialtyId { get; set; }
        public short FacultyId { get; set; }
    }
}