namespace Moodle3KL.Domain
{
    public class mdl_question_usages : mdl_entity_base {
        public long contextid { get; set; }
        public string component { get; set; }
        public string preferredbehaviour { get; set; }
    }
}