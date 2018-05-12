namespace Moodle3KL.Domain
{
    public class mdl_block_positions : mdl_entity_base
    {
        public long blockinstanceid { get; set; }
        public long contextid { get; set; }
        public string pagetype { get; set; }
        public string subpage { get; set; }
        public short visible { get; set; }
        public string region { get; set; }
        public long weight { get; set; }
    }
}