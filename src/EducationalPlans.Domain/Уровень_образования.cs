namespace EducationalPlans.Domain
{
    public class Уровень_образования
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public int Код_записи { get; set; }
        public string Уровень { get; set; }
        public string ВидПлана { get; set; }
        public string Категория { get; set; }
        public bool Вывод { get; set; }
        public string Префикс { get; set; }
        public string Примечание { get; set; }
        public int Шифр { get; set; }
    }
}