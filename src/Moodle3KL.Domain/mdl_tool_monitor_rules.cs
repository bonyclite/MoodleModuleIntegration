namespace Moodle3KL.Domain
{
    public class mdl_tool_monitor_rules : mdl_entity_base
    {
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public string name { get; set; }
        public long userid { get; set; }
        public long courseid { get; set; }
        public string plugin { get; set; }
        public string eventname { get; set; }
        public string template { get; set; }
        public short templateformat { get; set; }
        public short frequency { get; set; }
        public int timewindow { get; set; }
        public long timemodified { get; set; }
        public long timecreated { get; set; }
    }
}