namespace EducationalPlans.Domain
{
    public class ВыбранныеВидыРабот : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПлана { get; set; }
        public int КодВидаРабот { get; set; }
    }
}