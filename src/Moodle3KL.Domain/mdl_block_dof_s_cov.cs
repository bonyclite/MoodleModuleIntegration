namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_cov : mdl_entity_base
    {
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public string substorage { get; set; }
        public long objectid { get; set; }
        public string code { get; set; }
        public string value { get; set; }
    }
}