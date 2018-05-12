namespace Moodle3KL.Domain
{
    public class mdl_survey_questions
    {
        public long id { get; set; }
        public string text { get; set; }
        public string shorttext { get; set; }
        public string multi { get; set; }
        public string intro { get; set; }
        public short type { get; set; }
        public string options { get; set; }
    }
}