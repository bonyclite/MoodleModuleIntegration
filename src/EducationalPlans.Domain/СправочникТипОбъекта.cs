namespace EducationalPlans.Domain
{
    public class СправочникТипОбъекта : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Название { get; set; }
        public bool Составляющий { get; set; }
    }
}