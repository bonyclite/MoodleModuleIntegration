using System.Collections.Generic;

namespace StudentCard.Web.UI.Models.StudentCard.Marks
{
    public class StudentCardMarksModel
    {
        public List<SemesterModel> Semesters { get; set; }

        public StudentCardMarksModel()
        {
            Semesters = new List<SemesterModel>();
        }
    }

    public class SemesterModel
    {
        public string Name { get; set; }
        public List<DisciplineModel> Disciplines { get; set; }

        public SemesterModel()
        {
            Disciplines = new List<DisciplineModel>();
        }
    }

    public class DisciplineModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Form { get; set; }
        public string Mark { get; set; }
        public long? Hours { get; set; }
    }
}