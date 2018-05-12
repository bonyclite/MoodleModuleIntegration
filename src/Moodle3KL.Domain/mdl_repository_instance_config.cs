namespace Moodle3KL.Domain
{
    public class mdl_repository_instance_config : mdl_entity_base {
        public long instanceid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}