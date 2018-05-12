namespace Moodle3KL.Domain
{
    public class mdl_messageinbound_messagelist : mdl_entity_base
    {
        public string messageid { get; set; }
        public long userid { get; set; }
        public string address { get; set; }
        public long timecreated { get; set; }
    }
}