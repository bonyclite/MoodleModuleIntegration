namespace EducationalPlans.Domain
{
    public class Компетенции : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодООП { get; set; }
        public int КодВидаДеятельности { get; set; }
        public string ШифрКомпетенции { get; set; }
        public string Наименование { get; set; }
        public int Номер { get; set; }
    }
}