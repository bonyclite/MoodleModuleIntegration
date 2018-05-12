namespace Moodle3KL.Domain
{
    public class mdl_question_attempt_steps
    {
        public long id { get; set; }
        public long questionattemptid { get; set; }
        public long sequencenumber { get; set; }
        public string state { get; set; }
        public decimal? fraction { get; set; }
        public long timecreated { get; set; }
        public long? userid { get; set; }
    }
}