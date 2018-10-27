namespace EducationalPlans.Domain
{
    public class ПланыВидыДеятельности : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПлана { get; set; }
        public int КодВидаДеятельности { get; set; }
        public int КодООП { get; set; }
        public bool Основной { get; set; }
    }
}