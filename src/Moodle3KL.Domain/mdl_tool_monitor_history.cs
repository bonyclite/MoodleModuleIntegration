namespace Moodle3KL.Domain
{
    public class mdl_tool_monitor_history : mdl_entity_base {
        public long sid { get; set; }
        public long userid { get; set; }
        public long timesent { get; set; }
    }
}