namespace EducationalPlans.Domain
{
    public class ДолжностныеЛица : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public string ФИО { get; set; }
        public string Должность { get; set; }
        public string Звание { get; set; }
    }
}