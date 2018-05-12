namespace Moodle3KL.Domain
{
    public class mdl_block : mdl_entity_base {
        public string name { get; set; }
        public long cron { get; set; }
        public long lastcron { get; set; }
        public short visible { get; set; }
    }
}