namespace EducationalPlans.Domain
{
    public class СправочникТипБлока : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Название { get; set; }
        public bool ИзООП { get; set; }
    }
}