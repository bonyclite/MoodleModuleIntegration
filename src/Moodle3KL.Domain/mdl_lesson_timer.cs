namespace Moodle3KL.Domain
{
    public class mdl_lesson_timer
    {
        public long id { get; set; }
        public long lessonid { get; set; }
        public long userid { get; set; }
        public long starttime { get; set; }
        public long lessontime { get; set; }
        public short? completed { get; set; }
    }
}