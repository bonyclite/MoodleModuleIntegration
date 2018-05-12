namespace Moodle3KL.Domain
{
    public class mdl_enrol_flatfile : mdl_entity_base {
        public string action { get; set; }
        public long roleid { get; set; }
        public long userid { get; set; }
        public long courseid { get; set; }
        public long timestart { get; set; }
        public long timeend { get; set; }
        public long timemodified { get; set; }
    }
}