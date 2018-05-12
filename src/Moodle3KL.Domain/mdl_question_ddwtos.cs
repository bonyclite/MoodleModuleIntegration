namespace Moodle3KL.Domain
{
    public class mdl_question_ddwtos
    {
        public long id { get; set; }
        public long questionid { get; set; }
        public short shuffleanswers { get; set; }
        public string correctfeedback { get; set; }
        public short correctfeedbackformat { get; set; }
        public string partiallycorrectfeedback { get; set; }
        public short partiallycorrectfeedbackformat { get; set; }
        public string incorrectfeedback { get; set; }
        public short incorrectfeedbackformat { get; set; }
        public short shownumcorrect { get; set; }
    }
}