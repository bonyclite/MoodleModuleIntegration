namespace EducationalPlans.Domain
{
    public class СправочникВидыПрактик : BaseModel {
        public int rowOrder { get; set; }
        public int Код { get; set; }
        public string Наименование { get; set; }
        public string Префикс { get; set; }
    }
}