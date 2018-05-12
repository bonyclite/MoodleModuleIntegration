namespace Moodle3KL.Domain
{
    public class mdl_competency_userevidence : mdl_entity_base {
        public long userid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public string url { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
    }
}