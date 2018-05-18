namespace EducationalPlans.Domain
{
    public class ПрограммаПодготовки : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Наименование { get; set; }
        public string Префикс { get; set; }
        public int Уровень { get; set; }
    }
}