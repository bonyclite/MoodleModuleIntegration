namespace Moodle3KL.Domain
{
    public class mdl_config_log : mdl_entity_base
    {
        public long userid { get; set; }
        public long timemodified { get; set; }
        public string plugin { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string oldvalue { get; set; }
    }
}