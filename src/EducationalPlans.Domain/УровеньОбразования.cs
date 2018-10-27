namespace EducationalPlans.Domain
{
    public class УровеньОбразования : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Уровень { get; set; }
        public string Префикс { get; set; }
    }
}