namespace Moodle3KL.Domain
{
    public class mdl_assign_plugin_config : mdl_entity_base {
        public long assignment { get; set; }
        public string plugin { get; set; }
        public string subtype { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}