namespace Moodle3KL.Domain
{
    public class mdl_auth_otoauth : mdl_entity_base {
        public long userid { get; set; }
        public string service { get; set; }
        public string remoteuserid { get; set; }
        public long? datacreate { get; set; }
        public long? lastaccess { get; set; }
        public long? active { get; set; }
        public long? cron { get; set; }
        public long? lastcron { get; set; }
    }
}