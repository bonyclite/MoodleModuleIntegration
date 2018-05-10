namespace EducationalPlans.Domain
{
    public class ПланыГрафикиЯчейки
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодГрафика { get; set; }
        public int КодВидаДеятельности { get; set; }
        public int НомерНедели { get; set; }
        public int НомерЧастиНедели { get; set; }
        public int Курс { get; set; }
        public int Семестр { get; set; }
        public bool Переаттестована { get; set; }
        public int КоличествоЧастейВНеделе { get; set; }
        public int НомерПервойНедели { get; set; }
    }
}