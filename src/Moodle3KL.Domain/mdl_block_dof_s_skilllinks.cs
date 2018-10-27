namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_skilllinks : mdl_entity_base
    {
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public string code { get; set; }
        public long objectid { get; set; }
        public long skillid { get; set; }
        public double grade { get; set; }
        public long date { get; set; }
    }
}