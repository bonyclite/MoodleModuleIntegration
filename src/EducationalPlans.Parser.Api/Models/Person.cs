using System;
using EducationalPlans.Parser.Api.Models.Attributes;

namespace EducationalPlans.Parser.Api.Models
{
    [Route("GetPersons")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public char Sex { get; set; }
    }
}