namespace Moodle3KL.Domain
{
    public class mdl_external_services : mdl_entity_base
    {
        public string name { get; set; }
        public short enabled { get; set; }
        public string requiredcapability { get; set; }
        public short restrictedusers { get; set; }
        public string component { get; set; }
        public long timecreated { get; set; }
        public long? timemodified { get; set; }
        public string shortname { get; set; }
        public short downloadfiles { get; set; }
        public short uploadfiles { get; set; }
    }
}