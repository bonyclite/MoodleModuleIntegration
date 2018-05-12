namespace Moodle3KL.Domain
{
    public class mdl_choice_options
    {
        public long id { get; set; }
        public long choiceid { get; set; }
        public string text { get; set; }
        public long? maxanswers { get; set; }
        public long timemodified { get; set; }
    }
}