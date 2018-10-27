namespace Moodle3KL.Domain
{
    public class mdl_lti_types : mdl_entity_base
    {
        public string name { get; set; }
        public string baseurl { get; set; }
        public string tooldomain { get; set; }
        public short state { get; set; }
        public long course { get; set; }
        public short coursevisible { get; set; }
        public long? toolproxyid { get; set; }
        public string enabledcapability { get; set; }
        public string parameter { get; set; }
        public string icon { get; set; }
        public string secureicon { get; set; }
        public long createdby { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string description { get; set; }
    }
}