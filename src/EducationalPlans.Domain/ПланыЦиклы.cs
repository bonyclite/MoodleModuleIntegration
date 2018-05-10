namespace EducationalPlans.Domain
{
    public class ПланыЦиклы
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПлана { get; set; }
        public int ТипБлока { get; set; }
        public int ТипОбъекта { get; set; }
        public bool Факультативы { get; set; }
        public string Идентификатор { get; set; }
        public string Цикл { get; set; }
        public int ЗЕТмин { get; set; }
        public int ЗЕТмакс { get; set; }
        public bool Физкультура { get; set; }
        public int СтарыйКод { get; set; }
    }
}