using System.Collections.Generic;

namespace StudentCard.Web.UI.Models.StudentCard.AcademicDebts
{
    public class StudentCardAcademicDebtsViewModel
    {
        public long StudentId { get; set; }
        public List<DisciplineModel> Disciplines { get; set; }

        public StudentCardAcademicDebtsViewModel()
        {
            Disciplines = new List<DisciplineModel>();
        }

        public class DisciplineModel
        {
            public long GradeItemId { get; set; }
            public string DisciplineName { get; set; }
        }
    }
}