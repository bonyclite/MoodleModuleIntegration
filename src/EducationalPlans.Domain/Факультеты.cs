namespace EducationalPlans.Domain
{
    public class Факультеты
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public string Факультет { get; set; }
        public string Сокращение { get; set; }
        public string Псевдоним { get; set; }
        public string Декан { get; set; }
        public string Телефон { get; set; }
        public string Аудитория { get; set; }
        public bool Сайт { get; set; }
        public string ВнутрТелефон { get; set; }
        public string EMail { get; set; }
        public string URL { get; set; }
        public string ФайлСтиля { get; set; }
        public string Шифр { get; set; }
        public string Описание { get; set; }
        public int Код_филиала { get; set; }
        public string РодПадеж { get; set; }
        public string Секретарь { get; set; }
        public string ЗамДекана { get; set; }
        public string Тип { get; set; }
    }
}