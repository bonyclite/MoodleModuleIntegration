namespace Moodle3KL.Domain
{
    public class mdl_question_calculated : mdl_entity_base
    {
        public long question { get; set; }
        public long answer { get; set; }
        public string tolerance { get; set; }
        public long tolerancetype { get; set; }
        public long correctanswerlength { get; set; }
        public long correctanswerformat { get; set; }
    }
}