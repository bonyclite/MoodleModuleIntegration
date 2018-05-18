namespace EducationalPlans.Domain
{
    public class ООП : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодРодительскогоООП { get; set; }
        public string Шифр { get; set; }
        public string Название { get; set; }
        public int УровеньОбразования { get; set; }
        public int Квалификация { get; set; }
        public string ТипГОСа { get; set; }
        public bool Используется { get; set; }
        public string Префикс { get; set; }
    }
}