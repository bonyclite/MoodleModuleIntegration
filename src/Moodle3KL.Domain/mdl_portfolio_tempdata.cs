namespace Moodle3KL.Domain
{
    public class mdl_portfolio_tempdata : mdl_entity_base {
        public string data { get; set; }
        public long expirytime { get; set; }
        public long userid { get; set; }
        public long? instance { get; set; }
        public short queued { get; set; }
    }
}