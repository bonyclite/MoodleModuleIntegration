namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_cstreamlinks
    {
        public long id { get; set; }
        public long? cstreamid { get; set; }
        public long? agroupid { get; set; }
        public string agroupsync { get; set; }
    }
}