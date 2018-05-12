namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_agrouphistory : mdl_entity_base {
        public long agroupid { get; set; }
        public long ageid { get; set; }
        public long agenum { get; set; }
        public long changedate { get; set; }
        public long? orderid { get; set; }
    }
}