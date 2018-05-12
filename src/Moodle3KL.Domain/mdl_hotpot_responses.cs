namespace Moodle3KL.Domain
{
    public class mdl_hotpot_responses
    {
        public long id { get; set; }
        public long attemptid { get; set; }
        public long questionid { get; set; }
        public int score { get; set; }
        public int weighting { get; set; }
        public string correct { get; set; }
        public string wrong { get; set; }
        public string ignored { get; set; }
        public int hints { get; set; }
        public int clues { get; set; }
        public int checks { get; set; }
    }
}