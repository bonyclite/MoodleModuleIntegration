namespace Moodle3KL.Domain
{
    public class mdl_course_format_options : mdl_entity_base
    {
        public long courseid { get; set; }
        public string format { get; set; }
        public long sectionid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}