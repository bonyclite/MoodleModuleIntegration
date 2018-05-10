namespace EducationalPlans.Domain
{
    public class Заезды
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int Курс { get; set; }
        public int Сессия { get; set; }
        public string Название { get; set; }
        public string ДатаНачала { get; set; }
        public int Продолжительность { get; set; }
        public int КодПлана { get; set; }
        public int Семестр { get; set; }
    }
}