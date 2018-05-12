namespace Moodle3KL.Domain
{
    public class mdl_qtype_ordering_options : mdl_entity_base {
        public long questionid { get; set; }
        public short layouttype { get; set; }
        public short selecttype { get; set; }
        public short selectcount { get; set; }
        public short gradingtype { get; set; }
        public short showgrading { get; set; }
        public string correctfeedback { get; set; }
        public short correctfeedbackformat { get; set; }
        public string incorrectfeedback { get; set; }
        public short incorrectfeedbackformat { get; set; }
        public string partiallycorrectfeedback { get; set; }
        public short partiallycorrectfeedbackformat { get; set; }
    }
}