namespace EducationalPlans.Domain
{
    public class СправочникТипаРабот : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Название { get; set; }
        public bool Отображать { get; set; }
    }
}