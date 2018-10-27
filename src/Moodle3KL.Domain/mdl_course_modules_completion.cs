namespace Moodle3KL.Domain
{
    public class mdl_course_modules_completion : mdl_entity_base
    {
        public long coursemoduleid { get; set; }
        public long userid { get; set; }
        public short completionstate { get; set; }
        public short? viewed { get; set; }
        public long timemodified { get; set; }
    }
}