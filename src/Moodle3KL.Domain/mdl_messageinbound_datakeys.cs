namespace Moodle3KL.Domain
{
    public class mdl_messageinbound_datakeys : mdl_entity_base {
        public long handler { get; set; }
        public long datavalue { get; set; }
        public string datakey { get; set; }
        public long timecreated { get; set; }
        public long? expires { get; set; }
    }
}