using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentCard.Web.UI.Models.Documentation.CreateMakeUpAcademicDebtDocuments
{
    public class CreateDocumentationMakeUpAcademicDebtDocumentsModel
    {
        public long ProgrammItemId { get; set; }
        public string DisciplineName { get; set; }

        public List<StudentModel> Students { get; set; }

        public IEnumerable<long> StudentIds { get; set; }

        public CreateDocumentationMakeUpAcademicDebtDocumentsModel()
        {
            Students = new List<StudentModel>();
        }
    }

    public class StudentModel
    {
        public long MdlUser { get; set; }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long GroupId { get; set; }
        public string GroupName { get; set; }

        public string FullName => $"{LastName} {FirstName} {MiddleName}";
    }
}