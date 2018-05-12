namespace Moodle3KL.Domain
{
    public class mdl_course_completions : mdl_entity_base {
        public long userid { get; set; }
        public long course { get; set; }
        public long timeenrolled { get; set; }
        public long timestarted { get; set; }
        public long? timecompleted { get; set; }
        public long reaggregate { get; set; }
    }
}