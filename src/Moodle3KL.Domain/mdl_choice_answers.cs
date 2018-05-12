namespace Moodle3KL.Domain
{
    public class mdl_choice_answers : mdl_entity_base {
        public long choiceid { get; set; }
        public long userid { get; set; }
        public long optionid { get; set; }
        public long timemodified { get; set; }
    }
}