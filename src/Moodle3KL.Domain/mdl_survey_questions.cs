namespace Moodle3KL.Domain
{
    public class mdl_survey_questions : mdl_entity_base
    {
        public string text { get; set; }
        public string shorttext { get; set; }
        public string multi { get; set; }
        public string intro { get; set; }
        public short type { get; set; }
        public string options { get; set; }
    }
}