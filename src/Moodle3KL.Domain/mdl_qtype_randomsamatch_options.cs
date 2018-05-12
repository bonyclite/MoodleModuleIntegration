namespace Moodle3KL.Domain
{
    public class mdl_qtype_randomsamatch_options : mdl_entity_base {
        public long questionid { get; set; }
        public long choose { get; set; }
        public short subcats { get; set; }
        public string correctfeedback { get; set; }
        public short correctfeedbackformat { get; set; }
        public string partiallycorrectfeedback { get; set; }
        public short partiallycorrectfeedbackformat { get; set; }
        public string incorrectfeedback { get; set; }
        public short incorrectfeedbackformat { get; set; }
        public short shownumcorrect { get; set; }
    }
}