namespace Moodle3KL.Domain
{
    public class mdl_block_recent_activity : mdl_entity_base {
        public long courseid { get; set; }
        public long cmid { get; set; }
        public long timecreated { get; set; }
        public long userid { get; set; }
        public short action { get; set; }
        public string modname { get; set; }
    }
}