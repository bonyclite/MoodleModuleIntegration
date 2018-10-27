namespace EducationalPlans.Domain
{
    public class ПланыНовыеГрафики : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int Код { get; set; }
        public int КоличествоЧастейВНеделе { get; set; }
    }
}