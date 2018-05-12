namespace Moodle3KL.Domain
{
    public class mdl_quiz_sections : mdl_entity_base
    {
        public long quizid { get; set; }
        public long firstslot { get; set; }
        public string heading { get; set; }
        public short shufflequestions { get; set; }
    }
}