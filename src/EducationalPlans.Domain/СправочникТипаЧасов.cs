namespace EducationalPlans.Domain
{
    public class СправочникТипаЧасов : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public string Наименование { get; set; }
    }
}