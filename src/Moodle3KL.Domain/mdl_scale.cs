namespace Moodle3KL.Domain
{
    public class mdl_scale : mdl_entity_base {
        public long courseid { get; set; }
        public long userid { get; set; }
        public string name { get; set; }
        public string scale { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public long timemodified { get; set; }
    }
}