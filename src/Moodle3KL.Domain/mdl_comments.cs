namespace Moodle3KL.Domain
{
    public class mdl_comments : mdl_entity_base {
        public long contextid { get; set; }
        public string component { get; set; }
        public string commentarea { get; set; }
        public long itemid { get; set; }
        public string content { get; set; }
        public short format { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
    }
}