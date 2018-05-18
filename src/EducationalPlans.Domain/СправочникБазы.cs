namespace EducationalPlans.Domain
{
    public class СправочникБазы : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Наименование { get; set; }
        public int Уровень { get; set; }
        public string Префикс { get; set; }
    }
}