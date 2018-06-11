using System.Collections.Generic;

namespace StudentCard.Web.UI.Models.StudentCard.AcademicDebts
{
    public class StudentCardAcademicDebtsModel
    {
        public IEnumerable<long> GradeItemIds { get; set; }
        public long StudentId { get; set; }
    }
}