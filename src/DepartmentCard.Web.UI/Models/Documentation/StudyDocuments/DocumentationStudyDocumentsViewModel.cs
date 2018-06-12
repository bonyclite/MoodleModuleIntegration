using System.Collections.Generic;

namespace DepartmentCard.Web.UI.Models.Documentation.StudyDocuments
{
    public class DocumentationStudyDocumentsViewModel
    {
        public List<PersonModel> Persons { get; set; }

        public DocumentationStudyDocumentsViewModel()
        {
            Persons = new List<PersonModel>();
        }
    }
}