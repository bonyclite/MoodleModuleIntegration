namespace EducationalPlans.Domain
{
    public class ДолжЛица_Планы
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПлана { get; set; }
        public int КодДолжЛица { get; set; }
        public bool Активный { get; set; }
        public bool Утвердил { get; set; }
        public int КодООП { get; set; }
        public int Тип { get; set; }
    }
}