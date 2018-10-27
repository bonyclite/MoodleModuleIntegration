namespace Moodle3KL.Domain
{
    public class mdl_workshopeval_best_settings : mdl_entity_base
    {
        public long workshopid { get; set; }
        public short? comparison { get; set; }
    }
}