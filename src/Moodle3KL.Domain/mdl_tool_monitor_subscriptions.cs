namespace Moodle3KL.Domain
{
    public class mdl_tool_monitor_subscriptions : mdl_entity_base
    {
        public long courseid { get; set; }
        public long ruleid { get; set; }
        public long cmid { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long lastnotificationsent { get; set; }
        public long inactivedate { get; set; }
    }
}