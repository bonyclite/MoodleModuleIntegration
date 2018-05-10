namespace EducationalPlans.Domain
{
    public class ПланыРазбиения
    {
        public string id { get; set; }
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КодПланыНовыеЧасы { get; set; }
        public int КодКафедры { get; set; }
        public int Недель { get; set; }
        public int Дней { get; set; }
        public int КоличествоСтудентов { get; set; }
        public bool Суммировать { get; set; }
        public int НормативНаСтуд { get; set; }
        public int НормативНаСтудВНед { get; set; }
        public int НормативНаПодгр { get; set; }
        public int НормативНаПодгрВНед { get; set; }
        public string Наименование { get; set; }
        public int НомерКомиссии { get; set; }
        public string Преподаватель { get; set; }
    }
}