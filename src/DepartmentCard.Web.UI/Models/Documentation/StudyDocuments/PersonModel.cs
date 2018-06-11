namespace DepartmentCard.Web.UI.Models.Documentation.StudyDocuments
{
    public class PersonModel
    {
        public long Id { get; set; }
        public long StudyDocumentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{LastName} {FirstName} {MiddleName}";
    }
}