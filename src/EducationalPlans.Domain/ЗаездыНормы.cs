namespace EducationalPlans.Domain
{
    public class ЗаездыНормы
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПлана { get; set; }
        public int Курс { get; set; }
        public int Дней { get; set; }
        public int Дорога { get; set; }
    }
}