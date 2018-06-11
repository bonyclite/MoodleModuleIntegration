using System;
using System.Collections.Generic;

namespace TeacherCard.Web.UI.Models.Documentation.MakeUpAcademicDebts
{
    public class DocumentationMakeUpAcademicDebtDocumentsModel
    {
        public long ProgrammItemId { get; set; }
        public string DisciplineName { get; set; }

        public List<AcademicDebtDocumentModel> AcademicDebtDocumentModels { get; set; }

        public DocumentationMakeUpAcademicDebtDocumentsModel()
        {
            AcademicDebtDocumentModels = new List<AcademicDebtDocumentModel>();
        }
    }

    public class AcademicDebtDocumentModel
    {
        public string FullName => $"{LastName} {FirstName} {MiddleName}";

        public long MdlUser { get; set; }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long GroupId { get; set; }
        public long GradeId { get; set; }
        public string GroupName { get; set; }
        public decimal? Mark { get; set; }

        public DisciplineModel DisciplineModel { get; set; }
        public DateTime Date { get; set; }
    }

    public class DisciplineModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}