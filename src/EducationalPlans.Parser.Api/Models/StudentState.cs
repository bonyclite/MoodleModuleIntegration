using System;
using EducationalPlans.Parser.Api.Models.Attributes;

namespace EducationalPlans.Parser.Api.Models
{
    [Route("GetStudentStates")]
    public class StudentState
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public short StuStateId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? StopDateVac { get; set; }
        public short GroupId { get; set; }
        public byte Ayear { get; set; }
        public string GroupName { get; set; }
        public string StudentName { get; set; }
        public string Zoo { get; set; }
        public string SpecialtyId { get; set; }
        public short FacultyId { get; set; }
        public short EduForm { get; set; }
    }
}