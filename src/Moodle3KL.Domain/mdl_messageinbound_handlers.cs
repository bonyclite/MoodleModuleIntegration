namespace Moodle3KL.Domain
{
    public class mdl_messageinbound_handlers : mdl_entity_base
    {
        public string component { get; set; }
        public string classname { get; set; }
        public long defaultexpiration { get; set; }
        public short validateaddress { get; set; }
        public short enabled { get; set; }
    }
}