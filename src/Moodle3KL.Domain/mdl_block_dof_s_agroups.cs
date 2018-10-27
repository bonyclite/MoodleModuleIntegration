namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_agroups : mdl_entity_base
    {
        public string name { get; set; }
        public string code { get; set; }
        public long? programmid { get; set; }
        public long? departmentid { get; set; }
        public short agenum { get; set; }
        public string status { get; set; }
        public long? metacontractid { get; set; }
        public double salfactor { get; set; }
    }
}