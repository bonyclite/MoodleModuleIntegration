namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_schdays : mdl_entity_base {
        public long ageid { get; set; }
        public long date { get; set; }
        public short? daynum { get; set; }
        public short? dayvar { get; set; }
        public long? departmentid { get; set; }
        public string type { get; set; }
        public string status { get; set; }
    }
}