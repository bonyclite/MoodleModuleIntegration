namespace EducationalPlans.Domain
{
    public class ПланыКонтингент : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПлана { get; set; }
        public int Курс { get; set; }
        public int ЧислоГрупп { get; set; }
        public int ЧислоОбучающихся { get; set; }
        public int ЧислоСдающихКандидатскиеЭкзамены { get; set; }
        public int ЧислоСоискателей { get; set; }
        public int ЧислоПолучДопКвалификацию { get; set; }
        public int КодООП { get; set; }
    }
}