namespace EducationalPlans.Domain
{
    public class ПланыПрофили
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПлана { get; set; }
        public int КодООП { get; set; }
        public int КодФакультета { get; set; }
    }
}