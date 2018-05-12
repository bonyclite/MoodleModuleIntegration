namespace Moodle3KL.Domain
{
    public class mdl_quiz_feedback : mdl_entity_base {
        public long quizid { get; set; }
        public string feedbacktext { get; set; }
        public short feedbacktextformat { get; set; }
        public decimal mingrade { get; set; }
        public decimal maxgrade { get; set; }
    }
}