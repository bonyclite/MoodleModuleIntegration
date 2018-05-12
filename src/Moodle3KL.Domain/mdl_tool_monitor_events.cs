namespace Moodle3KL.Domain
{
    public class mdl_tool_monitor_events : mdl_entity_base
    {
        public string eventname { get; set; }
        public long contextid { get; set; }
        public long contextlevel { get; set; }
        public long contextinstanceid { get; set; }
        public string link { get; set; }
        public long courseid { get; set; }
        public long timecreated { get; set; }
    }
}