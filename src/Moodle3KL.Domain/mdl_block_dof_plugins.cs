namespace Moodle3KL.Domain
{
    public class mdl_block_dof_plugins : mdl_entity_base
    {
        public string type { get; set; }
        public string code { get; set; }
        public string version { get; set; }
        public long? cron { get; set; }
        public long? lastcron { get; set; }
    }
}