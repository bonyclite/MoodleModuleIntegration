namespace Moodle3KL.Domain
{
    public class mdl_quiz_slots
    {
        public long id { get; set; }
        public long slot { get; set; }
        public long quizid { get; set; }
        public long page { get; set; }
        public short requireprevious { get; set; }
        public long questionid { get; set; }
        public decimal maxmark { get; set; }
    }
}