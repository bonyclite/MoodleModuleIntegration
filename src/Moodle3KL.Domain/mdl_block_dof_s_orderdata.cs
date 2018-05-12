namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_orderdata : mdl_entity_base {
        public long orderid { get; set; }
        public string firstlvlname { get; set; }
        public long varnum { get; set; }
        public short scalar { get; set; }
        public string data { get; set; }
        public string ind { get; set; }
    }
}