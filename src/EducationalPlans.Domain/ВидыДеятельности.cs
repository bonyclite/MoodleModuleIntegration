namespace EducationalPlans.Domain
{
    public class ВидыДеятельности : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Наименование { get; set; }
        public int КодООП { get; set; }
    }
}