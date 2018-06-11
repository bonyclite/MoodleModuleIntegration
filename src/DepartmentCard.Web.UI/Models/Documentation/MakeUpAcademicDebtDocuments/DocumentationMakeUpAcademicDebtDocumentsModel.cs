using System;
using System.Collections.Generic;
using System.ComponentModel;
using DepartmentCard.Web.UI.Models.Documentation.CreateMakeUpAcademicDebtDocuments;

namespace DepartmentCard.Web.UI.Models.Documentation.MakeUpAcademicDebtDocuments
{
    public class DocumentationMakeUpAcademicDebtDocumentsModel
    {
        [DisplayName("Новые")]
        public bool IsNew { get; set; }

        [DisplayName("Одобренные деканатом")]
        public bool IsDepartmentApproved { get; set; }

        [DisplayName("Дисциплина")]
        public IEnumerable<DisciplineModel> DisciplineModels { get; set; }

        public long ProgrammItemId { get; set; }
        
        public List<AcademicDebtDocumentModel> AcademicDebtDocumentModels { get; set; }

        public DocumentationMakeUpAcademicDebtDocumentsModel()
        {
            AcademicDebtDocumentModels = new List<AcademicDebtDocumentModel>();
        }
    }

    public class AcademicDebtDocumentModel : StudentModel
    {
        public DisciplineModel DisciplineModel { get; set; }
        public DateTime Date { get; set; }
        public decimal? Mark { get; set; }
    }

    public class DisciplineModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}