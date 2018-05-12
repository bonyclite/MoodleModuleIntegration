namespace Moodle3KL.Domain
{
    public class mdl_lesson_attempts : mdl_entity_base {
        public long lessonid { get; set; }
        public long pageid { get; set; }
        public long userid { get; set; }
        public long answerid { get; set; }
        public short retry { get; set; }
        public long correct { get; set; }
        public string useranswer { get; set; }
        public long timeseen { get; set; }
    }
}