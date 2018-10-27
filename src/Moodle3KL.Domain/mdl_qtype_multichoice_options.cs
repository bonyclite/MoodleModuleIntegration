namespace Moodle3KL.Domain
{
    public class mdl_qtype_multichoice_options : mdl_entity_base
    {
        public long questionid { get; set; }
        public short layout { get; set; }
        public short single { get; set; }
        public short shuffleanswers { get; set; }
        public string correctfeedback { get; set; }
        public short correctfeedbackformat { get; set; }
        public string partiallycorrectfeedback { get; set; }
        public short partiallycorrectfeedbackformat { get; set; }
        public string incorrectfeedback { get; set; }
        public short incorrectfeedbackformat { get; set; }
        public string answernumbering { get; set; }
        public short shownumcorrect { get; set; }
    }
}