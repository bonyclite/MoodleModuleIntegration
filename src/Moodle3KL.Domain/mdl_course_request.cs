namespace Moodle3KL.Domain
{
    public class mdl_course_request : mdl_entity_base {
        public string fullname { get; set; }
        public string shortname { get; set; }
        public string summary { get; set; }
        public short summaryformat { get; set; }
        public long category { get; set; }
        public string reason { get; set; }
        public long requester { get; set; }
        public string password { get; set; }
    }
}