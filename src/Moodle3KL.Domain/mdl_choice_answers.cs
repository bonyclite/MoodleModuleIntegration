namespace Moodle3KL.Domain
{
    public class mdl_choice_answers
    {
        public long id { get; set; }
        public long choiceid { get; set; }
        public long userid { get; set; }
        public long optionid { get; set; }
        public long timemodified { get; set; }
    }
}