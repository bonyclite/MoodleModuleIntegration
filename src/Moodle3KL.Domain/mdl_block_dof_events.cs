namespace Moodle3KL.Domain
{
    public class mdl_block_dof_events : mdl_entity_base {
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public string eventcode { get; set; }
        public string rplugintype { get; set; }
        public string rplugincode { get; set; }
    }
}