namespace Moodle3KL.Domain
{
    public class mdl_choice_options : mdl_entity_base
    {
        public long choiceid { get; set; }
        public string text { get; set; }
        public long? maxanswers { get; set; }
        public long timemodified { get; set; }
    }
}