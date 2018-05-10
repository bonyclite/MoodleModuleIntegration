namespace EducationalPlans.Domain
{
    public class Кафедры
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public string Название { get; set; }
        public string Сокращение { get; set; }
        public int Номер { get; set; }
        public string ЗавКафедрой { get; set; }
        public string Аудитория { get; set; }
        public string Телефон { get; set; }
        public string ВнутрТелефон { get; set; }
        public string EMail { get; set; }
        public string URL { get; set; }
        public bool Удалена { get; set; }
        public string ПрефиксКафедры { get; set; }
        public bool ЦМК { get; set; }
    }
}