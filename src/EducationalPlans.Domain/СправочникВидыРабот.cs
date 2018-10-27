namespace EducationalPlans.Domain
{
    public class СправочникВидыРабот : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public string Название { get; set; }
        public int КодТипРабот { get; set; }
        public string Аббревиатура { get; set; }
        public bool Контактный { get; set; }
        public bool Аудиторный { get; set; }
        public bool Отображать { get; set; }
        public bool HasInter { get; set; }
        public bool HasDistr { get; set; }
    }
}