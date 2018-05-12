namespace Moodle3KL.Domain
{
    public class mdl_lesson_answers : mdl_entity_base
    {
        public long lessonid { get; set; }
        public long pageid { get; set; }
        public long jumpto { get; set; }
        public short grade { get; set; }
        public long score { get; set; }
        public short flags { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string answer { get; set; }
        public short answerformat { get; set; }
        public string response { get; set; }
        public short responseformat { get; set; }
    }
}