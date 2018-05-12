namespace Moodle3KL.Domain
{
    public class mdl_filter_config : mdl_entity_base {
        public string filter { get; set; }
        public long contextid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}