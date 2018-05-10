namespace EducationalPlans.Domain
{
    public class ПланыНовыеЧасы
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодОбъекта { get; set; }
        public int КодВидаРаботы { get; set; }
        public int КодТипаЧасов { get; set; }
        public int Курс { get; set; }
        public int Семестр { get; set; }
        public int Сессия { get; set; }
        public int Недель { get; set; }
        public int Дней { get; set; }
        public int Количество { get; set; }
        public bool Переаттестовано { get; set; }
        public int ТипКомиссии { get; set; }
    }
}