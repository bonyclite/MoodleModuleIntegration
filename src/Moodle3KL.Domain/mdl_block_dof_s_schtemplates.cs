namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_schtemplates : mdl_entity_base
    {
        public long? cstreamid { get; set; }
        public short? daynum { get; set; }
        public short? dayvar { get; set; }

        public string type { get; set; }

        //[Column("begin")]
        public long? abegin { get; set; }
        public long? duration { get; set; }
        public string place { get; set; }
        public string form { get; set; }
        public long? departmentid { get; set; }
        public string status { get; set; }
        public double salfactor { get; set; }
    }
}