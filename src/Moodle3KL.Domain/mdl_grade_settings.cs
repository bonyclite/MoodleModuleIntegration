namespace Moodle3KL.Domain
{
    public class mdl_grade_settings : mdl_entity_base {
        public long courseid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}