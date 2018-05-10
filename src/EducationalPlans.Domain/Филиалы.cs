namespace EducationalPlans.Domain
{
    public class Филиалы
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код_филиала { get; set; }
        public string Полное_название { get; set; }
        public string Краткое_Название { get; set; }
        public bool Головное_учреждение { get; set; }
        public string Директор { get; set; }
    }
}