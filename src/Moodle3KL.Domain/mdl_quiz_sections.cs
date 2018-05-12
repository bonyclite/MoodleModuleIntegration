namespace Moodle3KL.Domain
{
    public class mdl_quiz_sections
    {
        public long id { get; set; }
        public long quizid { get; set; }
        public long firstslot { get; set; }
        public string heading { get; set; }
        public short shufflequestions { get; set; }
    }
}