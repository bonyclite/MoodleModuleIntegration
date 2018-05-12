namespace Moodle3KL.Domain
{
    public class mdl_crw_course_properties : mdl_entity_base {
        public long courseid { get; set; }
        public string name { get; set; }
        public string svalue { get; set; }
        public string value { get; set; }
    }
}