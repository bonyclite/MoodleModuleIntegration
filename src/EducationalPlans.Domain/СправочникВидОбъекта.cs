namespace EducationalPlans.Domain
{
    public class СправочникВидОбъекта : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Наименование { get; set; }
    }
}