namespace Moodle3KL.Domain
{
    public class mdl_config_plugins : mdl_entity_base
    {
        public string plugin { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}