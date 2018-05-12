namespace Moodle3KL.Domain
{
    public class mdl_question_attempts
    {
        public long id { get; set; }
        public long questionusageid { get; set; }
        public long slot { get; set; }
        public string behaviour { get; set; }
        public long questionid { get; set; }
        public long variant { get; set; }
        public decimal maxmark { get; set; }
        public decimal minfraction { get; set; }
        public decimal maxfraction { get; set; }
        public short flagged { get; set; }
        public string questionsummary { get; set; }
        public string rightanswer { get; set; }
        public string responsesummary { get; set; }
        public long timemodified { get; set; }
    }
}