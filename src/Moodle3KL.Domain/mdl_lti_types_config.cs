namespace Moodle3KL.Domain
{
    public class mdl_lti_types_config : mdl_entity_base {
        public long typeid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}