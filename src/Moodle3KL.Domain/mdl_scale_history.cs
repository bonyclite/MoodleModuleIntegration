namespace Moodle3KL.Domain
{
    public class mdl_scale_history : mdl_entity_base {
        public long action { get; set; }
        public long oldid { get; set; }
        public string source { get; set; }
        public long? timemodified { get; set; }
        public long? loggeduser { get; set; }
        public long courseid { get; set; }
        public long userid { get; set; }
        public string name { get; set; }
        public string scale { get; set; }
        public string description { get; set; }
    }
}