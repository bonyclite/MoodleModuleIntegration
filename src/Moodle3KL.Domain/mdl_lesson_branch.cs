namespace Moodle3KL.Domain
{
    public class mdl_lesson_branch : mdl_entity_base
    {
        public long lessonid { get; set; }
        public long userid { get; set; }
        public long pageid { get; set; }
        public long retry { get; set; }
        public short flag { get; set; }
        public long timeseen { get; set; }
        public long nextpageid { get; set; }
    }
}