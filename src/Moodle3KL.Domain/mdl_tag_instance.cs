namespace Moodle3KL.Domain
{
    public class mdl_tag_instance : mdl_entity_base {
        public long tagid { get; set; }
        public string component { get; set; }
        public string itemtype { get; set; }
        public long itemid { get; set; }
        public long? contextid { get; set; }
        public long tiuserid { get; set; }
        public long? ordering { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}