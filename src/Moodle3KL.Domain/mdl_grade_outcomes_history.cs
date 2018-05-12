namespace Moodle3KL.Domain
{
    public class mdl_grade_outcomes_history : mdl_entity_base {
        public long action { get; set; }
        public long oldid { get; set; }
        public string source { get; set; }
        public long? timemodified { get; set; }
        public long? loggeduser { get; set; }
        public long? courseid { get; set; }
        public string shortname { get; set; }
        public string fullname { get; set; }
        public long? scaleid { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
    }
}