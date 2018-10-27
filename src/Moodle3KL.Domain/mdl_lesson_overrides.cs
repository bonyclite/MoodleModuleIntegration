namespace Moodle3KL.Domain
{
    public class mdl_lesson_overrides : mdl_entity_base
    {
        public long lessonid { get; set; }
        public long? groupid { get; set; }
        public long? userid { get; set; }
        public long? available { get; set; }
        public long? deadline { get; set; }
        public long? timelimit { get; set; }
        public short? review { get; set; }
        public short? maxattempts { get; set; }
        public short? retake { get; set; }
        public string password { get; set; }
    }
}